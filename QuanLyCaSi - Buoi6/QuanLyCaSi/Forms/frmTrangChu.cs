using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaSi.Forms
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCaSi f = new frmCaSi();
            f.ShowDialog();
        }

        private void btnAbum_Click(object sender, EventArgs e)
        {
            frmAlbum f = new frmAlbum();
            f.ShowDialog();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            frmSingle f = new frmSingle();
            f.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmShow f = new frmShow();
            f.ShowDialog();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            frmDuyetStaff f = new frmDuyetStaff();
            f.ShowDialog();
        }
    }
}
