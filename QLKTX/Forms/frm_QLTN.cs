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
    public partial class frm_QLTN : Form
    {
        public frm_QLTN()
        {
            InitializeComponent();
        }

        private List<Building> buildings;

        private int? currentBuildingId;

        private void frm_QLTN_Load(object sender, EventArgs e)
        {
            LoadBuilding();
        }

        private void LoadBuilding()
        {
            using (var dbContext = new AppContext())
            {
                buildings = dbContext.Buildings.ToList();
            }

            dgvBuilding.DataSource = buildings;
            dgvBuilding.Columns["Rooms"].Visible = false;
            dgvBuilding.Columns[0].HeaderText = "Mã tòa nhà";
            dgvBuilding.Columns[1].HeaderText = "Tên tòa nhà";
            dgvBuilding.Columns[2].HeaderText = "Ngày tạo";
            dgvBuilding.Columns[3].HeaderText = "Ngày cập nhật";

        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            Building building = new Building();
            building.Name = tbBuildingName.Text;

            using (var dbContext = new AppContext())
            {
                dbContext.Buildings.Add(building);
                dbContext.SaveChanges();
            }
            LoadBuilding();
            tbBuildingName.Text = "";
        }

        private void btnUpdateBuilding_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                Building building = dbContext.Buildings.Find(currentBuildingId);
                if (building != null)
                {
                    building.Name = tbBuildingName.Text;
                    building.UpdatedAt = DateTime.Now;
                    dbContext.Buildings.AddOrUpdate(building);
                    dbContext.SaveChanges();
                }
            }
            LoadBuilding();
            tbBuildingName.Text = "";
            currentBuildingId = null;
        }

        private void btnDelBuilding_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppContext())
            {
                Building fc = dbContext.Buildings.Find(currentBuildingId);
                if (fc != null)
                {
                    dbContext.Buildings.Remove(fc);
                    dbContext.SaveChanges();
                }
            }
            LoadBuilding();
            tbBuildingName.Text = "";
            currentBuildingId = null;
        }

        private void dgvBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int buildingId;
            if (int.TryParse(dgvBuilding.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out buildingId))
            {
                tbBuildingName.Text = dgvBuilding.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
            currentBuildingId = buildingId;
        }
    }
}

