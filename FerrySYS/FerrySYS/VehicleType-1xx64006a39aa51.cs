using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Oracle.ManagedDataAccess.Client;

namespace FerrySYS
{
    class VehicleType
    {
        private String code;
        private String description;
        private double price;
        private char status;

        public VehicleType() {
            this.code = "";
            this.description = "";
            this.price = 0;
            this.status = 'A';
        }

        public VehicleType(String code, String description, double price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
            this.status = 'A';
        }

        //Setters
        public String getCode() {
            return this.code;
        }
        public String getDescription() { return this.description;}
        public double getPrice() { return this.price;}
        public char getStatus() { return this.status;}

        //Setters
        public void setCode(String code) { this.code = code;}
        public void setDescription(String description) {  this.description = description;}
        public void setPrice(double price) {  this.price = price;}
        public void setStatus(char status) { this.status = status;}

        public void addProduct() {

            //Opening the connection with the db
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //sql query as a string
            String addPQuery = "INSERT INTO Vehicle_Types VALUES('" +
                this.code + "', '" +
                this.description + "', " +
                this.price + ", '" +
                this.status + "')";

            //executing the query
            OracleCommand cmd = new OracleCommand(addPQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            //closing the connection
            conn.Close();
        }
    }
}
