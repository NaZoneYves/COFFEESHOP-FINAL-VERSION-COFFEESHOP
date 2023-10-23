using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class OneMenu
    {
        private string productName;
        private int quantity;
        private string typeOfProduct;
        private float price;
        private float totalPrice;
        public string ProductName { get => productName; set => productName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string TypeOfProduct { get => typeOfProduct; set => typeOfProduct = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public OneMenu(DataRow row)
        {
            ProductName = (string)row["NameProduct"];
            Quantity = (int)row["Quantity"];
            TypeOfProduct = (string)row["TypeOfProduct"];

            if (TypeOfProduct == "FOOD")
            {
                Price = (float)Convert.ToDouble(row["PriceFoodCategory"].ToString());
            }
            else
            {
                Price = (float)Convert.ToDouble(row["PriceDrink"].ToString());
            }

            //tổng tiền 1 hóa đơn nhỏ (1 row product)
            TotalPrice = Quantity * Price;
        }
        public OneMenu(string name, int quantity, float price, float total = 0) 
        {
            ProductName = name;
            Quantity = quantity;
            Price = price;
            TotalPrice = total;
        }


    }
}
