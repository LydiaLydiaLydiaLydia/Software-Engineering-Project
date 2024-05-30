using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FerrySYS
{
    class VehicleType
    {
        private String code;
        private String description;
        private decimal price;
        private char status;

        public VehicleType() {
            this.code = "";
            this.description = "";
            this.price = 0;
            this.status = 'A';
        }

        public VehicleType(String code, String description, decimal price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
            this.status = 'A';
        }

        public String getCode() {
            return this.code;
        }
        public String getDescription() { return this.description;}
        public decimal getPrice() { return this.price;}
        public char getStatus() { return this.status;}

        public void setCode(String code) { this.code = code;}
        public void setDescription(String description) {  this.description = description;}
        public void setPrice(decimal price) {  this.price = price;}
        public void setStatus(char status) { this.status = status;}

        public static bool validateVehicleInput(String description, String code, String price, List<String> codes)
        {
            if (code.Trim().Length != 2 || (code.Equals("  ")) || !(Regex.IsMatch(code, @"^[a-zA-Z]+$")))
            {
                MessageBox.Show("Vehicle Type Code must be exactly 2 alphabetic characters long, with no spaces");
                return false;
            }
            if (description.Equals(""))
            {
                MessageBox.Show("Vehicle Type Description must not be null");
                return false;
            }
            
            if (codes.Count != 0) {
                for (int i = 0; i < codes.Count; i++)
                {
                    if (codes.ElementAt(i).Equals(code))
                    {
                        MessageBox.Show("Vehicle Type Code must not already exist in Vehicle Types file");
                        return false;
                    }
                }
            }


            if (!Double.TryParse(price, out double dprice))
            {
                MessageBox.Show("Vehicle Type Price should be in the form 99.99");
                return false;
            }
            if (dprice > 99.99 || dprice < 0)
            {
                MessageBox.Show("Vehicle Type Price must be no larger than 99.99 and greater than or equal to 0.");
                return false;
            }
            if (price.Equals(""))
            {
                MessageBox.Show("Vehicle Type Price cannot be null");
                return false;
            }
            return true;
        }
        public static bool validateVehicleInput(String description, String code, String price)
        {
            if (code.Trim().Length != 2 || (code.Equals("  ")) || !(Regex.IsMatch(code, @"^[a-zA-Z]+$")))
            {
                MessageBox.Show("Vehicle Type Code must be exactly 2 alphabetic characters long, with no spaces");
                return false;
            }
            if (description.Equals(""))
            {
                MessageBox.Show("Vehicle Type Description must not be null");
                return false;
            }


            if (!Double.TryParse(price, out double dprice))
            {
                MessageBox.Show("Vehicle Type Price should be in the form 99.99");
                return false;
            }
            if (dprice > 99.99 || dprice < 0)
            {
                MessageBox.Show("Vehicle Type Price must be no larger than 99.99 and greater than or equal to 0.");
                return false;
            }
            if (price.Equals(""))
            {
                MessageBox.Show("Vehicle Type Price cannot be null");
                return false;
            }
            return true;
        }
        public bool addVehicleType()
        {
            try {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //Define the SQL query to be executed
                String sqlQuery = "INSERT INTO Vehicle_Types VALUES ('" +
                    this.code + "','" +
                    this.description + "'," +
                    this.price + ",'" +
                    this.status + "')";

         

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();

                //returns a boolean to confirm whether it was successfully written to the db
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public static DataSet getAvailableVehicleTypes() {
            try {

                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);
                
                //SQL query to get all available vehicle types
                String sqlQuery = "SELECT v_code, v_description, price " +
                    "FROM VEHICLE_TYPES " +
                    "WHERE v_status = 'A'";
                
                OracleCommand cmd = new OracleCommand( sqlQuery, conn);
              
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                
                DataSet ds = new DataSet();

                da.Fill(ds, "Vehicle_Types");

           

         

                conn.Close();

                return ds;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public bool amendVehicleType()
        {
            try
            {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //Define the SQL query to be executed
                String sqlQuery = "UPDATE Vehicle_Types " +
                    "SET V_Description = '" + this.description + "'," +
                    "Price = " + this.price + ", " +
                    "V_Status = '" + this.status + "' " +
                    "WHERE V_Code = '" + this.code +"'";
                
                //Execute the SQL query (OracleCommand)
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
                return false;
            }
        }

        public static List<String> getVehicleCodes() {
            try
            {
                List<String> codes = new List<String>();

                //Opening a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                //SQL query to get all vehicle types
                String sqlQuery = "SELECT v_code " +
                    "FROM VEHICLE_TYPES";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "Vehicle_Types");

                conn.Close();

                if (ds != null)
                {
                    if (ds.Tables["Vehicle_Types"].Rows.Count > 0)
                    {

                        for (int i = 0; i < ds.Tables["Vehicle_Types"].Rows.Count; i++)
                        {
                            codes.Add(ds.Tables["Vehicle_Types"].Rows[i][0].ToString());
                        }
                    }

                }

                return codes;

            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot read from Vehicle Types file");
                return null;
            }
        }
    }
}
