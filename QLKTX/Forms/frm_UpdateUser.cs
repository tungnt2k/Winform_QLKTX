using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public partial class frm_UpdateUser : Form
    {
        private int? userId;
        public frm_UpdateUser(int? userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void frm_UpdateUser_Load(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                User user = dbContext.Users.Find(this.userId);
                if (user != null)
                {
                    tbUserName.Text = user.Name;
                    tbUserEmail.Text = user.Email;
                    tbPhone.Text = user.Phone;
                    tbStudentCode.Text = user.StudentCode;
                    tbSchoolYear.Text = user.SchoolYear;
                    dtpBirthDay.Value = user.BirthDay;
                    tbAddress.Text = user.Address;
                }
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                User user = dbContext.Users.Find(this.userId);
                if (user != null)
                {
                    user.Name = tbUserName.Text;
                    user.Email = tbUserEmail.Text;
                    user.Phone = tbPhone.Text;
                    user.StudentCode = tbStudentCode.Text;
                    user.SchoolYear = tbSchoolYear.Text;
                    user.BirthDay = dtpBirthDay.Value;
                    user.Address = tbAddress.Text;

                    dbContext.Users.AddOrUpdate(user);
                    dbContext.SaveChanges();
                }
            }

            this.Hide();
        }
    }
}
