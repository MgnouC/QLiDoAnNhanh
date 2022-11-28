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
    public partial class fGioiThieu : Form
    {
        public fGioiThieu()
        {
            InitializeComponent();
        }

        private void btnChuyenDN_Click(object sender, EventArgs e)
        {
            
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
