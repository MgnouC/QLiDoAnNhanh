using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanDoAnNhanh.DAO;

namespace QuanLyBanDoAnNhanh
{
    public partial class fDanhMuc : Form
    {
        BindingSource CategoryList = new BindingSource();

        public fDanhMuc()
        {
            InitializeComponent();
            dtgvCategory.DataSource = CategoryList;
            LoadCategory();
            AddCategoryBinding();
        }

        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        void LoadCategory()
        {
            CategoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void AddCategory(string name)
        {
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
            }
            else
            {
                MessageBox.Show("Thêm danh mục không thành công");
            }
            LoadCategory();
        }

        void DeleteCategory(string name)
        {
            /* if ( loginAccount.UserName.Equals(userName))
              {
                  MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                  return;
              }*/
            if (CategoryDAO.Instance.DeleteCategory(name))
            {
                MessageBox.Show("Xóa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại");
            }

            LoadCategory();
        }

        void EditCategory(int id, string name)
        {
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;

            AddCategory(name);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            DeleteCategory(name);
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = int.Parse(txbCategoryID.Text);
            EditCategory(id, name);
        }
    }
}
