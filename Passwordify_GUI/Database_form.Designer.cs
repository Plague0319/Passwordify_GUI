namespace Passwordify_GUI
{
    partial class Database_form
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
            this.connect_btn = new System.Windows.Forms.Button();
            this.database_text = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.server_text = new System.Windows.Forms.TextBox();
            this.database_type = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connect_btn.Location = new System.Drawing.Point(278, 330);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(268, 40);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Save";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // database_text
            // 
            this.database_text.Location = new System.Drawing.Point(356, 53);
            this.database_text.Multiline = true;
            this.database_text.Name = "database_text";
            this.database_text.Size = new System.Drawing.Size(311, 26);
            this.database_text.TabIndex = 1;
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(356, 157);
            this.username_text.Multiline = true;
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(311, 26);
            this.username_text.TabIndex = 3;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(356, 221);
            this.password_text.Multiline = true;
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(311, 26);
            this.password_text.TabIndex = 4;
            this.password_text.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database Type";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(54, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(54, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(54, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Server";
            // 
            // server_text
            // 
            this.server_text.Location = new System.Drawing.Point(356, 282);
            this.server_text.Multiline = true;
            this.server_text.Name = "server_text";
            this.server_text.Size = new System.Drawing.Size(311, 26);
            this.server_text.TabIndex = 10;
            // 
            // database_type
            // 
            this.database_type.FormattingEnabled = true;
            this.database_type.Items.AddRange(new object[] {
            "Mysql"});
            this.database_type.Location = new System.Drawing.Point(356, 113);
            this.database_type.Name = "database_type";
            this.database_type.Size = new System.Drawing.Size(311, 21);
            this.database_type.TabIndex = 12;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(278, 392);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(268, 46);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Database_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.database_type);
            this.Controls.Add(this.server_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.database_text);
            this.Controls.Add(this.connect_btn);
            this.MaximizeBox = false;
            this.Name = "Database_form";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox database_text;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox server_text;
        private System.Windows.Forms.ComboBox database_type;
        private System.Windows.Forms.Button back_button;
    }
}