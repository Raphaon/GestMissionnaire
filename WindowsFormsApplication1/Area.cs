using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public class Area
    {
        private string code;
        private string name;
        private string city;
        private int isDelete ;
        private List<District> districts;
        private int id;
        private static MySqlCommand cmd;
        private static MySqlDataReader dr;

        public List<District> Districts { get => districts; set => districts = value; }

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getCity()
        {
            return this.city;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public int getIsDelete()
        {
            return this.isDelete;
        }

        public void setIsDelete(int isDelete)
        {
            this.isDelete = isDelete;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public string generateAreaCode(string initiaux)
        {

            this.id = appFunctions.getAreaNumber();
            this.id = this.id + 1;
            if (this.id < 10)
            {
                return "MPE" + initiaux[0] + initiaux[1] + "000" + (this.id);
            }
            if (this.id < 100)
            {
                return "MPE" + initiaux[0] + initiaux[1] + "00" + (this.id);
            }
           
            return "MPE" + initiaux[0] + initiaux[1] + (this.id);

        }


        public bool Save()
        {
            
            if (this.code != "" && this.name != "")
            {
                if (!this.isExist())
                {
                    string req = "INSERT INTO fgm_area VALUES('" 
                        + this.code + "','" 
                        + this.name + "'," 
                        + this.isDelete + ",'" 
                        + this.city + "'," 
                        + this.id + ")";
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
                    string req = "UPDATE fgm_area SET areaName ='"
                        + this.name + "', isDelete ='"
                        + this.isDelete + "', areaCity ='"
                        + this.city + "', id = "
                        + this.id + ")";
                    cmd = new MySqlCommand(req, DBConnection.con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public bool isExist()
        {

            string req = "SELECT COUNT(areaCode) FROM fgm_area WHERE areaCode = '" + this.code + "'";
            cmd = new MySqlCommand(req, DBConnection.con);
            Int32 rep = Convert.ToInt32(cmd.ExecuteScalar());
            if (rep > 0)
                return true;
            return false;
        }

        public List<District> getDistrict()
        {
            string req = "SELECT * FROM fgm_district INNER JOIN fgm_area ON fgm_district.codeArea = fgm_area.areaCode where fgm_district.isDelete= 0 and fgm_district.codeArea = '" + this.code + "' order by(districtCode) asc";
            cmd = new MySqlCommand(req, DBConnection.con);
            dr = cmd.ExecuteReader();
            List<District> areaDistList = new List<District>();
            while (dr.Read())
            {
                District dist = new District();
                dist.setCode(dr["districtCode"].ToString());
                dist.setName(dr["districtName"].ToString());
                dist.setCodeArea(dr["codeArea"].ToString());
                dist.setIsDelete((Convert.ToInt32(dr["isDelete"])));
                areaDistList.Add(dist);
            }
            dr.Close();
            return areaDistList;

        }


        public string addDistrict(District dist)
        {
            if (!dist.isExists())
            {
                this.Districts.Add(dist);
                return "Success !!!";
            }
            return "Error while add it could be that the district already exist in that area";
        }

        public bool removeDistrict(District dist)
        {
            if (this.Districts.Remove(dist))
                return true;
            return false;
        }

        public newPastor getSupervisor()
        {
            newPastor p = new newPastor();
            return p;
        }
    }
}
