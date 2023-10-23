using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class BillDetailInfo
    {
        private int iDBillInfo;
        private string iDProduct;
        private int quantityProduct;

        public int IDBillInfo { get => iDBillInfo; set => iDBillInfo = value; }
        public string IDProduct { get => iDProduct; set => iDProduct = value; }
        public int QuantityProduct { get => quantityProduct; set => quantityProduct = value; }

        public BillDetailInfo(DataRow row) 
        { 
            IDBillInfo = (int)row["IDBillInfo"];
            IDProduct = (string)row["IDProduct"];
            QuantityProduct = (int)row["Quantity"];
        }
        public BillDetailInfo(int id, string idproduct, int quantity) 
        {
            IDBillInfo = id;
            IDProduct = idproduct;
            QuantityProduct = quantity;
        }
    }
}
