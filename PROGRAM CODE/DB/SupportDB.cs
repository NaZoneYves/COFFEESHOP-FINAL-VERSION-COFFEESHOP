using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DB
{
    internal class SupportDB
    {
        public interface ISupport
        {
            DataTable ExecuteQuery(string query, object[] parameter);
        }
    }
}
