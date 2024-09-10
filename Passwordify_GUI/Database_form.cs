using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Passwordify_GUI
{
    public partial class Database_form : Form
    {
        public Database_form()
        {
            InitializeComponent();
        }

        
        private void Database_form_Load(object sender, EventArgs e)
        {

        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            string database = database_text.Text.Trim();
            string Database_type=database_type.Text.Trim();
            string username=username_text.Text.Trim();
            string password=password_text.Text.Trim();
            string server = server_text.Text.Trim();

            Database d1 = new Database(database,Database_type,username,password,server);

            try
            {
                d1.IsConnect();
                if (d1.IsConnect())
                {
                
                Passwordify_GUI p1 = new Passwordify_GUI();

                p1.Show();
                p1.SetResultLabel("Connected");
                Visible = false;
                 }

            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
                
            }
                


            
            




        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Passwordify_GUI p1 = new Passwordify_GUI();
            p1.Show();
            Visible = false;

        }
    }
}
