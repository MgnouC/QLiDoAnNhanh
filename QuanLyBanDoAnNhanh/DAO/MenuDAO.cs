using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoAnNhanh.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<QuanLyBanDoAnNhanh.DTO.Menu> GetListMenuByTable(int id)
        {
            List<QuanLyBanDoAnNhanh.DTO.Menu> listMenu = new List<QuanLyBanDoAnNhanh.DTO.Menu>();
            string query = "select f.name, bi.count, f.price, f.price*bi.count AS totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QuanLyBanDoAnNhanh.DTO.Menu menu = new QuanLyBanDoAnNhanh.DTO.Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }


    }
    }
