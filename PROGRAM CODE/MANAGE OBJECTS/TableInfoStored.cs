using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Table
{
    public class TableInfoStored
    {
        private int iD;
        private string name;
        private string status;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public TableInfoStored(int id, string name, string status) 
        {
            ID = id;
            Name = name;
            Status = status;
        }

        public TableInfoStored(DataRow row)
        {
            ID = (int)row["IDTable"];
            Name = (string)row["NameTable"];
            Status = (string)row["StatusTable"];
        }
    }
}
