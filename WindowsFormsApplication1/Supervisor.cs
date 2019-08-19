using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
   public class Supervisor
    {
        private int id;
        private Pastor pastor;
        private Area areaSupervised;
        private District districtSupervised;
        private string nominationDate = new DateTime().ToString("yyyy-MM-dd");
        private string req;
        private MySqlCommand cmd;
        private MySqlDataReader dr;
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public Pastor getPastor()
        {
            return this.pastor;
        }

        public void setPastor(Pastor pastor)
        {
            this.pastor = pastor;
        }

        public Area getAreaSupervised()
        {
            return this.areaSupervised;
        }

        public void setAreaSupervised(Area areaSupervised)
        {
            this.areaSupervised = areaSupervised;
        }

        public string getNominationDate()
        {
            return this.nominationDate;
        }

        public void setNominationDate(string nominationDate)
        {
            this.nominationDate = nominationDate;
        }

        public bool isAreaExist()
        {
            req = "SELECT COUNT(id) FROM fgm_area_supervisor WHERE id = '" + this.id + "' ";
            MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                return true;
            }
            return false;
        }

        public bool isDistrictExist()
        {
            req = "SELECT COUNT(id) FROM fgm_district_supevisor WHERE id = '" + this.id + "' ";
            MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                return true;
            }
            return false;
        }


        public bool Save(string division)
        {
            this.id = appFunctions.getSuperPastorNumber();
            this.id++;
            MessageBox.Show("Mon ID : " + this.id);
            if (division == "area")
            {
                if (!this.isAreaExist())
                {

                    req = "INSERT INTO fgm_area_supervisor VALUES("
                        + this.id +
                        ",'" + this.pastor.getCode() +
                        "','" + this.areaSupervised.getCode() +
                        "','" + this.nominationDate + "')";
                }
                else
                    return false;
            }
            else if(division =="district")
            {
                if (!this.isDistrictExist())
                {
                    req = "INSERT INTO fgm_area_supervisor VALUES("
                        + this.id +
                        ",'" + this.pastor.getCode() +
                        "','" + this.areaSupervised.getCode() +
                        "','" + this.nominationDate + "')";
                }else
                {
                    return false;
                }
            }
           MessageBox.Show("Mon ID" + this.id);
            MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
            cmd.ExecuteNonQuery();
            return true; 
        }

        // Update methode 

        public bool Update(string division)
        {
            if (division == "area")
            {
                if (!this.isAreaExist())
                {

                    req = "UPDATE fgm_area_supervisor SET pastorAreaSupervisorCode ='"
                        + this.pastor.getCode() +
                        "', SuperviceArea = '" + this.areaSupervised.getCode() +
                        "', nominationDate = '" + this.nominationDate +
                        "', WHERE id + '" + this.id +"')";
                }
                else
                    return false;
            }
            else if (division == "district")
            {
                if (!this.isDistrictExist())
                {
                    req = "INSERT INTO fgm_area_supervisor VALUES('"
                        + this.id +
                        "','" + this.pastor.getCode() +
                        "','" + this.areaSupervised.getCode() +
                        "','" + this.nominationDate + "')";
                }
                else
                {
                    return false;
                }
            }

            MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
            cmd.ExecuteNonQuery();
            return true;
        }


    }
}
