using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrySYS
{
    internal class Port
    {
        private char code;
        private String name;

        public Port(char code, String name)
        {
            this.code = code;
            this.name = name;
        }

        public static DataSet getPorts() {
            try
            {

                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all available vehicle types
                String sqlQuery = "SELECT P_Code, P_Name " +
                    "FROM Ports";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "Prts");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
