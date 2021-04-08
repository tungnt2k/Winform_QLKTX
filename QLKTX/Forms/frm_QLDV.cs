using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public partial class frm_QLDV : Form
    {
        public frm_QLDV()
        {
            InitializeComponent();
        }

        private List<Service> services;
        private int? currentServiceId;

        private void frm_QLDV_Load(object sender, EventArgs e)
        {
            LoadService();
        }

        private void LoadService()
        {
            using (var dbContext = new AppContext())
            {
                services = dbContext.Services.ToList();
            }

            dgvService.DataSource = services;
            dgvService.Columns["UserUseServices"].Visible = false;
            dgvService.Columns[0].HeaderText = "ID dịch vụ";
            dgvService.Columns[1].HeaderText = "Tên dịch vụ";
            dgvService.Columns[2].HeaderText = "Mô tả";
            dgvService.Columns[3].HeaderText = "Giá";
            dgvService.Columns[4].HeaderText = "Ngày tạo";
            dgvService.Columns[5].HeaderText = "Ngày cập nhật";

            cbbService.DisplayMember = "Text";
            cbbService.ValueMember = "Value";
            cbbService.Items.Clear();
            if (services != null)
            {
                cbbService.Items.Add(new { Text = "Chọn dịch vụ", Value = 0 });
                cbbService.SelectedIndex = cbbService.FindString("Chọn dịch vụ");
                services.ForEach(e =>
                {
                    cbbService.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Name = tbNameService.Text;
            service.Description = tbDescService.Text;
            service.Price = float.Parse(tbPriceService.Text);

            using (var dbContext = new AppContext())
            {
                dbContext.Services.Add(service);
                dbContext.SaveChanges();
            }
            LoadService();
            tbNameService.Text = "";
            tbDescService.Text = "";
            tbPriceService.Text = "";
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                Service service = dbContext.Services.Find(currentServiceId);
                if (service != null)
                {
                    service.Name = tbNameService.Text;
                    service.Description = tbDescService.Text;
                    service.Price = float.Parse(tbPriceService.Text);
                    service.UpdatedAt = DateTime.Now;
                    dbContext.Services.AddOrUpdate(service);
                    dbContext.SaveChanges();
                }
            }
            LoadService();
            tbNameService.Text = "";
            tbDescService.Text = "";
            tbPriceService.Text = "";
            currentServiceId = null;
        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                Service service = dbContext.Services.Find(currentServiceId);
                if (service != null)
                {
                    dbContext.Services.Remove(service);
                    dbContext.SaveChanges();
                }
            }
            LoadService();
            tbNameService.Text = "";
            tbDescService.Text = "";
            tbPriceService.Text = "";
            currentServiceId = null;
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int serviceId;
            if (int.TryParse(dgvService.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out serviceId))
            {
                tbNameService.Text = dgvService.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbDescService.Text = dgvService.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                tbPriceService.Text = dgvService.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
            currentServiceId = serviceId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            User user;
            using (var dbContext = new AppContext())
            {
                user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode.Text);
            }

            if (user != null)
            {
                UserUseService uus = new UserUseService();
                uus.ServiceId = (cbbService.SelectedItem as dynamic).Value;
                uus.UserId = user.Id;
                uus.Note = rtbNote.Text;
                uus.DateStart = dtpFromDate.Value;
                uus.DateEnd = dtpToDate.Value;

                using (var dbContext = new AppContext())
                {
                    dbContext.UserUseServices.Add(uus);
                    dbContext.SaveChanges();
                }

                cbbService.SelectedIndex = cbbService.FindString("Chọn dịch vụ");
                tbStudentCode.Text = "";
                rtbNote.Text = "";
                dtpFromDate.Value = DateTime.Now;
                dtpToDate.Value = DateTime.Now;

                MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Mã sinh viên không được tìm thấy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }
    }
}
