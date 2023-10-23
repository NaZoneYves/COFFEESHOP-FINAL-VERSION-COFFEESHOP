using PROJECT.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class ProcessBillDetailInfo
    {
        private static ProcessBillDetailInfo instance;

        public static ProcessBillDetailInfo Instance
        {
            get
            {
                if (instance == null) instance = new ProcessBillDetailInfo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private ProcessBillDetailInfo() { }

        public List<BillDetailInfo> GetListBillDetail(int id) //id = idbill
        {
            List<BillDetailInfo> ListBillInfo = new List<BillDetailInfo>();
            string Query = "select * from dbo.BillInfo\r\n" +
                           "where IDBill = " + id;
            DataTable data = SupportDB_SQL.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                BillDetailInfo Info = new BillDetailInfo(item);
                ListBillInfo.Add(Info);
            }
            return ListBillInfo;
        }

        /*đưa thông tin của BillDetailInfo vào
         (1)IDBillInfo = tự chạy (2)IDBill (3)IDProduct (4)Quantity
         
         **IDBill được lấy dựa vào IDTable, 
         *sử dụng phương thức GetUncheckBillByTableID(int id) trong ProccessBillOverView
         */
        public void InsertBillDetailInfo(int idBill, string idProduct, int quantity)
        {
            SupportDB_SQL.Instance.ExecuteNonQuery
                ("exec dbo.InsertBillDetailInfo @idBill , @idProduct , @quantity", new object[] { idBill, idProduct, quantity });
        }
    }
}
