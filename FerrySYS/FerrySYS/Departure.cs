using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrySYS
{
    internal class Departure
    {
        private Int32 id;
        private DateTime dep_time;
        private DateTime arr_time;
        private char dep_port;
        private char status;

        public Departure()
        {
            this.id = 0;
            this.dep_time = DateTime.Now;
            this.arr_time = DateTime.Now;
            this.dep_port = 'M';
            this.status = 'A';
        }
        public Departure(Int32 id, DateTime dep_time, DateTime arr_time, char dep_port, char status) {
            this.id = id;
            this.dep_time = dep_time;
            this.arr_time = arr_time;
            this.dep_port = dep_port;
            this.status = status;
        }

        public Int32 getId()
        {
            return this.id;
        }
        public DateTime getDep_time()
        {
            return this.dep_time;
        }
        public DateTime getArr_time()
        {
            return this.arr_time;
        }
        public char getDep_port()
        {
            return this.dep_port;
        }
        public char getStatus()
        {
            return this.status;
        }
        public void setId(Int32 id)
        {
            this.id = id;
        }
        public void setDep_Time(DateTime dep_time) { 
            this.dep_time = dep_time;
        }
        public void setArr_Time(DateTime arr_time)
        {
            this.arr_time = arr_time;
        }
        public void setDep_Port(char port) { 
            this.dep_port = port;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }

        public static DataSet getTimetable()
        {
            //Used by: Use Case 04: 
            try
            {

                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all available vehicle types
                String sqlQuery = "SELECT P.P_Name AS Departure_Port, " +
                    "D.Dep_Time AS Departure_Time, D.Arr_Time AS Arrival_Time " +
                    "FROM Departures D JOIN Ports P ON P.P_Code=D.Dep_Port " +
                    "WHERE Dep_Status = 'A' " +
                    "ORDER BY D.Dep_Time";
                 

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "Timetable");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static DataSet getTimetable(String portName)
        {
            try
            {

                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all available vehicle types
                String sqlQuery = "SELECT P.P_Name AS Departure_Port, " +
                    "D.Dep_Time AS Departure_Time, D.Arr_Time AS Arrival_Time, " +
                    "D.Dep_ID " +
                    "FROM Departures D JOIN Ports P ON P.P_Code=D.Dep_Port " +
                    "WHERE Dep_Status = 'A' " +
                    "AND P.P_Name = '" + portName + "' " +
                    "ORDER BY D.Dep_Time";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "Timetable");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static bool deactivateDepartures() {
            try
            {

                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to set all Departures of status A to I
                String sqlQuery = "UPDATE Departures " +
                    "SET Dep_Status = 'I' " +
                    "WHERE Dep_Status = 'A'";

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
                MessageBox.Show("Error updating Departures file");
                return false;
            }
        }

        public static int getNextID()
        {
            try {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //Define the SQL query to be executed
                String sqlQuery = "SELECT MAX(Dep_Id) FROM Departures";

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
                MessageBox.Show("Error reading Departures file");
                return 0;
            }
        }
        
        public bool scheduleDeparture()
        {
            try
            {

                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all available vehicle types
                String sqlQuery = "INSERT INTO Departures (Dep_Id, Dep_Time, Arr_Time, Dep_Port, Dep_Status) VALUES " +
                "(" + this.getId() + ", " +
                "'" + String.Format("{0:t}", this.getDep_time()) + "', " +
                "'" + String.Format("{0:t}", this.getArr_time()) + "', " +
                "'" + this.getDep_port() + "', " +
                "'" + this.getStatus() + "')";
               

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
                MessageBox.Show("Error inserting into Departures file");
                return false;
            }
        }
    }
}
