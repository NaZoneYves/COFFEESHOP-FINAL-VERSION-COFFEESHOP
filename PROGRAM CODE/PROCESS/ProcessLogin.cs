using PROJECT.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Login
{
    public class ProcessLogin
    {
        private static ProcessLogin instance;

        public static ProcessLogin Instance 
        {
            get
            { 
                if (instance == null) instance = new ProcessLogin();
                return instance;
            }

            private set { instance = value; } 
        }

        private ProcessLogin() { }

        //chưa phân biệt hoa/thường
        public bool Login(string userName, string passWord)
        {
            string Query = "select * from dbo.Account\r\n" +
                           "where UserName = N'" + userName + "' and UserPassWord = N'" + passWord + "' ";
            DataTable result = SupportDB_SQL.Instance.ExecuteQuery(Query);

            return result.Rows.Count > 0;
        }
    }
}
