using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlX.XDevAPI;
using System.Diagnostics;
using System.Xml.Linq;

namespace Passwordify_GUI
{
     class Database
    {
        protected string databaseName;
        protected string database_type;
        protected string usr_name;
        protected string password;
        protected string server;
        protected string conn_status;
        protected MySqlConnection connection;
        protected MySqlDataReader Reader;
        protected int session_id;

        public Database(string databaseName, string database_type, string user_name, string password, string server)
        {
            this.databaseName = databaseName;
            this.database_type = database_type;
            this.usr_name = user_name;
            this.password = password;
            this.server = server;
        }
        public MySqlConnection Connection { get; set; }

        private static Database _instance = null;
        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, databaseName, usr_name, password);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
            }

            return true;
        }

        
        public void Close()
        {
            Connection.Close();
        }
    }
}
