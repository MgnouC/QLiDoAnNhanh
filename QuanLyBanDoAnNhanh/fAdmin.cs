using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoAnNhanh
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            fDanhMuc f = new fDanhMuc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDoanhThu f = new fDoanhThu();
            f.ShowDialog();
            this.Show();
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fThucAn f = new fThucAn();
            f.ShowDialog();
            this.Show();
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fBanAn f = new fBanAn();
            f.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTaiKhoan f = new fTaiKhoan();
            f.ShowDialog();
            this.Show();
        }
    }
}
