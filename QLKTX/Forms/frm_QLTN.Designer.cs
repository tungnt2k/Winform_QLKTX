
namespace QLKTX.Forms
{
    partial class frm_QLTN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelBuilding = new System.Windows.Forms.Button();
            this.btnUpdateBuilding = new System.Windows.Forms.Button();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.tbBuildingName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvBuilding);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 450);
            this.panel4.TabIndex = 2;
            // 
            // dgvBuilding
            // 
            this.dgvBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuilding.Location = new System.Drawing.Point(0, 0);
            this.dgvBuilding.Name = "dgvBuilding";
            this.dgvBuilding.RowHeadersWidth = 51;
            this.dgvBuilding.RowTemplate.Height = 29;
            this.dgvBuilding.Size = new System.Drawing.Size(550, 450);
            this.dgvBuilding.TabIndex = 0;
            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelBuilding);
            this.panel3.Controls.Add(this.btnUpdateBuilding);
            this.panel3.Controls.Add(this.btnAddBuilding);
            this.panel3.Controls.Add(this.tbBuildingName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 450);
            this.panel3.TabIndex = 1;
            // 
            // btnDelBuilding
            // 
            this.btnDelBuilding.Location = new System.Drawing.Point(53, 306);
            this.btnDelBuilding.Name = "btnDelBuilding";
            this.btnDelBuilding.Size = new System.Drawing.Size(146, 43);
            this.btnDelBuilding.TabIndex = 4;
            this.btnDelBuilding.Text = "Xóa";
            this.btnDelBuilding.UseVisualStyleBackColor = true;
            this.btnDelBuilding.Click += new System.EventHandler(this.btnDelBuilding_Click);
            // 
            // btnUpdateBuilding
            // 
            this.btnUpdateBuilding.Location = new System.Drawing.Point(53, 247);
            this.btnUpdateBuilding.Name = "btnUpdateBuilding";
            this.btnUpdateBuilding.Size = new System.Drawing.Size(146, 43);
            this.btnUpdateBuilding.TabIndex = 3;
            this.btnUpdateBuilding.Text = "Sửa";
            this.btnUpdateBuilding.UseVisualStyleBackColor = true;
            this.btnUpdateBuilding.Click += new System.EventHandler(this.btnUpdateBuilding_Click);
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Location = new System.Drawing.Point(53, 190);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(146, 43);
            this.btnAddBuilding.TabIndex = 2;
            this.btnAddBuilding.Text = "Thêm";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // tbBuildingName
            // 
            this.tbBuildingName.Location = new System.Drawing.Point(6, 110);
            this.tbBuildingName.Name = "tbBuildingName";
            this.tbBuildingName.Size = new System.Drawing.Size(232, 27);
            this.tbBuildingName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tòa nhà";
            // 
            // frm_QLTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QLTN";
            this.Text = "frm_QLTN";
            this.Load += new System.EventHandler(this.frm_QLTN_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvBuilding;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelBuilding;
        private System.Windows.Forms.Button btnUpdateBuilding;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.TextBox tbBuildingName;
    }
}