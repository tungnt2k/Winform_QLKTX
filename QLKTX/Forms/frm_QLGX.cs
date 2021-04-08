using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public partial class frm_QLGX : Form
    {
        public frm_QLGX()
        {
            InitializeComponent();
        }

        private int? currentTicketId;

        private void frm_QLGX_Load(object sender, EventArgs e)
        {
            LoadTicket();
        }

        private void LoadTicket(string keyword = "", int status = 0)
        {
            using (var dbContext = new AppContext())
            {
                var query = from t in dbContext.ParkingMonthlyTickets
                            from u in dbContext.Users.Where(u => u.Id == t.UserId)
                            select new
                            {
                                ticketId = t.Id,
                                userId = u.Id,
                                userName = u.Name,
                                userCode = u.StudentCode,
                                ticketStatus = t.Status,
                                tDateStart = t.DateStart,
                                tDateEnd = t.DateEnd,
                                ticketNode = t.Note,
                            };


                if (keyword != "")
                {
                    query.Where(i => i.userCode.Contains(keyword) );
                }

                if (status != 0)
                {
                    query.Where(i => i.ticketStatus.Equals(status));
                }

                var res = query.ToList();
                dgvTicket.DataSource = res;
                dgvTicket.Columns["userId"].Visible = false;
                dgvTicket.Columns[0].HeaderText = "ID vé";
                dgvTicket.Columns[2].HeaderText = "Tên sinh viên";
                dgvTicket.Columns[3].HeaderText = "Mã sinh viên";
                dgvTicket.Columns[4].HeaderText = "Trạng thái";
                dgvTicket.Columns[5].HeaderText = "Từ ngày";
                dgvTicket.Columns[6].HeaderText = "Đến ngày";
                dgvTicket.Columns[7].HeaderText = "Ghi chú";
            }

        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            LoadTicket(tbStudentCode.Text, cbActiveTicket.Checked ? 1 : 0);
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            User user;

            using (var dbContext = new AppContext())
            {
                user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode1.Text);

                if (user != null)
                {
                    ParkingMonthlyTicket ticket = new ParkingMonthlyTicket();
                    ticket.UserId = user.Id;
                    ticket.Note = tbNoteTicket.Text;
                    ticket.DateStart = dtpFromDate.Value;
                    ticket.DateEnd = dtpToDate.Value;

                    dbContext.ParkingMonthlyTickets.Add(ticket);
                    dbContext.SaveChanges();

                    LoadTicket();
                    tbStudentCode.Text = "";
                    tbStudentCode1.Text = "";
                    dtpFromDate.Value = DateTime.Now;
                    dtpToDate.Value = DateTime.Now;

                }
                else
                {
                    MessageBox.Show("Mã sinh viên không hợp lệ", "Cảnh báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
            }
            
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                User user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode.Text);
                ParkingMonthlyTicket ticket = dbContext.ParkingMonthlyTickets.Find(currentTicketId);
                if (currentTicketId != null && user != null)
                {
                    ticket.UserId = user.Id;
                    ticket.Note = tbNoteTicket.Text;
                    ticket.DateStart = dtpFromDate.Value;
                    ticket.DateEnd = dtpToDate.Value;

                    dbContext.ParkingMonthlyTickets.AddOrUpdate(ticket);
                    dbContext.SaveChanges();
                }
            }
            LoadTicket();
            tbStudentCode.Text = "";
            tbStudentCode1.Text = "";
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ticketId;
            if (int.TryParse(dgvTicket.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out ticketId))
            {
                tbStudentCode1.Text = dgvTicket.Rows[e.RowIndex].Cells["userCode"].Value.ToString();
                tbNoteTicket.Text = dgvTicket.Rows[e.RowIndex].Cells["ticketNote"].Value.ToString();
                dtpFromDate.Value = DateTime.Parse(dgvTicket.Rows[e.RowIndex].Cells["tDateStart"].Value.ToString() ?? throw new InvalidOperationException());
                dtpFromDate.Value = DateTime.Parse(dgvTicket.Rows[e.RowIndex].Cells["tDateEnd"].Value.ToString() ?? throw new InvalidOperationException());
            }
            currentTicketId = ticketId;
        }

        private void btnDelTicket_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                ParkingMonthlyTicket ticket = dbContext.ParkingMonthlyTickets.Find(currentTicketId);
                if (ticket != null)
                {
                    dbContext.ParkingMonthlyTickets.Remove(ticket);
                    dbContext.SaveChanges();
                }
            }
            LoadTicket();
            tbStudentCode.Text = "";
            tbStudentCode1.Text = "";
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            using (var dbContext = new AppContext())
            {
                ParkingTurn pt = new ParkingTurn();
                pt.Note = rtbNote.Text;
                pt.Time = DateTime.Now;
                pt.StudentCode = tbStudentCode4.Text;
                
                User user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode4.Text);
                if (user != null)
                {
                    if (cbMonthlyTicket.Checked)
                    {
                        ParkingMonthlyTicket ticket = dbContext.ParkingMonthlyTickets.FirstOrDefault(t =>
                            t.DateStart < DateTime.Now && t.DateEnd > DateTime.Now && t.UserId == user.Id);
                        if (ticket != null)
                        {
                            pt.TicketId = ticket.Id;
                            int num = dbContext.ParkingTurns.Count(p =>
                                p.StudentCode == pt.StudentCode && EntityFunctions.TruncateTime(p.Time) == now.Date && p.Type == 1);
                            pt.NumOfTurn = num + 1;
                        }
                        else
                        {
                            MessageBox.Show("Vé không được tìm thấy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                    }
                    else
                    {
                        pt.NumOfTurn = 0;
                    }

                    pt.Type = 1;
                    dbContext.ParkingTurns.Add(pt);
                    dbContext.SaveChanges();

                    if (pt.NumOfTurn > 2 || pt.TicketId == null)
                    {
                        MessageBox.Show("Giá vé là 3000 đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Giá vé là 0 đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                else
                {
                    MessageBox.Show("Mã sinh viên không được tìm thấy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            using (var dbContext = new AppContext())
            {
                ParkingTurn pt = new ParkingTurn();
                pt.Note = rtbNote.Text;
                pt.Time = DateTime.Now;
                pt.StudentCode = tbStudentCode4.Text;

                User user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode4.Text);
                if (user != null)
                {
                    if (cbMonthlyTicket.Checked)
                    {
                        ParkingMonthlyTicket ticket = dbContext.ParkingMonthlyTickets.FirstOrDefault(t =>
                            t.DateStart < DateTime.Now && t.DateEnd > DateTime.Now && t.UserId == user.Id);
                        if (ticket != null)
                        {
                            pt.TicketId = ticket.Id;
                            int num = dbContext.ParkingTurns.Count(p =>
                                p.StudentCode == pt.StudentCode && EntityFunctions.TruncateTime(p.Time) == now.Date && p.Type == 2);
                            pt.NumOfTurn = num + 1;
                        }
                        else
                        {
                            MessageBox.Show("Vé không được tìm thấy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                    }
                    else
                    {
                        pt.NumOfTurn = 0;
                    }

                    pt.Type = 2;
                    dbContext.ParkingTurns.Add(pt);
                    dbContext.SaveChanges();

                    if (pt.NumOfTurn > 2 || pt.TicketId == null)
                    {
                        MessageBox.Show("Giá vé là 3000 đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Giá vé là 0 đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                else
                {
                    MessageBox.Show("Mã sinh viên không được tìm thấy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

            }
        }
    }
}
