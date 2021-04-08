using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Cảnh báo", "Bạn chưa nhập tài khoản mật khẩu", MessageBoxButtons.OK);
                return;
            }
            Admin admin;
            using (var DbContext = new AppContext())
            {
                admin = DbContext.Admins.FirstOrDefault(u => u.Username == tbUsername.Text);
            }

            if (admin != null && admin.Password == tbPassword.Text)
            {
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
