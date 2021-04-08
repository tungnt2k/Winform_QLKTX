using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public partial class frm_AddUser : Form
    {
        public frm_AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = tbUserName.Text;
            user.Email = tbUserEmail.Text;
            user.Phone = tbPhone.Text;
            user.StudentCode = tbStudentCode.Text;
            user.SchoolYear = tbSchoolYear.Text;
            user.BirthDay = dtpBirthDay.Value;
            user.Address = tbAddress.Text;

            using (var dbContext = new AppContext())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbStudentCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbSchoolYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
