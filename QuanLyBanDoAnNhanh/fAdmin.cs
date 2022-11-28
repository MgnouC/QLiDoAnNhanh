using QuanLyBanDoAnNhanh.DTO;
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
        public Account loginAccount;

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
            /*fTableManager n = new fTableManager();
             f.InsertFood += n.f_InsertFood;
              f.DeleteFood += f_DeleteFood;
              f.UpdateFood += f_UpdateFood;
            */
            f.ShowDialog();
              this.Show();
          }
          /*  void f_InsertFood(object sender, EventArgs e)
          {
              LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
              ShowBill((lsvBill.Tag as Table).ID);
          }
          void f_DeleteFood(object sender, EventArgs e)
          {
              LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
              ShowBill((lsvBill.Tag as Table).ID);
              LoadTable();
          }
          void f_UpdateFood(object sender, EventArgs e)
          {
              LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
              ShowBill((lsvBill.Tag as Table).ID);
          }
          */
        
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
