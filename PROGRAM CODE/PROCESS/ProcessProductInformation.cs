using PROJECT.DB;
using PROJECT.Table.PRODUCT.FOOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table.PRODUCT
{
    //tạm thời đưa drink lên
    public class ProcessProductInformation
    {
        private static ProcessProductInformation instance;

        public static ProcessProductInformation Instance
        {
            get
            {
                if (instance == null) instance = new ProcessProductInformation();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public ProcessProductInformation() { }

        //trả về 1 danh sách bao gồm ID, Name, Type, Price của product
        public List<ProductInfomation> GetProductInfoByIDCate(string id)
        {
            List<ProductInfomation> listProductInfomations = new List<ProductInfomation>();
            string Query
                = "select distinct c.IDProduct, c.NameProduct, c.TypeOfProduct, a.PriceDrink, \r\n\t\t\t" +
                "a.IDDrinkCategory, b.IDFoodCategory, b.PriceFoodCategory\r\n" +
                "from  dbo.Product c, dbo.DrinkCategory a, dbo.FoodCategory b\r\n" +
                "where (c.IDDrinkCategory = a.IDDrinkCategory)\r\n and (c.IDFoodCategory = b.IDFoodCategory) " +
                "and ((B.IDFoodCategory = '" + id + "') or (A.IDDrinkCategory = '" + id + "'))";

            DataTable data = SupportDB_SQL.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                ProductInfomation proInfo = new ProductInfomation(item);
                listProductInfomations.Add(proInfo);
            }
            return listProductInfomations;
        }
    }
}
