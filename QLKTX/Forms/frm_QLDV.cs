using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public class SumaryService
    {
        public string Name { get; set; }
        public double sumPrice { get; set; }

        public int countTurn { get; set; }
    }
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
            Service service;
            int serviceId = (cbbService.SelectedItem as dynamic).Value;
            using (var dbContext = new AppContext())
            {
                user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode.Text);
                service = dbContext.Services.FirstOrDefault(s => s.Id == serviceId);
            }

            if (user != null)
            {
                UserUseService uus = new UserUseService();
                uus.ServiceId = serviceId;
                uus.Price = service.Price;
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            
            using (var dbContext = new AppContext())
            {

                User user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode3.Text);
                if (user != null)
                {
                    var res = dbContext.Database.SqlQuery<SumaryService>(
                        "SELECT s3.Name, s.sumPrice, s1.countTurn FROM Services s3 JOIN ( SELECT uus.ServiceId as serviceId , sum(uus.Price) as sumPrice FROM UserUseServices uus Where uus.UserId = @userId and uus.DateStart >= @startDate and uus.DateEnd <= @endDate GROUP BY uus.ServiceId ) s ON (s3.id = s.serviceId) JOIN ( SELECT uus1.ServiceId as serviceId , COUNT(*) as countTurn FROM UserUseServices uus1 GROUP BY uus1.ServiceId ) s1 ON (s3.id = s1.serviceId)",
                        new SqlParameter("@userId", user.Id), new SqlParameter("@startDate", SqlDbType.DateTime) { Value = startDate},
                        new SqlParameter("@endDate", SqlDbType.DateTime) { Value = endDate}).ToList();
                    dgvSumarySvc.DataSource = res;

                    dgvSumarySvc.DataSource = services;
                    dgvSumarySvc.Columns[0].HeaderText = "Tên dịch vụ";
                    dgvSumarySvc.Columns[1].HeaderText = "Tổng số tiền";
                    dgvSumarySvc.Columns[2].HeaderText = "Số lần sử dụng";
                }
                else
                {
                    MessageBox.Show("Mã sinh viên không được tìm thấy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

            }
        }
    }
}
