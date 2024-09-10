using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Crypto.Encodings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwordify_GUI
{
   
    public partial class Passwordify_GUI : Form
    {
        public Passwordify_GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database_form d1 = new Database_form();
            
        }

        public void SetResultLabel(string str)
        {
            this.connection_status_label.Text = str;
            this.connection_status_label.Refresh();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            
            if (connection_status_label.Text == "Connected")
            {
                Register reg = new Register();
                reg.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("There is no connection to the database", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            bool user_error=false;
            if (connection_status_label.Text == "Connected")
            {

                /*MessageBox.Show("Login s
                  uccessful", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                if (user_pw.Text == "")
                {
                    user_error = true;
                }
                if (usr_name.Text == "")
                {
                    user_error = true;
                }
                if (user_error)
                {
                    MessageBox.Show("Username or Password is not filled!", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    User u1 = new User("Jelszavazo", "mysql", "root", "", "localhost");

                    try
                    {
                        u1.Login(usr_name.Text, user_pw.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no connection to the database", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //connection_status.Text = "Connected";
            }
        }

        private void Database_btn_Click(object sender, EventArgs e)
        {
            Database_form d1 = new Database_form();
            d1.Show();
            Visible = false;
        }
    }
}
