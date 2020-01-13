using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetDemo
{
    public class DbHelper
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DataSetDemodb"].ConnectionString;
            }
        }
    }
}
