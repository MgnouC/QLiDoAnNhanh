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
          //  LoadAccountList();
        }


       /* void LoadAccountList()
        {
            string connectionSTR = "Data Source=DESKTOP-LVTA4O1\\SQLEXPRESS;Initial Catalog=QuanLyBanDoAnNhanh;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "select * from Account";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);   
            adapter.Fill(data);
            connection.Close();
            dtgvAccount.DataSource = data;
        }
       */
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
