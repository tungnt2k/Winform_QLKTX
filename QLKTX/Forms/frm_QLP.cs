using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKTX.Models;

namespace QLKTX.Forms
{
    public partial class frm_QLP : Form
    {
        public frm_QLP()
        {
            InitializeComponent();
        }

        private List<Building> buildings;
        private List<Room> rooms;
        private List<RoomCategory> roomCategories;
        private List<UserRoom> userRooms;

        private int? currentBuildingId;
        private int? currentRoomId;
        private int? currentRoomCateId;
        private int? currentUserRoomId;

        private void frm_QLP_Load(object sender, EventArgs e)
        {
            LoadBuilding();
            LoadRoom();
            LoadRoomCate();
        }

        private void LoadBuilding()
        {
            using (var dbContext = new AppContext())
            {
                buildings = dbContext.Buildings.ToList();
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

            cbbBuildingPickRoom.DisplayMember = "Text";
            cbbBuildingPickRoom.ValueMember = "Value";
            cbbBuildingPickRoom.Items.Clear();
            if (buildings != null)
            {
                cbbBuildingPickRoom.Items.Add(new { Text = "Chọn toà nhà", Value = 0 });
                cbbBuildingPickRoom.SelectedIndex = cbbBuildingPickRoom.FindString("Chọn toà nhà");
                buildings.ForEach(e =>
                {
                    cbbBuildingPickRoom.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            cbbMoveBuilding.DisplayMember = "Text";
            cbbMoveBuilding.ValueMember = "Value";
            cbbMoveBuilding.Items.Clear();
            if (buildings != null)
            {
                cbbMoveBuilding.Items.Add(new { Text = "Chọn toà nhà", Value = 0 });
                cbbMoveBuilding.SelectedIndex = cbbMoveBuilding.FindString("Chọn toà nhà");
                buildings.ForEach(e =>
                {
                    cbbMoveBuilding.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            cbbBd.DisplayMember = "Text";
            cbbBd.ValueMember = "Value";
            cbbBd.Items.Clear();
            if (buildings != null)
            {
                cbbBd.Items.Add(new { Text = "Chọn toà nhà", Value = 0 });
                cbbBd.SelectedIndex = cbbBd.FindString("Chọn toà nhà");
                buildings.ForEach(e =>
                {
                    cbbBd.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            cbbBuilding4.DisplayMember = "Text";
            cbbBuilding4.ValueMember = "Value";
            cbbBuilding4.Items.Clear();
            if (buildings != null)
            {
                cbbBuilding4.Items.Add(new { Text = "Chọn toà nhà", Value = 0 });
                cbbBuilding4.SelectedIndex = cbbBuilding4.FindString("Chọn toà nhà");
                buildings.ForEach(e =>
                {
                    cbbBuilding4.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }
        }

        private void LoadUserRoom(int roomId)
        {
            using (var dbContext = new AppContext())
            {
                var query = from u in dbContext.Users
                    from ur in dbContext.UserRooms.Where(ur => ur.UserId == u.Id)
                    where ur.RoomId == roomId && ur.Status == true
                    select new
                    {
                        userId = u.Id,
                        userName = u.Name,
                        userPhone = u.Phone,
                        userCode = u.StudentCode,
                        fromDate = ur.DateStart,
                        userRoomId = ur.Id
                    };


                var res = query.ToList();
                dgvStudentInRoom.DataSource = res;
                dgvStudentInRoom.Columns["userRoomId"].Visible = false;
                dgvStudentInRoom.Columns[0].HeaderText = "ID sinh viên";
                dgvStudentInRoom.Columns[1].HeaderText = "Tên sinh viên";
                dgvStudentInRoom.Columns[2].HeaderText = "Số điện thoại";
                dgvStudentInRoom.Columns[3].HeaderText = "Mã sinh viên";
                dgvStudentInRoom.Columns[4].HeaderText = "Ngày chuyển đến";

                dgvStudentInRoom.ClearSelection();
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

            cbbMoveRoom.DisplayMember = "Text";
            cbbMoveRoom.ValueMember = "Value";
            cbbMoveRoom.Items.Clear();
            if (rooms != null)
            {
                cbbMoveRoom.Items.Add(new { Text = "Chọn phòng", Value = 0 });
                cbbMoveRoom.SelectedIndex = cbbMoveRoom.FindString("Chọn phòng");
                rooms.ForEach(e =>
                {
                    cbbMoveRoom.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            cbbR.DisplayMember = "Text";
            cbbR.ValueMember = "Value";
            cbbR.Items.Clear();
            if (rooms != null)
            {
                cbbR.Items.Add(new { Text = "Chọn phòng", Value = 0 });
                cbbR.SelectedIndex = cbbR.FindString("Chọn phòng");
                rooms.ForEach(e =>
                {
                    cbbR.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            cbbRoom4.DisplayMember = "Text";
            cbbRoom4.ValueMember = "Value";
            cbbRoom4.Items.Clear();
            if (rooms != null)
            {
                cbbRoom4.Items.Add(new { Text = "Chọn phòng", Value = 0 });
                cbbRoom4.SelectedIndex = cbbRoom4.FindString("Chọn phòng");
                rooms.ForEach(e =>
                {
                    cbbRoom4.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }

            dgvRoom.DataSource = rooms;
            dgvRoom.Columns["UserRooms"].Visible = false;
            dgvRoom.Columns["Visitors"].Visible = false;
            dgvRoom.Columns["BuildingId"].Visible = false;
            dgvRoom.Columns["CateId"].Visible = false;
            dgvRoom.Columns[0].HeaderText = "ID";
            dgvRoom.Columns[1].HeaderText = "ID toà nhà";
            dgvRoom.Columns[2].HeaderText = "ID Loại phòng";
            dgvRoom.Columns[3].HeaderText = "Tên phòng";
            dgvRoom.Columns[4].HeaderText = "Số người tối đa";
            dgvRoom.Columns[5].HeaderText = "Tình trạng";
            dgvRoom.Columns[6].HeaderText = "Ngày tạo";
            dgvRoom.Columns[7].HeaderText = "Ngày cập nhật";
            dgvRoom.ClearSelection();
        }

        private void LoadRoomCate()
        {
            using (var dbContext = new AppContext())
            {
                roomCategories = dbContext.RoomCategories.ToList();
            }

            dgvRoomCate.DataSource = roomCategories;
            
            dgvRoomCate.ClearSelection();


            cbbRoomCate.DisplayMember = "Text";
            cbbRoomCate.ValueMember = "Value";
            cbbRoomCate.Items.Clear();
            if (roomCategories != null)
            {
                cbbRoomCate.Items.Add(new { Text = "Chọn loại phòng", Value = 0 });
                cbbRoomCate.SelectedIndex = cbbRoomCate.FindString("Chọn loại phòng");
                roomCategories.ForEach(e =>
                {
                    cbbRoomCate.Items.Add(new { Text = e.Name, Value = e.Id });
                });
            }
        }

        private void btnAddRoomCate_Click(object sender, EventArgs e)
        {
            RoomCategory roomCategory = new RoomCategory();
            roomCategory.Name = tbNameRoomCate.Text;
            roomCategory.Price = float.Parse(tbPriceRoom.Text);
            
            using (var dbContext = new AppContext())
            {
                dbContext.RoomCategories.Add(roomCategory);
                dbContext.SaveChanges();
            }
            LoadRoomCate();
            tbNameRoomCate.Text = "";
            tbPriceRoom.Text = "";
        }

        private void dgvRoomCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int roomCateId;
            if (int.TryParse(dgvRoomCate.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out roomCateId))
            {
                tbNameRoomCate.Text = dgvRoomCate.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbPriceRoom.Text = dgvRoomCate.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
            currentBuildingId = roomCateId;
        }

        private void btnUpdateRoomCate_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                RoomCategory roomCategory= dbContext.RoomCategories.Find(currentRoomCateId);
                if (roomCategory != null)
                {
                    roomCategory.Name = tbNameRoom.Text;
                    roomCategory.Price = float.Parse(tbPriceRoom.Text);
                    roomCategory.UpdatedAt = DateTime.Now;
                    dbContext.RoomCategories.AddOrUpdate(roomCategory);
                    dbContext.SaveChanges();
                }
            }
            LoadRoomCate();
            tbNameRoomCate.Text = "";
            tbPriceRoom.Text = "";
            currentRoomCateId = null;
        }

        private void btnDelRoomCate_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                RoomCategory roomCategory = dbContext.RoomCategories.Find(currentRoomCateId);
                if (roomCategory != null)
                {
                    dbContext.RoomCategories.Remove(roomCategory);
                    dbContext.SaveChanges();
                }
            }
            LoadRoomCate();
            tbNameRoomCate.Text = "";
            tbPriceRoom.Text = "";
            currentRoomCateId = null;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Name = tbNameRoom.Text;
            room.MaxPeople = int.Parse(numericUpDown1.Value.ToString());
            room.CateId = (cbbRoomCate.SelectedItem as dynamic).Value;
            room.BuildingId = (cbbBuildingPickRoom.SelectedItem as dynamic).Value;

            using (var dbContext = new AppContext())
            {
                dbContext.Rooms.Add(room);
                dbContext.SaveChanges();
            }
            LoadRoom();
            tbNameRoom.Text = "";
            cbbBuildingPickRoom.SelectedItem = "";
            cbbRoomCate.SelectedItem = "";
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                Room room = dbContext.Rooms.Find(currentRoomId);
                if (room != null)
                {
                    room.Name = tbNameRoom.Text;
                    room.BuildingId= (cbbBuildingPickRoom.SelectedItem as dynamic).Value;
                    room.CateId = (cbbRoomCate.SelectedItem as dynamic).Value;
                    room.UpdatedAt = DateTime.Now;
                    dbContext.Rooms.AddOrUpdate(room);
                    dbContext.SaveChanges();
                }
            }
            LoadRoom();
            tbNameRoom.Text = "";
            cbbBuildingPickRoom.SelectedItem = "";
            cbbRoomCate.SelectedItem = "";
            currentRoomId = null;
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                Room room = dbContext.Rooms.Find(currentRoomId);
                if (room != null)
                {
                    dbContext.Rooms.Remove(room);
                    dbContext.SaveChanges();
                }
            }
            LoadRoom();
            tbNameRoom.Text = "";
            cbbBuildingPickRoom.SelectedItem = "";
            cbbRoomCate.SelectedItem = "";
            currentRoomId = null;
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int roomId;
            if (int.TryParse(dgvRoom.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out roomId))
            {
                tbNameRoom.Text = dgvRoom.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                using (var DbContext = new AppContext())
                {
                    int BuildingId;
                    if (int.TryParse(dgvRoom.Rows[e.RowIndex].Cells["BuildingId"].Value.ToString(), out BuildingId))
                    {
                        Building building = DbContext.Buildings.Find(BuildingId);
                        cbbBuildingPickRoom.SelectedIndex = cbbBuildingPickRoom.FindString(building.Name);
                    }

                    int RoomCateId;
                    if (int.TryParse(dgvRoom.Rows[e.RowIndex].Cells["CateId"].Value.ToString(), out RoomCateId))
                    {
                        RoomCategory roomCategory = DbContext.RoomCategories.Find(RoomCateId);
                        cbbRoomCate.SelectedIndex = cbbRoomCate.FindString(roomCategory.Name);
                    }

                }
            }
            currentRoomId = roomId;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadUserRoom((cbbRoom.SelectedItem as dynamic).Value);
        }

        private void btnMoveRoom_Click(object sender, EventArgs e)
        {
            if ((cbbMoveRoom.SelectedItem as dynamic).Value == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng chuyến đến ", "Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            using (var dbContext = new AppContext())
            {
                User user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode.Text);

                Room r = dbContext.Rooms.Find((cbbMoveRoom.SelectedItem as dynamic).Value);
                int numOfUser = dbContext.UserRooms.Count(ur => ur.RoomId == r.Id && ur.Status == true);
                if (user != null  && numOfUser < r.MaxPeople)
                {
                    UserRoom ur = dbContext.UserRooms.FirstOrDefault(i => i.Status == true && i.UserId == user.Id);
                    if (ur != null)
                    {
                        ur.Status = false;
                        ur.DateEnd = DateTime.Now;
                        dbContext.UserRooms.AddOrUpdate(ur);
                        dbContext.SaveChanges();
                    }

                    UserRoom newUR = new UserRoom();
                    newUR.UserId = user.Id;
                    newUR.RoomId = (cbbMoveRoom.SelectedItem as dynamic).Value;
                    newUR.DateStart = DateTime.Now;
                    newUR.Status = true;
                    dbContext.UserRooms.Add(newUR);
                    dbContext.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Mã sinh viên không được tìm thấy hoặc phòng đã đầy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void cbbMoveBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom((cbbMoveBuilding.SelectedItem as dynamic).Value);
        }

        private void dgvStudentInRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int userRoomId;
            if (int.TryParse(dgvStudentInRoom.Rows[e.RowIndex].Cells["userRoomId"].Value.ToString(), out userRoomId))
            {

            }
            currentUserRoomId = userRoomId;

        }

        private void btnDelFromRoom_Click(object sender, EventArgs e)
        {
            if (currentUserRoomId != null)
            {
                using (var dbContext = new AppContext())
                {
                    
                    UserRoom ur = dbContext.UserRooms.FirstOrDefault(i => i.Status == true && i.Id == currentUserRoomId);
                    if (ur != null)
                    {
                        ur.Status = false;
                        ur.DateEnd = DateTime.Now;
                        dbContext.UserRooms.AddOrUpdate(ur); 
                        dbContext.SaveChanges();
                        MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbStudentCode.Text = "";
                    }

                     
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên ở bảng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void cbbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom((cbbBuilding.SelectedItem as dynamic).Value);

        }

        private void cbbBd_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom((cbbBd.SelectedItem as dynamic).Value);
        }

        private void btnSearchVisitor_Click(object sender, EventArgs e)
        {
            LoadVisitor((cbbR.SelectedItem as dynamic).Value);
        }

        private void LoadVisitor(int roomId)
        {
            using (var dbContext = new AppContext())
            {
                var query = from v in dbContext.Visitors
                    from u in dbContext.Users.Where(u => u.Id== v.UserId)
                    where v.RoomId == roomId
                    select new
                    {
                        visitorId = v.Id,
                        visitorName = v.Name,
                        visitorPhone = v.Phone,
                        visitorReason = v.Reason,
                        userName = u.Name,
                        userCode = u.StudentCode,
                        fromDate = v.DateStart,
                        toDate = v.DateEnd
                    };


                var res = query.ToList();
                dgvVisitor.DataSource = res;
                dgvVisitor.Columns[0].HeaderText = "ID khách";
                dgvVisitor.Columns[1].HeaderText = "Tên khách";
                dgvVisitor.Columns[2].HeaderText = "Số điện thoại";
                dgvVisitor.Columns[3].HeaderText = "Lý do";
                dgvVisitor.Columns[4].HeaderText = "Tên sinh viên";
                dgvVisitor.Columns[5].HeaderText = "Mã sinh viên";
                dgvVisitor.Columns[6].HeaderText = "Giờ đến";
                dgvVisitor.Columns[7].HeaderText = "Giờ đi";

                dgvVisitor.ClearSelection();
            }
        }

        private void btnAddVisitor_Click(object sender, EventArgs e)
        {
            User user;
            using (var dbContext = new AppContext())
            {
                user = dbContext.Users.FirstOrDefault(u => u.StudentCode == tbStudentCode2.Text);
            }

            if (user != null)
            {
                Visitor visitor = new Visitor();
                visitor.RoomId = (cbbRoom4.SelectedItem as dynamic).Value;
                visitor.UserId = user.Id;
                visitor.Name = tbVisitorName.Text;
                visitor.Phone = tbPhoneVisitor.Text;
                visitor.Reason = tbVisitorReason.Text;
                visitor.DateStart = dtpFromDate.Value;
                visitor.DateEnd = dtpToDate.Value;

                using (var dbContext = new AppContext())
                {
                    dbContext.Visitors.Add(visitor);
                    dbContext.SaveChanges();
                }
                LoadVisitor(visitor.RoomId);
                tbStudentCode2.Text = "";
                tbPhoneVisitor.Text = "";
                tbVisitorReason.Text = "";
                dtpFromDate.Value = DateTime.Now;
                dtpToDate.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Mã sinh viên không được tìm thấy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }



        }

        private void cbbBuilding4_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom((cbbBuilding4.SelectedItem as dynamic).Value);
        }
    }
}
