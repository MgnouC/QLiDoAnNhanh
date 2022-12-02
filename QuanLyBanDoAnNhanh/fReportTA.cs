using QuanLyBanDoAnNhanh.DAO;
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
    public partial class fReportTA : Form
    {
        public fReportTA()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void fReportTA_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";

        }
        
  

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            cate = selected.Name;
            
            this.uSP_GetListFoodByCategoryTableAdapter.Fill(this.quanLyBanDoAnNhanhDataSet1.USP_GetListFoodByCategory, cate);
            this.reportViewer1.RefreshReport();
        }
    }
}
