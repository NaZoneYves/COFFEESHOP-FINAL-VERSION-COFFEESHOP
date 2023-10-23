using PROJECT.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table.PRODUCT.FOOD
{
    public class ProcessProductCategory
    {
        private static ProcessProductCategory instance;

        public static ProcessProductCategory Instance
        {
            get
            {
                if (instance == null) instance = new ProcessProductCategory();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public ProcessProductCategory() { }

        public List<ProductCategory> GetListProductCategoryID()
        {
            //hàm này sẽ trả về 1 danh sách bao gồm tất cả các thông tin về ProductCate
            List<ProductCategory> listIDCategory = new List<ProductCategory>();
            string Query
                = "select distinct c.TypeOfProduct, a.PriceDrink, \r\n\t\t\t" +
                "a.IDDrinkCategory, b.IDFoodCategory, b.PriceFoodCategory\r\n" +
                "from  dbo.Product c, dbo.DrinkCategory a, dbo.FoodCategory b\r\n" +
                "where (c.IDDrinkCategory = a.IDDrinkCategory)\r\n" +
                "and (c.IDFoodCategory = B.IDFoodCategory) ";

            //lấy IDCategory từ việc truy vấn
            DataTable data = SupportDB_SQL.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows) 
            {
                ProductCategory proCategory = new ProductCategory(item);
                listIDCategory.Add(proCategory);
            }
            return listIDCategory;
        }
    }
}
