using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormEditUser : Form
    {
        private readonly ForumUsers frm1;
        private int v;
        private object userId;

        public FormEditUser(ForumUsers FormEditUser)
        {
            InitializeComponent();
            frm1 = FormEditUser;
        }

        public FormEditUser(int v, object userId)
        {
            this.v = v;
            this.userId = userId;
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {

        }
    

        public void lblEditUserName_Click(object sender, EventArgs e)
        {

        }

        private void inptEditName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserID = Int32.Parse(lblEditUserId.Text);
            user.UserName = lblEditName.Text;
            user.UserLastName = inptEditLastName.Text;
            user.UserPassword = inptEditPassword.Text;
            user.UserFirstName = inptEditName.Text;
            UserRepository novi = new UserRepository();
            novi.UpdateUsers(user);
            frm1.RefreshGrid();
            this.Hide();
            
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
