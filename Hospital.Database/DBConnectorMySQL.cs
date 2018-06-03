using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Hospital.Config;
using MySql.Data.MySqlClient;

namespace Hospital.Database
{
    public class DBConnectorMySQL
    {
        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _uid;
        private string _password;
        private readonly IConfigParser _parser;

        //Constructor
        public DBConnectorMySQL()
        {
            _parser = new TxtConfigParser("config.ini");
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            //Host
            string buf = _parser.GetSetting("host", "host");
            _server = (buf == "") ? Properties.DatabaseDefaults.Host : buf;

            //Database
            buf = _parser.GetSetting("database", "string");
            _database = (buf == "") ? Properties.DatabaseDefaults.Database : buf;

            //Username
            buf = _parser.GetSetting("user", "string");
            _uid = (buf == "") ? Properties.DatabaseDefaults.User : buf;

            //Password
            _password = _parser.GetRawSetting("password");
            string connectionString = $"SERVER={_server};" +
                                      $"DATABASE={_database};" +
                                      $"UID={_uid};" +
                                      $"PASSWORD={_password};" +
                                      "CharSet=utf8;" +
                                      "Convert Zero Datetime=True";

            _connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception(Properties.MySQLMessages.CannotConnectError);

                    case 1045:
                        throw new Exception(Properties.MySQLMessages.InvalidPassword);
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Insert statement
        public void Insert(string tbname, List<string> fields, string values)
        {
            Insert(tbname, string.Join(",", fields), values);
        }

        //Insert statement
        public void Insert(string tbname, string fields, string values)
        {
            try
            {
                string query = $"INSERT INTO {tbname} ({fields}) VALUES({values})";
                //open connection
                if (OpenConnection())
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, _connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    CloseConnection();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Update statement
        public void Update(string tbname, List<string> set, string where)
        {
            Update(tbname, string.Join(",", set), where);
        }

        //Update statement
        public void Update(string tbname, string set, string where)
        {
            try
            {
                string query = $"UPDATE {tbname} SET {set} WHERE {where};";

                //Open connection
                if (OpenConnection())
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand
                    {
                        //Assign the query using CommandText
                        CommandText = query,
                        //Assign the connection using Connection
                        Connection = _connection
                    };

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    CloseConnection();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Delete statement
        public void Delete(string tbname, string where)
        {
            try
            {
                string query = $"DELETE FROM {tbname} WHERE {where};";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, _connection);
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Select statement
        public List<string>[] Select(string tbname, List<string> fieldNames = null, string where = "1")
        {
            string fields = fieldNames == null ? "*" : String.Join(",", fieldNames);

            return Select(tbname, fields, where);
        }

        //Select statement
        public List<string>[] Select(string tbname, string fieldNames, string where = "1")
        {
            try
            {
                string query = $"SELECT {fieldNames} FROM {tbname} WHERE {where};";

                List<string>[] list = null;
                //Open connection
                if (OpenConnection())
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, _connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Create a list to store the result
                    int amount = dataReader.FieldCount;

                    list = new List<string>[amount];
                    for (int i = 0; i < amount; i++)
                    {
                        list[i] = new List<string>();
                    }
                    
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            list[i].Add(dataReader.GetString(i) + "");
                        }
                    }

                    //close Data Reader
                    dataReader.Close();
                    
                    //close Connection
                    CloseConnection();
                }
                //return list to be displayed
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Count statement
        public int Count(string tbname)
        {
            try
            {
                string query = $"SELECT Count(*) FROM {tbname}";
                int count = -1;

                //Open Connection
                if (OpenConnection())
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, _connection);

                    //ExecuteScalar will return one value
                    count = int.Parse(cmd.ExecuteScalar() + "");

                    //close Connection
                    CloseConnection();
                }
                return count;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Backup
        public void Backup(string path)
        {
            try
            {
                DateTime time = DateTime.Now;
                int year = time.Year;
                int month = time.Month;
                int day = time.Day;
                int hour = time.Hour;
                int minute = time.Minute;
                int second = time.Second;
                int millisecond = time.Millisecond;

                //Save file to C:\ with the current date as a filename
                path += $"MySqlBackup{year}-{month}-{day}-{hour}-{minute}-{second}-{millisecond}.sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "mysqldump",
                    RedirectStandardInput = false,
                    RedirectStandardOutput = true,
                    Arguments = $@"-u{_uid} -p{_password} -h{_server} {_database}",
                    UseShellExecute = false
                };

                Process process = Process.Start(psi);


                if (process != null)
                {
                    string output = process.StandardOutput.ReadToEnd();
                    file.WriteLine(output);
                    process.WaitForExit();
                    file.Close();
                    process.Close();
                }
                else throw new NullReferenceException();
            }
            catch (IOException)
            {
                throw new Exception(Properties.MySQLMessages.UnableToBackup);
            }
            catch
            {
                throw new Exception(Properties.MySQLMessages.UnknownError);
            }
        }

        //Restore
        public void Restore(string path)
        {
            try
            {
                //Read file from C:\
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "mysql",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    Arguments = $@"-u{_uid} -p{_password} -h{_server} {_database}",
                    UseShellExecute = false
                };


                Process process = Process.Start(psi);
                if (process != null)
                {
                    process.StandardInput.WriteLine(input);
                    process.StandardInput.Close();
                    process.WaitForExit();
                    process.Close();
                }
                else throw new NullReferenceException();
            }
            catch (IOException)
            {
                throw new Exception(Properties.MySQLMessages.UnableToBackup);
            }
            catch
            {
                throw new Exception(Properties.MySQLMessages.UnknownError);
            }
        }
    }
}
