namespace PresentationLayer
{
    partial class ForumUsers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFirstName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contxtIzbornik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.contxtIzbornik.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId1,
            this.UserName1,
            this.UserPassword1,
            this.UserFirstName1,
            this.UserLastName1});
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1314, 327);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // UserId1
            // 
            this.UserId1.DataPropertyName = "UserID";
            this.UserId1.HeaderText = "ID";
            this.UserId1.MinimumWidth = 8;
            this.UserId1.Name = "UserId1";
            this.UserId1.Width = 150;
            // 
            // UserName1
            // 
            this.UserName1.DataPropertyName = "UserName";
            this.UserName1.HeaderText = "Username";
            this.UserName1.MinimumWidth = 8;
            this.UserName1.Name = "UserName1";
            this.UserName1.Width = 150;
            // 
            // UserPassword1
            // 
            this.UserPassword1.DataPropertyName = "UserPassword";
            this.UserPassword1.HeaderText = "Password";
            this.UserPassword1.MinimumWidth = 8;
            this.UserPassword1.Name = "UserPassword1";
            this.UserPassword1.Width = 150;
            // 
            // UserFirstName1
            // 
            this.UserFirstName1.DataPropertyName = "UserFirstName";
            this.UserFirstName1.HeaderText = "First Name";
            this.UserFirstName1.MinimumWidth = 8;
            this.UserFirstName1.Name = "UserFirstName1";
            this.UserFirstName1.Width = 150;
            // 
            // UserLastName1
            // 
            this.UserLastName1.DataPropertyName = "UserLastName";
            this.UserLastName1.HeaderText = "Last Name";
            this.UserLastName1.MinimumWidth = 8;
            this.UserLastName1.Name = "UserLastName1";
            this.UserLastName1.Width = 150;
            // 
            // contxtIzbornik
            // 
            this.contxtIzbornik.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contxtIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.contxtIzbornik.Name = "contxtIzbornik";
            this.contxtIzbornik.Size = new System.Drawing.Size(164, 52);
            this.contxtIzbornik.Text = "Izbornik";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.izbornikToolStripMenuItem.Text = "Novi korisnik";
            this.izbornikToolStripMenuItem.Click += new System.EventHandler(this.izbornikToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem1,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem1
            // 
            this.izbornikToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem1});
            this.izbornikToolStripMenuItem1.Name = "izbornikToolStripMenuItem1";
            this.izbornikToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.izbornikToolStripMenuItem1.Text = "Izbornik";
            // 
            // izlazToolStripMenuItem1
            // 
            this.izlazToolStripMenuItem1.Name = "izlazToolStripMenuItem1";
            this.izlazToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.izlazToolStripMenuItem1.Text = "Izlaz";
            this.izlazToolStripMenuItem1.Click += new System.EventHandler(this.izlazToolStripMenuItem1_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // ForumUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 355);
            this.ContextMenuStrip = this.contxtIzbornik;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewUsers);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForumUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ForumUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.contxtIzbornik.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName1;
        private System.Windows.Forms.ContextMenuStrip contxtIzbornik;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
    }
}

