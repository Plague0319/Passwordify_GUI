namespace Passwordify_GUI
{
    partial class User_menu
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
            this.addpasswd_button = new System.Windows.Forms.Button();
            this.passwords_button = new System.Windows.Forms.Button();
            this.keyword_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addpasswd_button
            // 
            this.addpasswd_button.Location = new System.Drawing.Point(206, 82);
            this.addpasswd_button.Name = "addpasswd_button";
            this.addpasswd_button.Size = new System.Drawing.Size(380, 23);
            this.addpasswd_button.TabIndex = 0;
            this.addpasswd_button.Text = "Add Password";
            this.addpasswd_button.UseVisualStyleBackColor = true;
            // 
            // passwords_button
            // 
            this.passwords_button.Location = new System.Drawing.Point(206, 133);
            this.passwords_button.Name = "passwords_button";
            this.passwords_button.Size = new System.Drawing.Size(380, 23);
            this.passwords_button.TabIndex = 1;
            this.passwords_button.Text = "View Passwords";
            this.passwords_button.UseVisualStyleBackColor = true;
            // 
            // keyword_button
            // 
            this.keyword_button.Location = new System.Drawing.Point(206, 192);
            this.keyword_button.Name = "keyword_button";
            this.keyword_button.Size = new System.Drawing.Size(380, 23);
            this.keyword_button.TabIndex = 2;
            this.keyword_button.Text = "Search by keyword (platform/password)";
            this.keyword_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(206, 250);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(380, 23);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username_label.Location = new System.Drawing.Point(292, 9);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(196, 46);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "username";
            // 
            // User_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.keyword_button);
            this.Controls.Add(this.passwords_button);
            this.Controls.Add(this.addpasswd_button);
            this.Name = "User_menu";
            this.Text = "User_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addpasswd_button;
        private System.Windows.Forms.Button passwords_button;
        private System.Windows.Forms.Button keyword_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_label;
    }
}