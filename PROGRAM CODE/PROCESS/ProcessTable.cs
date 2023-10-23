using PROJECT.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class ProcessTable
    {
        public static int TableWidth = 120;
        public static int TableHeight = 120;
        private static ProcessTable instance;

        public static ProcessTable Instance
        { 
            get
            {
                if (instance == null) instance = new ProcessTable();
                return instance;
            }
            private set 
            {
                Instance = value;
            }
        }
        private ProcessTable() { }

        //đưa thông tin, trạng thái bàn ăn
        public List<TableInfoStored> LoadListTable()
        {
            List<TableInfoStored> tableList = new List<TableInfoStored>();

            DataTable data = SupportDB_SQL.Instance.ExecuteQuery("exec dbo.GetTableList");

            foreach (DataRow item in data.Rows)
            {
                TableInfoStored table = new TableInfoStored(item);
                tableList.Add(table);
            }
            return tableList;
        }

    }
}
