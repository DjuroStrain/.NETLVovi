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
    public partial class ForumUsers : Form
    {
        public ForumUsers()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = _userRepository.GetUsers();
        }

        private UserRepository _userRepository = new UserRepository();
        private BindingSource _tableBindingSource = new BindingSource();

        private void ForumUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = _tableBindingSource;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();

            oEditButton.Image = Image.FromFile("C:/Users/38599/Desktop/update.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oEditButton);


            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();

            oDeleteButton.Image = Image.FromFile(@"C:\Users\38599\Desktop\delete(1).png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oDeleteButton);

            dataGridViewUsers.AutoGenerateColumns = false;

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewUsers.Rows[e.RowIndex].Selected = true;
            if (dataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormEditUser FormEditUser = new FormEditUser(this);

                FormEditUser.lblEditUserId.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditUser.lblEditUserName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditLastName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.inptEditPassword.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.Show();

            }

            else if (dataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                FormDeleteUser FormDeleteUser = new FormDeleteUser(this);
                FormDeleteUser.lblId.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.lblId.Hide();
                FormDeleteUser.Show();

            }
        }

        private void izbornikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUser FormAddUser = new FormAddUser(this);
            FormAddUser.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void RefreshGrid()
        {
            _tableBindingSource.DataSource = _userRepository.GetUsers();
        }

        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Đuro Belačić \n Version: 1.0 \n Author: Đuro Belačić \n Year: 2020");
        }
    }
}
