using QuanLyBanDoAnNhanh.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoAnNhanh
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
         //   LoadAccountList();
        }


       /* void LoadAccountList()
        {
           

            string query = "exec dbo.USP_GetAccountByUserName @userName ";
           
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"TramTram"});
        }
       */
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
