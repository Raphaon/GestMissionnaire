﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public class AreaBase
    {
        private Church church;
        private District district;
        private string startDate;
        private string endDate;
        private int id;
        private MySqlCommand cmd;
        //private MySqlDataReader dr;

        public Church getChurch()
        {
            return this.church;
        }

        public void setChurch(Church church)
        {
            this.church = church;
        }

        public District getDistrict()
        {
            return this.district;
        }

        public void setDistrict(District disttrict)
        {
            this.district = disttrict;
        }

        public string getStartDate()
        {
            return this.startDate;
        }

        public void setStartDate(string startDate)
        {
            this.startDate = startDate;
        }

        public string getEndDate()
        {
            return this.endDate;
        }

        public void setEndDate(string endDate)
        {
            this.endDate = endDate;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public bool Save()
        {

            if (this.church != null && this.district != null)
            {
                if (!this.isExist())
                {
                    string req = "INSERT INTO fgm_area_base(churchCode, areaCode,startDate, endDate) VALUES('"
                        + this.church.getCode() + "','"
                        + this.district.getCode() + "','"
                        + this.startDate + "','"
                        + this.endDate + "')";
                    cmd = new MySqlCommand(req, DBConnection.con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }


        public bool Update()
        {

            if (this.church != null && this.district != null)
            {
                if (this.isExist())
                {
                    string req = "UPDATE fgm_area_base SET churchCode ='"
                        + this.church.getCode() + "', districtCode ='"
                        + this.district.getCode() + "', startDate ='"
                        + this.startDate + "', endStart = '"
                        + this.endDate + "' where id =" + this.id + ")";
                    cmd = new MySqlCommand(req, DBConnection.con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public bool isExist()
        {

            string req = "SELECT COUNT(churchCode) FROM fgm_area_base WHERE churchCode = '" + this.church.getCode() + "' and ";
            cmd = new MySqlCommand(req, DBConnection.con);
            Int32 rep = Convert.ToInt32(cmd.ExecuteScalar());
            if (rep > 0)
                return true;
            return false;
        }

    }
}
