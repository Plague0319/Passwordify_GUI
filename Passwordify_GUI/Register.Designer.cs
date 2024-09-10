namespace Passwordify_GUI
{
    partial class Register
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
            this.register_btn = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.Label();
            this.pw_1 = new System.Windows.Forms.Label();
            this.pw_2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password2_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(278, 348);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(354, 23);
            this.register_btn.TabIndex = 0;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_name.Location = new System.Drawing.Point(12, 67);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(168, 38);
            this.user_name.TabIndex = 1;
            this.user_name.Text = "Username";
            // 
            // pw_1
            // 
            this.pw_1.AutoSize = true;
            this.pw_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pw_1.Location = new System.Drawing.Point(12, 132);
            this.pw_1.Name = "pw_1";
            this.pw_1.Size = new System.Drawing.Size(162, 38);
            this.pw_1.TabIndex = 2;
            this.pw_1.Text = "Password";
            // 
            // pw_2
            // 
            this.pw_2.AutoSize = true;
            this.pw_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pw_2.Location = new System.Drawing.Point(12, 210);
            this.pw_2.Name = "pw_2";
            this.pw_2.Size = new System.Drawing.Size(259, 38);
            this.pw_2.TabIndex = 3;
            this.pw_2.Text = "Password verify ";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email.Location = new System.Drawing.Point(12, 284);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(98, 38);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(278, 65);
            this.username_textbox.Multiline = true;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(354, 40);
            this.username_textbox.TabIndex = 5;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(278, 132);
            this.password_textbox.Multiline = true;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(354, 40);
            this.password_textbox.TabIndex = 6;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // password2_textbox
            // 
            this.password2_textbox.Location = new System.Drawing.Point(278, 210);
            this.password2_textbox.Multiline = true;
            this.password2_textbox.Name = "password2_textbox";
            this.password2_textbox.Size = new System.Drawing.Size(354, 40);
            this.password2_textbox.TabIndex = 7;
            this.password2_textbox.UseSystemPasswordChar = true;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(278, 282);
            this.email_textbox.Multiline = true;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.ReadOnly = true;
            this.email_textbox.Size = new System.Drawing.Size(354, 40);
            this.email_textbox.TabIndex = 8;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(278, 393);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(354, 23);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "I have an accont ";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password2_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pw_2);
            this.Controls.Add(this.pw_1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.register_btn);
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label pw_1;
        private System.Windows.Forms.Label pw_2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox password2_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Button login_btn;
    }
}