using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class BillOverView
    {
        private int iDBill;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public int IDBill { get => iDBill; set => iDBill = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }

        public BillOverView(DataRow row)
        { 
            IDBill = (int)row["IDBill"];
            DateCheckIn = (DateTime?)row["DateCheckIn"];

            var dataTimeCheck = row["DateCheckOut"];
            if (dataTimeCheck.ToString() != "")
            {
                DateCheckOut = (DateTime?)dataTimeCheck;
            }
                 
            Status = (int)row["StatusBill"];
        }
        public BillOverView(int id, DateTime dateCheckIn, DateTime dateCheckOut, int status)
        {
            IDBill = id;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            Status = status;
        }
    }
}
