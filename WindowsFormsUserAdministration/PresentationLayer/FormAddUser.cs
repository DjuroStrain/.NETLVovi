using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormAddUser : Form
    {
        private readonly ForumUsers frm1;
        public FormAddUser(ForumUsers FormAddUser)
        {
            InitializeComponent();
            frm1 = FormAddUser;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = inptNewName.Text;
            user.UserPassword = inptNewPassword.Text;
            user.UserFirstName = inptNewFirstName.Text;
            user.UserLastName = inptNewLastName.Text;
            UserRepository novi = new UserRepository();
            novi.AddUsers(user);
            frm1.RefreshGrid();
            this.Hide();
        }
    }
}
