using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public class District
    {
        private string name;
        private string code;
        private string codeArea;
        private int isDelete = 0;
        private int id = 0;
        public static MySqlCommand cmd;
        public string req;
        /// <summary>
        /// Declaring accesseur for the privates attributs
        /// </summary>
        /// <param name="newName"></param>
        /// 
        public void setName(string newName) { this.name = newName; }
        public void setCode(string newCode) { this.code = newCode; }
        public void setIsDelete(int newVal) { this.isDelete = newVal; }
        public void setCodeArea(string newAreaCode) { this.codeArea = newAreaCode; }
        // Getteurs

        public int getIsDelete() { return this.isDelete; }
        public string getCode() { return this.code; }
        public string getName() { return this.name; }
        public string getAreaCode() { return this.codeArea; }
        public bool isExists() { return true; }

       
        //get all the Church Of that district 

        public List<Church> getChurchOfDistrict()
        {
            string req = "SELECT * FROM fgm_church WHERE districtParentReff = '" + this.code + "' and isDelete = 0";
            cmd = new MySqlCommand(req, DBConnection.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Church> Churchs = new List<Church>();


            while (dr.Read())
            {
                Church church = new Church();
                church.setCode(dr["stationCode"].ToString());
                church.setName(dr["stationName"].ToString());
                church.setDistrict(this);
                church.setSlogang(dr["stationSlogang"].ToString());
                church.setIsDelete(Convert.ToInt32(dr["isDelete"]));
                Churchs.Add(church);
            }
            dr.Close();
            return Churchs;
        }


        public string generateDistrictCode(string initiaux)
        {

            this.id = appFunctions.getDistrictNumber();
            this.id = this.id + 1;
            if (this.id < 10)
            {
                
                return this.codeArea + initiaux[0] + initiaux[1] + "000" +(this.id);
            }
            else if (this.id < 100)
            {
                return this.codeArea + initiaux[0] + initiaux[1] + "00" + (this.id);
            }

            return this.codeArea + initiaux[0] + initiaux[1] + (this.id);

        }


        public bool Save()
        {
            if (this.code != "" && this.name != "")
            {
                if (!this.isExist())
                {
                    string req = "INSERT INTO fgm_district(districtCode, districtName,codeArea,isDelete) VALUES('"
                        + this.code + "','"
                        + this.name + "','"
                        + this.codeArea + "',"
                        + this.isDelete +")";
                    cmd = new MySqlCommand(req, DBConnection.con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            return false;
        }


        public bool Update()
        {

            if (this.code != "" && this.name != "")
            {
                if (this.isExist())
                {
                    string req = "UPDATE fgm_district SET districtName ='"
                        + this.name + "', isDelete ='"
                        + this.isDelete + "', codeArea ='"
                        + this.codeArea + "', where districtCode = '"
                        + this.code + "')";
                    cmd = new MySqlCommand(req, DBConnection.con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public bool isExist()
        {

            string req = "SELECT COUNT(districtCode) FROM fgm_district WHERE districtCode = '" + this.code + "'";
            cmd = new MySqlCommand(req, DBConnection.con);
            Int32 rep = Convert.ToInt32(cmd.ExecuteScalar());
            if (rep > 0)
                return true;
            return false;
        }

    }
}
