namespace PresentationLayer
{
    partial class FormEditUser
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
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblEditUserName = new System.Windows.Forms.Label();
            this.lblEditUserId = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.inptEditName = new System.Windows.Forms.TextBox();
            this.inptEditLastName = new System.Windows.Forms.TextBox();
            this.inptEditPassword = new System.Windows.Forms.TextBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditTitle.Location = new System.Drawing.Point(284, 51);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(174, 29);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "Uredi korisnika";
            // 
            // lblEditUserName
            // 
            this.lblEditUserName.AutoSize = true;
            this.lblEditUserName.Location = new System.Drawing.Point(327, 91);
            this.lblEditUserName.Name = "lblEditUserName";
            this.lblEditUserName.Size = new System.Drawing.Size(85, 20);
            this.lblEditUserName.TabIndex = 1;
            this.lblEditUserName.Text = "UserName";
            this.lblEditUserName.Click += new System.EventHandler(this.lblEditUserName_Click);
            // 
            // lblEditUserId
            // 
            this.lblEditUserId.AutoSize = true;
            this.lblEditUserId.Location = new System.Drawing.Point(338, 124);
            this.lblEditUserId.Name = "lblEditUserId";
            this.lblEditUserId.Size = new System.Drawing.Size(60, 20);
            this.lblEditUserId.TabIndex = 2;
            this.lblEditUserId.Text = "UserID";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(79, 168);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(36, 20);
            this.lblEditName.TabIndex = 3;
            this.lblEditName.Text = "Ime";
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Location = new System.Drawing.Point(79, 245);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(66, 20);
            this.lblEditLastName.TabIndex = 4;
            this.lblEditLastName.Text = "Prezime";
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.Location = new System.Drawing.Point(79, 323);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(64, 20);
            this.lblEditPassword.TabIndex = 5;
            this.lblEditPassword.Text = "Lozinka";
            // 
            // inptEditName
            // 
            this.inptEditName.Location = new System.Drawing.Point(263, 162);
            this.inptEditName.Name = "inptEditName";
            this.inptEditName.Size = new System.Drawing.Size(260, 26);
            this.inptEditName.TabIndex = 6;
            this.inptEditName.TextChanged += new System.EventHandler(this.inptEditName_TextChanged);
            // 
            // inptEditLastName
            // 
            this.inptEditLastName.Location = new System.Drawing.Point(263, 242);
            this.inptEditLastName.Name = "inptEditLastName";
            this.inptEditLastName.Size = new System.Drawing.Size(260, 26);
            this.inptEditLastName.TabIndex = 7;
            // 
            // inptEditPassword
            // 
            this.inptEditPassword.Location = new System.Drawing.Point(263, 317);
            this.inptEditPassword.Name = "inptEditPassword";
            this.inptEditPassword.Size = new System.Drawing.Size(260, 26);
            this.inptEditPassword.TabIndex = 8;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(200, 381);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(135, 45);
            this.btnEditCancel.TabIndex = 9;
            this.btnEditCancel.Text = "ZATVORI";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(447, 381);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(132, 45);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "SPREMI";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.inptEditPassword);
            this.Controls.Add(this.inptEditLastName);
            this.Controls.Add(this.inptEditName);
            this.Controls.Add(this.lblEditPassword);
            this.Controls.Add(this.lblEditLastName);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.lblEditUserId);
            this.Controls.Add(this.lblEditUserName);
            this.Controls.Add(this.lblEditTitle);
            this.Name = "FormEditUser";
            this.Text = "FormEditUser";
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblEditPassword;
        public System.Windows.Forms.TextBox inptEditName;
        public System.Windows.Forms.TextBox inptEditLastName;
        public System.Windows.Forms.TextBox inptEditPassword;
        public System.Windows.Forms.Button btnEditCancel;
        public System.Windows.Forms.Button btnEditUser;
        public System.Windows.Forms.Label lblEditUserName;
        public System.Windows.Forms.Label lblEditUserId;
    }
}