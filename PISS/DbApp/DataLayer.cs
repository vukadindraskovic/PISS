using Amazon.Auth.AccessControlPolicy;
using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace DbApp
{
    class DataLayer
    {
        private MongoClient _dbClient = null;
        private static object objLock = new object();
        private static string _username;
        private static string _password;
        private static DataLayer _dataLayer;

        private DataLayer()
        {
            _dbClient = new MongoClient($"mongodb://{_username}:{_password}@localhost:27017/admin");
        }

        public static DataLayer Instance
        {
            get
            {
                if (_dataLayer == null)
                {
                    lock (objLock)
                    {
                        if (_dataLayer == null)
                        {
                            try
                            {
                                _dataLayer = new DataLayer();
                            }
                            catch (MongoException ex)
                            {
                                Console.WriteLine("An error occurred while connecting to MongoDB: " + ex.Message);
                                _dataLayer = null;
                            }

                        }
                    }
                }

                return _dataLayer;
            }
        }

        public bool IsAdmin 
        { 
            get
            {
                try
                {
                    GetAllUsers();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"User {_username} is not admin: {ex.Message}");
                    _dataLayer = null;
                    return false;
                }
            }
        }

        public static void SetCredentials(string username, string password)
        {
            _username = username;
            _password = password;
            _dataLayer = null;
        }

        public IList<string> GetAllDatabases()
        {
            return _dbClient.ListDatabaseNames().ToList();
        }

        public IList<BsonValue> GetAllUsers()
        {
            var command = new BsonDocumentCommand<BsonDocument>(new BsonDocument { { "find", "system.users" } });
            var result = _dbClient.GetDatabase("admin").RunCommand(command);
            return result["cursor"]["firstBatch"].AsBsonArray.ToList();
        }

        public IList<string> GetUserDefinedRolesOfDatabase(string databaseName)
        {
            var command = new BsonDocumentCommand<BsonDocument>(new BsonDocument { { "rolesInfo", 1 } });
            var result = _dbClient.GetDatabase(databaseName).RunCommand(command);
            return result["roles"].AsBsonArray.Select(r => r["role"].ToString()).ToList();
        }

        public IList<string> GetAllCollectionsOfDatabase(string databaseName)
        {
            return _dbClient.GetDatabase(databaseName).ListCollectionNames().ToList();
        }

        public void DeleteCollectionOfDatabase(string collectionName, string databaseName)
        {
            _dbClient.GetDatabase(databaseName).DropCollection(collectionName);
        }

        public void DeleteDatabase(string databaseName)
        {
            _dbClient.DropDatabase(databaseName);
        }

        public void DeleteUserFromDatabase(string username, string databaseName)
        {
            var command = new BsonDocumentCommand<BsonDocument>(new BsonDocument { { "dropUser", username } });
            _dbClient.GetDatabase(databaseName).RunCommand(command);
        }

        public IList<string> GetAllRolesOfDatabase(string databaseName)
        {
            var command = new BsonDocumentCommand<BsonDocument>(new BsonDocument { { "rolesInfo", 1 }, { "showBuiltinRoles", true } });
            var result = _dbClient.GetDatabase(databaseName).RunCommand(command);
            return result["roles"].AsBsonArray.Select(r => r["role"].ToString()).ToList();
        }

        public void AddUserToDatabase(string username, string password, IList<string> roles, string databaseName)
        {
            var rolesBson = new BsonArray();

            foreach (var role in roles)
            {
                rolesBson.Add(new BsonDocument { { "role", role }, { "db", databaseName } });
            }

            var command = new BsonDocument
            {
                { "createUser", username },
                { "pwd", password },
                { "roles", rolesBson }
            };

            _dbClient.GetDatabase(databaseName).RunCommand<BsonDocument>(command);
        }

        public BsonArray GetUserDefinedRolesWithPrivilegesOfDatabase(string databaseName)
        {
            var command = new BsonDocumentCommand<BsonDocument>(new BsonDocument { { "rolesInfo", 1 }, { "showPrivileges", true } });
            var result = _dbClient.GetDatabase(databaseName).RunCommand(command);
            return result["roles"].AsBsonArray;
        }

        public void AddRoleToDatabase(string roleName, string databaseName)
        {
            var command = new BsonDocument
            {
                { "createRole", roleName },
                { "roles", new BsonArray() },
                { "privileges", new BsonArray() }
            };

            _dbClient.GetDatabase(databaseName).RunCommand<BsonDocument>(command);
        }

        public void DeleteRoleFromDatabase(string roleName, string databaseName) 
        {
            var command = new BsonDocument
            {
                { "dropRole", roleName }
            };

            var result = _dbClient.GetDatabase(databaseName).RunCommand<BsonDocument>(command);
        }

        public void AddPrivilegeToRole(string roleName, string databaseName, string resource, IList<string> actions)
        {
            var command = new BsonDocument
            {
                { "grantPrivilegesToRole", roleName }, 
                { "privileges", new BsonArray
                    {
                        new BsonDocument
                        {
                                { "resource", new BsonDocument { { "db", databaseName }, { "collection", resource } } },
                                { "actions", new BsonArray(actions) }
                        }
                    }
                }
            };

            _dbClient.GetDatabase(databaseName).RunCommand<BsonDocument>(command);
        }

        public void DeletePrivilegeFromRole(string roleName, string resource, IList<string> actions, string databaseName)
        {
            var command = new BsonDocument
            {
                { "revokePrivilegesFromRole", roleName },
                { "privileges", new BsonArray
                    {
                        new BsonDocument
                        {
                                { "resource", new BsonDocument { { "db", databaseName }, { "collection", resource } } },
                                { "actions", new BsonArray(actions) }
                        }
                    }
                }
            };

            _dbClient.GetDatabase(databaseName).RunCommand<BsonDocument>(command);
        }

        public void ChangeUsersPassword(string username, string password, string databaseName)
        {
            var command = new BsonDocument
            {
                { "updateUser", username },
                { "pwd", password }
            };

            _dbClient.GetDatabase(databaseName).RunCommand<BsonDocument>(command);
        }

        public void UpdateUsersRoles(string username, IList<string> roles, string databaseName)
        {
            var rolesArray = new BsonArray();

            foreach (var r in roles)
            {
                rolesArray.Add(new BsonDocument
                {
                    { "role", r },
                    { "db", databaseName }
                });
            }

            var command = new BsonDocument
            {
                { "updateUser", username },
                { "roles", rolesArray }
            };

            _dbClient.GetDatabase(databaseName).RunCommand<BsonDocument>(command);
        }
    }
}
