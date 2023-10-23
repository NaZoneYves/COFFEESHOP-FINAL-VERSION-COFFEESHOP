using PROJECT.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class ProcessMenu
    {
        private static ProcessMenu instance;

        public static ProcessMenu Instance
        {
            get
            {
                if (instance == null) instance = new ProcessMenu();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public ProcessMenu() { }

        public List<OneMenu> GetListMenuByTable(int id) //id = idtable
        { 
            List<OneMenu> listMenu = new List<OneMenu>();
            string Query 
                = "select a.NameProduct, a.TypeOfProduct, b.Quantity, c.PriceDrink, d.PriceFoodCategory \r\n" +
                "from dbo.Product a, dbo.BillInfo b, dbo.DrinkCategory c, dbo.FoodCategory d, dbo.Bill e\r\n" +
                "where (a.IDProduct = b.IDProduct) and ((a.IDDrinkCategory = c.IDDrinkCategory)\r\n\t\t" +
                "and (a.IDFoodCategory = D.IDFoodCategory)) and (b.IDBill = e.IDBill) and (e.StatusBill = 0) and e.IDTable = " + id;
            
            DataTable data = SupportDB_SQL.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows) 
            {
                OneMenu menu = new OneMenu(item);
                listMenu.Add(menu);
            }
            
            return listMenu;
        }
    }
}
