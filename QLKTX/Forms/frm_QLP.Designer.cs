
namespace QLKTX.Forms
{
    partial class frm_QLP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStudentInRoom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBuilding = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.tbNameRoom = new System.Windows.Forms.TextBox();
            this.cbbRoomCate = new System.Windows.Forms.ComboBox();
            this.cbbBuildingPickRoom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvRoomCate = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPriceRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameRoomCate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelRoomCate = new System.Windows.Forms.Button();
            this.btnUpdateRoomCate = new System.Windows.Forms.Button();
            this.btnAddRoomCate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomCate)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý sinh viên trong phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(497, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 410);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStudentInRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 410);
            this.panel2.TabIndex = 1;
            // 
            // dgvStudentInRoom
            // 
            this.dgvStudentInRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentInRoom.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentInRoom.Name = "dgvStudentInRoom";
            this.dgvStudentInRoom.RowHeadersWidth = 51;
            this.dgvStudentInRoom.RowTemplate.Height = 29;
            this.dgvStudentInRoom.Size = new System.Drawing.Size(744, 410);
            this.dgvStudentInRoom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.cbbRoom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbBuilding);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(536, 11);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(140, 40);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Hiển thị";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cbbRoom
            // 
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(264, 23);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(169, 28);
            this.cbbRoom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tòa nhà";
            // 
            // cbbBuilding
            // 
            this.cbbBuilding.FormattingEnabled = true;
            this.cbbBuilding.Location = new System.Drawing.Point(24, 23);
            this.cbbBuilding.Name = "cbbBuilding";
            this.cbbBuilding.Size = new System.Drawing.Size(171, 28);
            this.cbbBuilding.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvRoom);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 467);
            this.panel5.TabIndex = 1;
            // 
            // dgvRoom
            // 
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.Location = new System.Drawing.Point(0, 0);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 29;
            this.dgvRoom.Size = new System.Drawing.Size(494, 467);
            this.dgvRoom.TabIndex = 0;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelRoom);
            this.panel4.Controls.Add(this.btnUpdateRoom);
            this.panel4.Controls.Add(this.btnAddRoom);
            this.panel4.Controls.Add(this.tbNameRoom);
            this.panel4.Controls.Add(this.cbbRoomCate);
            this.panel4.Controls.Add(this.cbbBuildingPickRoom);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(497, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 467);
            this.panel4.TabIndex = 0;
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.Location = new System.Drawing.Point(42, 397);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(167, 42);
            this.btnDelRoom.TabIndex = 8;
            this.btnDelRoom.Text = "Xóa";
            this.btnDelRoom.UseVisualStyleBackColor = true;
            this.btnDelRoom.Click += new System.EventHandler(this.btnDelRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(42, 350);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(167, 42);
            this.btnUpdateRoom.TabIndex = 7;
            this.btnUpdateRoom.Text = "Sửa";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(42, 300);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(167, 42);
            this.btnAddRoom.TabIndex = 6;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // tbNameRoom
            // 
            this.tbNameRoom.Location = new System.Drawing.Point(6, 241);
            this.tbNameRoom.Name = "tbNameRoom";
            this.tbNameRoom.Size = new System.Drawing.Size(238, 27);
            this.tbNameRoom.TabIndex = 5;
            // 
            // cbbRoomCate
            // 
            this.cbbRoomCate.FormattingEnabled = true;
            this.cbbRoomCate.Location = new System.Drawing.Point(6, 147);
            this.cbbRoomCate.Name = "cbbRoomCate";
            this.cbbRoomCate.Size = new System.Drawing.Size(238, 28);
            this.cbbRoomCate.TabIndex = 4;
            // 
            // cbbBuildingPickRoom
            // 
            this.cbbBuildingPickRoom.FormattingEnabled = true;
            this.cbbBuildingPickRoom.Location = new System.Drawing.Point(7, 57);
            this.cbbBuildingPickRoom.Name = "cbbBuildingPickRoom";
            this.cbbBuildingPickRoom.Size = new System.Drawing.Size(238, 28);
            this.cbbBuildingPickRoom.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tòa nhà";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(750, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý loại phòng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvRoomCate);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(500, 473);
            this.panel7.TabIndex = 1;
            // 
            // dgvRoomCate
            // 
            this.dgvRoomCate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomCate.Location = new System.Drawing.Point(0, 0);
            this.dgvRoomCate.Name = "dgvRoomCate";
            this.dgvRoomCate.RowHeadersWidth = 51;
            this.dgvRoomCate.RowTemplate.Height = 29;
            this.dgvRoomCate.Size = new System.Drawing.Size(500, 473);
            this.dgvRoomCate.TabIndex = 0;
            this.dgvRoomCate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomCate_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbPriceRoom);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.tbNameRoomCate);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnDelRoomCate);
            this.panel6.Controls.Add(this.btnUpdateRoomCate);
            this.panel6.Controls.Add(this.btnAddRoomCate);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(500, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 473);
            this.panel6.TabIndex = 0;
            // 
            // tbPriceRoom
            // 
            this.tbPriceRoom.Location = new System.Drawing.Point(6, 184);
            this.tbPriceRoom.Name = "tbPriceRoom";
            this.tbPriceRoom.Size = new System.Drawing.Size(236, 27);
            this.tbPriceRoom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá phòng / tháng";
            // 
            // tbNameRoomCate
            // 
            this.tbNameRoomCate.Location = new System.Drawing.Point(6, 86);
            this.tbNameRoomCate.Name = "tbNameRoomCate";
            this.tbNameRoomCate.Size = new System.Drawing.Size(236, 27);
            this.tbNameRoomCate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên loại phòng";
            // 
            // btnDelRoomCate
            // 
            this.btnDelRoomCate.Location = new System.Drawing.Point(6, 358);
            this.btnDelRoomCate.Name = "btnDelRoomCate";
            this.btnDelRoomCate.Size = new System.Drawing.Size(236, 41);
            this.btnDelRoomCate.TabIndex = 2;
            this.btnDelRoomCate.Text = "Xóa";
            this.btnDelRoomCate.UseVisualStyleBackColor = true;
            this.btnDelRoomCate.Click += new System.EventHandler(this.btnDelRoomCate_Click);
            // 
            // btnUpdateRoomCate
            // 
            this.btnUpdateRoomCate.Location = new System.Drawing.Point(6, 300);
            this.btnUpdateRoomCate.Name = "btnUpdateRoomCate";
            this.btnUpdateRoomCate.Size = new System.Drawing.Size(236, 41);
            this.btnUpdateRoomCate.TabIndex = 1;
            this.btnUpdateRoomCate.Text = "Sửa";
            this.btnUpdateRoomCate.UseVisualStyleBackColor = true;
            this.btnUpdateRoomCate.Click += new System.EventHandler(this.btnUpdateRoomCate_Click);
            // 
            // btnAddRoomCate
            // 
            this.btnAddRoomCate.Location = new System.Drawing.Point(6, 241);
            this.btnAddRoomCate.Name = "btnAddRoomCate";
            this.btnAddRoomCate.Size = new System.Drawing.Size(236, 41);
            this.btnAddRoomCate.TabIndex = 0;
            this.btnAddRoomCate.Text = "Thêm";
            this.btnAddRoomCate.UseVisualStyleBackColor = true;
            this.btnAddRoomCate.Click += new System.EventHandler(this.btnAddRoomCate_Click);
            // 
            // frm_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_QLP";
            this.Text = "frm_QLP";
            this.Load += new System.EventHandler(this.frm_QLP_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomCate)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStudentInRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBuilding;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Button btnDelRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox tbNameRoom;
        private System.Windows.Forms.ComboBox cbbRoomCate;
        private System.Windows.Forms.ComboBox cbbBuildingPickRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvRoomCate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPriceRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameRoomCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelRoomCate;
        private System.Windows.Forms.Button btnUpdateRoomCate;
        private System.Windows.Forms.Button btnAddRoomCate;
    }
}