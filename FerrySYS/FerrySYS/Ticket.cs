using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrySYS
{
    internal class Ticket
    {
        private int code;
        private DateTime dateAndTime;
        private String vCode;
        private decimal price;
        private int depId;

        public Ticket(int code, DateTime dateAndTime, string vCode, decimal price, int depId)
        {
            this.code = code;
            this.dateAndTime = dateAndTime;
            this.vCode = vCode;
            this.price = price;
            this.depId = depId;
        }   
        public Ticket()
        {
            this.code=0;
            this.dateAndTime = DateTime.Now;
            this.vCode=null;
            this.price = 0;
            this.depId=0;
        }

        public int getCode()
        {
            return code;   
        }
        public DateTime getDateAndTime()
        {
            return dateAndTime;
        }
        public string getVCode()
        {
            return vCode;
        }
        public decimal getPrice()
        {
            return price;
        }
        public int getDepId()
        {
            return depId;
        }

        public void setCode(int code)
        {
            this.code = code;
        }
        public void setDateAndTime(DateTime dateAndTime) { 
            this.dateAndTime = dateAndTime;
        }
        public void setVCode(String vCode)
        {
            this.vCode = vCode;
        }
        public void setPrice(decimal price)
        {
            this.price = price;
        }
        public void setDepId(int depId) {
            this.depId = depId;
        }

        public static int getNextID()
        {
            try
            {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //Define the SQL query to be executed
                String sqlQuery = "SELECT MAX(T_Code) FROM Tickets";

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                //Does dr contain a value or NULL?
                int nextId;
                dr.Read();

                if (dr.IsDBNull(0))
                    nextId = 1;
                else
                {
                    nextId = dr.GetInt32(0) + 1;
                }

                //Close db connection
                conn.Close();

                return nextId;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading Ticket file");
                return 0;
            }
        }

        public bool saveTicket() {
            try
            {
                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all available vehicle types
                String sqlQuery = "INSERT INTO Tickets (T_Code, T_Date, T_Time, V_Code, Sale_Price, Dep_ID) VALUES " +
                "(" + this.getCode() + ", " +
                "'" + String.Format("{0:dd-MMM-yy}", this.getDateAndTime()) + "', " +
                "'" + String.Format("{0:t}", this.getDateAndTime()) + "', " +
                "'" + this.getVCode() + "', " +
                this.getPrice() + ", " +
                this.getDepId() + ")";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();

                //returns a boolean to confirm whether it was successfully written to the db
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inserting into Tickets file");
                return false;
            }
        }

        public static DataSet viewRevenue(String year) {
            try
            {
                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all available vehicle types
                String sqlQuery = "SELECT TO_CHAR(T_Date, 'MM MON') AS Month, SUM(Sale_Price) AS Revenue " +
                    "FROM Tickets " +
                    "WHERE T_Date LIKE '%" + year + "' " +
                    "GROUP BY TO_CHAR(T_Date, 'MM MON') " +
                    "ORDER BY Month";
                
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "Revenue");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static DataSet yearsAvailable() {
            try
            {
                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all available vehicle types
                String sqlQuery = "SELECT UNIQUE TO_CHAR(T_Date, 'YY') AS YearsActive " +
                                   "FROM Tickets" ;

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "Years");

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
