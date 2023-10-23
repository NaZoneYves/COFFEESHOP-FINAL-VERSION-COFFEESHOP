using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table.PRODUCT
{
    /*information của Product sẽ gồm IDProduct, NameProduct, PriceProduct
     phải tương ứng với Category của Product đó*/

    //thử nghiệm đưa drink lên để kiểm tra tương ứng không
    
    public class ProductInfomation
    {
        private string idProduct;
        private string nameProduct;
        private string typeOfProduct;
        private float priceProduct; //sẽ được xác định rõ khi phân biệt type nào

        public string IdProduct { get => idProduct; set => idProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string TypeOfProduct { get => typeOfProduct; set => typeOfProduct = value; }
        public float PriceProduct { get => priceProduct; set => priceProduct = value; }

        public ProductInfomation(DataRow row)
        {
            IdProduct = (string)row["IDProduct"];
            NameProduct = (string)row["NameProduct"];
            TypeOfProduct = (string)row["TypeOfProduct"];
            
            var price = (float)Convert.ToDouble(row["PriceDrink"].ToString());

            if (TypeOfProduct == "DRINK")
            {
                PriceProduct = price;
            }
            else
            {
                PriceProduct = (float)Convert.ToDouble(row["PriceFoodCategory"].ToString());
            }
        }
        public ProductInfomation(string id, string name, string type, float price) 
        {
            IdProduct = id;
            NameProduct = name;
            TypeOfProduct = type;
            PriceProduct = price;
        }

    }
}
