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
        }

        private void LoadRoomCate()
        {
            using (var dbContext = new AppContext())
            {
                roomCategories = dbContext.RoomCategories.ToList();
            }

            dgvRoomCate.DataSource = roomCategories;
            dgvRoomCate.Columns["Rooms"].Visible = false;
            dgvRoomCate.Columns[0].HeaderText = "ID";
            dgvRoomCate.Columns[1].HeaderText = "Tên loại phòng";
            dgvRoomCate.Columns[2].HeaderText = "Giá tiền / tháng";
            dgvRoomCate.Columns[3].HeaderText = "Ngày tạo";
            dgvRoomCate.Columns[4].HeaderText = "Ngày cập nhật";
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

        private void LoadRoomUser(int roomId)
        {
            using (var dbContext = new AppContext())
            {
                userRooms = dbContext.UserRooms.Include(ur=> ur.User).Where(r=>r.RoomId == roomId).ToList();
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
            LoadRoomUser((cbbRoom.SelectedItem as dynamic).Value);
        }
    }
}
