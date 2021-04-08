using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public partial class frm_QLSV : Form
    {
        public frm_QLSV()
        {
            InitializeComponent();
        }

        private List<Building> buildings;
        private List<Room> rooms;

        private int? currentStudentId;

        private void frm_QLSV_Load(object sender, EventArgs e)
        {
            LoadBuilding();
            LoadRoom();
            LoadUser();
        }

        private void LoadBuilding()
        {
            using (var dbContext = new AppContext())
            {
                buildings = dbContext.Buildings.ToList();
            }

            cbbBuilding1.DisplayMember = "Text";
            cbbBuilding1.ValueMember = "Value";
            cbbBuilding1.Items.Clear();
            if (buildings != null)
            {
                cbbBuilding1.Items.Add(new { Text = "Chọn toà nhà", Value = 0 });
                cbbBuilding1.SelectedIndex = cbbBuilding1.FindString("Chọn toà nhà");
                buildings.ForEach(e =>
                {
                    cbbBuilding1.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            cbbBuilding.DisplayMember = "Text";
            cbbBuilding.ValueMember = "Value";
            cbbBuilding.Items.Clear();
            if (buildings != null)
            {
                cbbBuilding.Items.Add(new { Text = "Chọn toà nhà", Value = 0 });
                cbbBuilding.SelectedIndex = cbbBuilding.FindString("Chọn toà nhà");
                buildings.ForEach(e =>
                {
                    cbbBuilding.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

        }

        private void LoadRoom(int buildingId = 0)
        {
            using (var dbContext = new AppContext())
            {
                if (buildingId == 0)
                {
                    rooms = dbContext.Rooms.ToList();

                }
                else
                {
                    rooms = dbContext.Rooms.Where(r => r.BuildingId == buildingId).ToList();
                }
            }

            cbbRoom1.DisplayMember = "Text";
            cbbRoom1.ValueMember = "Value";
            cbbRoom1.Items.Clear();
            if (rooms != null)
            {
                cbbRoom1.Items.Add(new { Text = "Chọn phòng", Value = 0 });
                cbbRoom1.SelectedIndex = cbbRoom1.FindString("Chọn phòng");
                rooms.ForEach(e =>
                {
                    cbbRoom1.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            cbbRoom.DisplayMember = "Text";
            cbbRoom.ValueMember = "Value";
            cbbRoom.Items.Clear();
            if (rooms != null)
            {
                cbbRoom.Items.Add(new { Text = "Chọn phòng", Value = 0 });
                cbbRoom.SelectedIndex = cbbRoom.FindString("Chọn phòng");
                rooms.ForEach(e =>
                {
                    cbbRoom.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

        }

        private void LoadUser(int buildingId = 0, int roomId = 0, string keyword = "")
        {
            using (var dbContext = new AppContext())
            {
                var query = from u in dbContext.Users
                    from ur in dbContext.UserRooms.Where(ur => ur.UserId == u.Id).DefaultIfEmpty()
                    from r in dbContext.Rooms.Where(r => r.Id == ur.RoomId).DefaultIfEmpty()
                    from b in dbContext.Buildings.Where(b => b.Id == r.BuildingId).DefaultIfEmpty()
                    where buildingId != 0 ? b.Id == buildingId : b.Id != 0
                    where roomId != 0 ? r.Id == roomId: r.Id != 0
                    where keyword != "" ? u.Name.Contains(keyword) || u.StudentCode.Contains(keyword) : u.Id != 0
                            select new
                    {
                        userId = u.Id,
                        userName = u.Name,
                        userEmail = u.Email,
                        userPhone = u.Phone,
                        userAddress = u.Address,
                        userCode = u.StudentCode,
                        roomId = r != null ? r.Id : 0,
                        roomName = r != null ? r.Name : "",
                        bId = b != null ? b.Id : 0,
                        bName = b != null ? b.Name : "",
                    };


                var res = query.ToList();
                dgvUser2.DataSource = res;
                dgvUser.DataSource = res;

                dgvUser2.Columns[0].HeaderText = "ID sinh viên";
                dgvUser2.Columns[1].HeaderText = "Tên";
                dgvUser2.Columns[2].HeaderText = "Email";
                dgvUser2.Columns[3].HeaderText = "Số điện thoại";
                dgvUser2.Columns[4].HeaderText = "Địa chỉ";
                dgvUser2.Columns[5].HeaderText = "Mã sinh viên";
                dgvUser2.Columns[6].HeaderText = "ID phòng";
                dgvUser2.Columns[7].HeaderText = "Tên phòng";
                dgvUser2.Columns[8].HeaderText = "ID tòa nhà";
                dgvUser2.Columns[9].HeaderText = "Tên tòa nhà";
                dgvUser.Columns[0].HeaderText = "ID sinh viên";
                dgvUser.Columns[1].HeaderText = "Tên";
                dgvUser.Columns[2].HeaderText = "Email";
                dgvUser.Columns[3].HeaderText = "Số điện thoại";
                dgvUser.Columns[4].HeaderText = "Địa chỉ";
                dgvUser.Columns[5].HeaderText = "Mã sinh viên";
                dgvUser.Columns[6].HeaderText = "ID phòng";
                dgvUser.Columns[7].HeaderText = "Tên phòng";
                dgvUser.Columns[8].HeaderText = "ID tòa nhà";
                dgvUser.Columns[9].HeaderText = "Tên tòa nhà";
                dgvUser.ClearSelection();
                dgvUser2.ClearSelection();
            }
        }

        private void cbbBuilding1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom((cbbBuilding1.SelectedItem as dynamic).Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int buildingId = (cbbBuilding1.SelectedItem as dynamic).Value;
            int roomId = (cbbRoom1.SelectedItem as dynamic).Value;
            string keyword = tbKeyword1.Text;
            LoadUser(buildingId, roomId, keyword);
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            frm_AddUser frmAddUser = new frm_AddUser();
            frmAddUser.ShowDialog();
            LoadUser();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int buildingId = (cbbBuilding.SelectedItem as dynamic).Value;
            int roomId = (cbbRoom.SelectedItem as dynamic).Value;
            string keyword = tbKeyword.Text;
            LoadUser(buildingId, roomId, keyword);
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                User u = dbContext.Users.Find(currentStudentId);
                if (u != null)
                {
                    dbContext.Users.Remove(u);
                    dbContext.SaveChanges();
                }
            }
            LoadUser();
            currentStudentId = null;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int studentId;
            if (int.TryParse(dgvUser2.Rows[e.RowIndex].Cells["userId"].Value.ToString(), out studentId))
            {
            }
            currentStudentId = studentId;
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            frm_UpdateUser frm = new frm_UpdateUser(currentStudentId);
            frm.ShowDialog();
            LoadUser();
        }
    }
}
