namespace PresentationLayer
{
    partial class FormAddUser
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
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewFirstName = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.inptNewName = new System.Windows.Forms.TextBox();
            this.inptNewPassword = new System.Windows.Forms.TextBox();
            this.inptNewFirstName = new System.Windows.Forms.TextBox();
            this.inptNewLastName = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(163, 83);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(110, 20);
            this.lblNewName.TabIndex = 0;
            this.lblNewName.Text = "Korisnicko ime";
            this.lblNewName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(163, 149);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(64, 20);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Lozinka";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewFirstName
            // 
            this.lblNewFirstName.AutoSize = true;
            this.lblNewFirstName.Location = new System.Drawing.Point(163, 212);
            this.lblNewFirstName.Name = "lblNewFirstName";
            this.lblNewFirstName.Size = new System.Drawing.Size(36, 20);
            this.lblNewFirstName.TabIndex = 2;
            this.lblNewFirstName.Text = "Ime";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(163, 279);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(66, 20);
            this.lblNewLastName.TabIndex = 3;
            this.lblNewLastName.Text = "Prezime";
            this.lblNewLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inptNewName
            // 
            this.inptNewName.Location = new System.Drawing.Point(394, 83);
            this.inptNewName.Name = "inptNewName";
            this.inptNewName.Size = new System.Drawing.Size(100, 26);
            this.inptNewName.TabIndex = 4;
            // 
            // inptNewPassword
            // 
            this.inptNewPassword.Location = new System.Drawing.Point(394, 149);
            this.inptNewPassword.Name = "inptNewPassword";
            this.inptNewPassword.Size = new System.Drawing.Size(100, 26);
            this.inptNewPassword.TabIndex = 5;
            // 
            // inptNewFirstName
            // 
            this.inptNewFirstName.Location = new System.Drawing.Point(394, 212);
            this.inptNewFirstName.Name = "inptNewFirstName";
            this.inptNewFirstName.Size = new System.Drawing.Size(100, 26);
            this.inptNewFirstName.TabIndex = 6;
            // 
            // inptNewLastName
            // 
            this.inptNewLastName.Location = new System.Drawing.Point(394, 273);
            this.inptNewLastName.Name = "inptNewLastName";
            this.inptNewLastName.Size = new System.Drawing.Size(100, 26);
            this.inptNewLastName.TabIndex = 7;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(271, 337);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(120, 50);
            this.btnNewUser.TabIndex = 8;
            this.btnNewUser.Text = "Spremi";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.inptNewLastName);
            this.Controls.Add(this.inptNewFirstName);
            this.Controls.Add(this.inptNewPassword);
            this.Controls.Add(this.inptNewName);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblNewFirstName);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblNewName);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblNewName;
        public System.Windows.Forms.Label lblNewPassword;
        public System.Windows.Forms.Label lblNewFirstName;
        public System.Windows.Forms.Label lblNewLastName;
        public System.Windows.Forms.TextBox inptNewName;
        public System.Windows.Forms.TextBox inptNewPassword;
        public System.Windows.Forms.TextBox inptNewFirstName;
        public System.Windows.Forms.TextBox inptNewLastName;
        public System.Windows.Forms.Button btnNewUser;
    }
}