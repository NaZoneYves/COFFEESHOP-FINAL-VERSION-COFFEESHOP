using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//lưu trữ các thông tin về Category của (tất cả các loại) Product
namespace PROJECT.Table.PRODUCT
{
    public class ProductCategory
    {
        private string idCategory;
        private float priceCategory;
        private string typeOfProduct;
        public string IdCategory { get => idCategory; set => idCategory = value; }
        public float PriceCategory { get => priceCategory; set => priceCategory = value; }
        public string TypeOfProduct { get => typeOfProduct; set => typeOfProduct = value; }

        public ProductCategory(DataRow row)
        {
            var IDCheck = (string)row["IDDrinkCategory"];
            var PriceCheck = (float)Convert.ToDouble(row["PriceDrink"].ToString());
            TypeOfProduct = (string)row["TypeOfProduct"];
            
            //Nhận data theo loại sản phẩm
            if (TypeOfProduct == "DRINK")
            {
                IdCategory = IDCheck;
                
                PriceCategory = PriceCheck;
            }
            else
            {
                IdCategory = (string)row["IDFoodCategory"];
                
                PriceCategory = (float)Convert.ToDouble(row["PriceFoodCategory"].ToString());
            }
        }
        public ProductCategory(string id, string name, float price)
        { 
            IdCategory = id;
            PriceCategory = price;
        }
    }
}
