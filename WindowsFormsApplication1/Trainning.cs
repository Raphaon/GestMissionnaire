using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    class Trainning
    {
        private string code;
        private string institutName;
        private string typeOftrainning;
        private Pastor pastorConcern;
        private string qualification;
        private string startDate;
        private string dateEnd;
        private MySqlCommand cmd;
        private MySqlDataReader dr;
        private string req;
        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public string getInstitutName()
        {
            return this.institutName;
        }

        public void setInstitutName(string institutName)
        {
            this.institutName = institutName;
        }

        public string getTypeOftrainning()
        {
            return this.typeOftrainning;
        }

        public void setTypeOftrainning(string typeOftrainning)
        {
            this.typeOftrainning = typeOftrainning;
        }

        public Pastor getPastorConcern()
        {
            return this.pastorConcern;
        }

        public void setPastorConcern(Pastor pastorConcern)
        {
            this.pastorConcern = pastorConcern;
        }

        public string getQualification()
        {
            return this.qualification;
        }

        public void setQualification(string qualification)
        {
            this.qualification = qualification;
        }

        public void setStartDate(string startDate){ this.startDate =startDate; }
        public string getStartDate() { return this.startDate; }

        public void setEndDate(string newVal) { this.dateEnd = newVal; }
        public string getEndDate() { return this.dateEnd; }
        public bool isExist()
        {
            req = "SELECT count(trainningCode) FROM fgm_trainning WHERE trainningCode = '"+ this.code +"' ";
            cmd = new MySqlCommand(req, DBConnection.con);
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) 
                return true; 
            return false;
        }
        public bool Save()
        {
            if (!this.isExist()) 
            {
                req = "INSERT INTO fgm_trainning VALUES('"
                    + this.code + "','" +
                    this.institutName + "','" +
                    this.typeOftrainning + "', '" +
                    this.pastorConcern.getCode() + "','" +
                    this.qualification + "','" +
                    this.startDate + "','"+
                    this.dateEnd+"')";
                cmd = new MySqlCommand(req, DBConnection.con);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false; 
        }


        public bool Update()
        {
            if (this.isExist())
            {
                req = "UPDATE fgm_trainning SET institutName = '"
                    +this.institutName + "', typeFormation = '" +
                    this.typeOftrainning + "', trainningPastorMatricule  = '" +
                    this.pastorConcern.getCode() + "', qualification = '" +
                    this.qualification + "' WHERE trainningCode = '" +this.code+ "')";
                cmd = new MySqlCommand(req, DBConnection.con);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }


    }
}
