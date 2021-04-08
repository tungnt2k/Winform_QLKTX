using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKTX.Forms;

namespace QLKTX
{
    public partial class Main : Form
    {

        private Form currentChildForm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            frm_QLSV frmQlsv = new frm_QLSV();
            OpenChildForm(frmQlsv);
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            frm_QLP frmQlp = new frm_QLP();
            OpenChildForm(frmQlp);
        }

        private void btnQLTN_Click(object sender, EventArgs e)
        {
            frm_QLTN frmQltn = new frm_QLTN();
            OpenChildForm(frmQltn);
        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            frm_QLDV frmQldv = new frm_QLDV();
            OpenChildForm(frmQldv);
        }

        private void btnQLGX_Click(object sender, EventArgs e)
        {
            frm_QLGX frmQlgx = new frm_QLGX();
            OpenChildForm(frmQlgx);
        }
    }
}
