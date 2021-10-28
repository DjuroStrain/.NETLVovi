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
    public partial class FormDeleteUser : Form
    {
        private readonly ForumUsers frm1;
        public FormDeleteUser(ForumUsers FormDeleteUser)
        {
            InitializeComponent();
            frm1 = FormDeleteUser;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserID = Int32.Parse(lblId.Text);
            UserRepository novi = new UserRepository();
            novi.DeleteUsers(user);
            frm1.RefreshGrid();
            this.Hide();
        }
    }
}
