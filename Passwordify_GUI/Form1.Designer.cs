namespace Passwordify_GUI
{
    partial class Passwordify_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.usr_name = new System.Windows.Forms.TextBox();
            this.user_pw = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.connection_status_label = new System.Windows.Forms.Label();
            this.Database_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(265, 320);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(491, 320);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 1;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // usr_name
            // 
            this.usr_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usr_name.Location = new System.Drawing.Point(265, 116);
            this.usr_name.Name = "usr_name";
            this.usr_name.Size = new System.Drawing.Size(301, 20);
            this.usr_name.TabIndex = 2;
            this.usr_name.Tag = "";
            // 
            // user_pw
            // 
            this.user_pw.Location = new System.Drawing.Point(265, 236);
            this.user_pw.Name = "user_pw";
            this.user_pw.Size = new System.Drawing.Size(301, 20);
            this.user_pw.TabIndex = 3;
            this.user_pw.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(264, 75);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(168, 38);
            this.username.TabIndex = 4;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(264, 195);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(162, 38);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // connection_status_label
            // 
            this.connection_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connection_status_label.Location = new System.Drawing.Point(559, 9);
            this.connection_status_label.Name = "connection_status_label";
            this.connection_status_label.Size = new System.Drawing.Size(240, 42);
            this.connection_status_label.TabIndex = 6;
            this.connection_status_label.Text = "Not Connected";
            this.connection_status_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Database_btn
            // 
            this.Database_btn.Location = new System.Drawing.Point(365, 319);
            this.Database_btn.Name = "Database_btn";
            this.Database_btn.Size = new System.Drawing.Size(101, 24);
            this.Database_btn.TabIndex = 7;
            this.Database_btn.Text = "server config";
            this.Database_btn.UseVisualStyleBackColor = true;
            this.Database_btn.Click += new System.EventHandler(this.Database_btn_Click);
            // 
            // Passwordify_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Database_btn);
            this.Controls.Add(this.connection_status_label);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.user_pw);
            this.Controls.Add(this.usr_name);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.MaximizeBox = false;
            this.Name = "Passwordify_GUI";
            this.Text = "Passwordify GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox usr_name;
        private System.Windows.Forms.TextBox user_pw;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label connection_status_label;
        private System.Windows.Forms.Button Database_btn;
    }
}

