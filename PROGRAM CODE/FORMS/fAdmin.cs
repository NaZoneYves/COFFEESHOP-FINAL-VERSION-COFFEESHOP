using PROJECT.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROJECT.DB.SupportDB;

namespace PROJECT
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadAccountList();
        }

        //đưa danh sách account lên dtgvAccount
        void LoadAccountList()
        {
            string Query = "Exec dbo.GetAccountWithPara @Name1 , @Name2";
            ISupport support = new SupportDB_SQL();
            dtgvAccount.DataSource = support.ExecuteQuery(Query, new object[] { "David123", "PeterABC" });

        }
    }
}
