using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Passwordify_GUI
{
    class User : Database
    {
        private int user_session;
        private string id;
        private string username;
        private string user_password;
        private string email;
        private bool session;
        private string username_string;

        public User(string databaseName, string database_type, string user_name, string password, string server) : base(databaseName, database_type, user_name, password, server)
        {
            this.username = username;
            this.user_password = user_password;
            this.email = email;
            this.session = session;
            this.databaseName = databaseName;
            this.database_type = database_type;
            this.server = server;
            this.password = password;
        }
        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            databaseName + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public bool Session { get => session; set => session = value; }
        public string ID { get => id; set => id = value; }
        public int User_session { get => user_session; set => user_session = value; }
        public void Login(string username, string password)
        {
            /*password = password.GetHashCode().ToString();
            MySqlCommand cmd = Connection.CreateCommand();
            cmd.CommandText = "SELECT username from users WHERE username ='" + username+"password="+password;
            */

            string login = "SELECT * FROM users WHERE name=@name_data and password=@password_data";
            //string query = "Select id from users where name=@name_data";

            {
                if (this.IsConnect() == true)
                {
                    //create command and assign the query and connection from the constructor

                    MySqlCommand cmd = new MySqlCommand(login, connection);

                    //MySqlCommand cmd2 = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name_data", username);
                    cmd.Parameters.AddWithValue("@password_data", password);
                    //int usr_id = Convert.ToInt32(cmd.ExecuteScalar());
                    //cmd.Parameters.IndexOf(name);
                    // cmd2.Parameters.AddWithValue("@name_data", name);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            session = true;
                            Console.Clear();
                            if (session)
                            {
                                //user_id = id;
                                session_id = Convert.ToInt32(reader["id"]);
                                user_session = Convert.ToInt32(reader["id"]);
                                //Console.WriteLine("Sikeres belépés\nuser id:" + session_id);

                            }








                        }
                        else
                        {
                            MessageBox.Show("helytelen név/jelszó", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }

                    }
                }
            }
        }
    }
}
        