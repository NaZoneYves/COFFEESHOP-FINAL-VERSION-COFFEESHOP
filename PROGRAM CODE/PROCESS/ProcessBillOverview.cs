using PROJECT.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class ProcessBillOverview
    {
        private static ProcessBillOverview instance;
        public static ProcessBillOverview Instance
        {
            get
            {
                if (instance == null) instance = new ProcessBillOverview();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ProcessBillOverview() { }

        //lấy IDbill chưa checkout từ idtable (truyền vào idtable)
        public int GetUncheckBillByTableID(int id) //id = idtable => trả về idbill
        {
            string Query = "select * from dbo.Bill\r\n" +
                           "where IDTable = " + id + "and StatusBill = 0";
            DataTable data = SupportDB_SQL.Instance.ExecuteQuery(Query);

            /*nếu sau khi truy vấn, có được bản ghi (row) thỏa mãn
                => tiến hành đổ data vào trong 1 bill
                => trả về IDBill của bill vừa đổ data vào */
            if (data.Rows.Count > 0)
            {
                BillOverView bill = new BillOverView(data.Rows[0]);
                return bill.IDBill;
            }
            return -1;
        }

        /*đưa thông tin của BillOverView vào
         (1)IDBill = tự chạy (2) DateCheckIn = getdate (3)DateCheckOut = null (4)IDTable = ??? (5)Status = 0
         */
        public void InsertBillOverView(int id) //id = idtable
        {
            SupportDB_SQL.Instance.ExecuteNonQuery("EXEC dbo.InsertBill @idTable", new object[] {id});
        }

        public int GetMaxIDBillValue()
        {
            int maxID = 0;
            string query = "select Max(IDBill) from dbo.Bill";
            maxID = (int)SupportDB_SQL.Instance.ExecuteScalar(query);
            return maxID;
        }

        public void CheckOut(int id) //id = idBill , statusbill = 1 ->checkout rồi
        {
            string query = "UPDATE dbo.Bill set StatusBill = 1 where IDBill = " + id;
            SupportDB_SQL.Instance.ExecuteNonQuery(query);
        }
    }
}
