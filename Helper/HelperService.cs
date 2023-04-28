using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Helper
{
    public class HelperService
    {
     public static string configConn = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;
     public static int mpId = Convert.ToInt32(ConfigurationManager.AppSettings["maloprodaja"]);
     public static string receiptPrinterName = Convert.ToString(ConfigurationManager.AppSettings["receiptPrinterName"]);

        public static DataTable getDataTable(string upit)
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand(upit, conn))
                    {
                        dt.Load(dCmd.ExecuteReader());
                    }
                    conn.Close(); // lets close explicitely
                }
                return dt;
            }
            catch
            {
                return dt; ;
            }
        }
    }
}
