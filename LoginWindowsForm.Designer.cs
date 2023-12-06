namespace CashierApplication
{
    partial class _userLogin
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
            this.TextBox_username = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.Label_password = new System.Windows.Forms.Label();
            this.TextBox_password = new System.Windows.Forms.TextBox();
            this.Button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_username
            // 
            this.TextBox_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_username.Location = new System.Drawing.Point(42, 60);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.Size = new System.Drawing.Size(155, 22);
            this.TextBox_username.TabIndex = 0;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(39, 41);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(75, 16);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "Username*";
            // 
            // Label_password
            // 
            this.Label_password.AutoSize = true;
            this.Label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_password.Location = new System.Drawing.Point(40, 101);
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(72, 16);
            this.Label_password.TabIndex = 2;
            this.Label_password.Text = "Password*";
            // 
            // TextBox_password
            // 
            this.TextBox_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_password.Location = new System.Drawing.Point(43, 129);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.Size = new System.Drawing.Size(155, 22);
            this.TextBox_password.TabIndex = 3;
            this.TextBox_password.UseSystemPasswordChar = true;
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.Color.LightCoral;
            this.Button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.Location = new System.Drawing.Point(79, 170);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(91, 30);
            this.Button_login.TabIndex = 4;
            this.Button_login.Text = "Login";
            this.Button_login.UseVisualStyleBackColor = false;
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // _userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(238, 221);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.LabelUsername);
            this.Name = "_userLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_username;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label Label_password;
        private System.Windows.Forms.TextBox TextBox_password;
        private System.Windows.Forms.Button Button_login;
    }
}