using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public class Church
    {
        private string churchCode;
        private string churchName;
        private string churchSlong;
        private string picture;
        private District district;
        private int isDelete = 0;
        private string req;
        private MySqlCommand cmd;
     

        // les setteurs 
        public void setpicture(string newPicLink) { this.picture = newPicLink; }
        public void  setCode(string newCode){ this.churchCode = newCode;}
        public void setName(string newName) { this.churchName = newName;}
        public void setSlogang(string newSlogang) { this.churchSlong = newSlogang; }
        public void setDistrict(District dist) { this.district = dist; }
        public void setIsDelete(int newVal) { this.isDelete = newVal;  }
        public void setPicture(string newPicture) { this.picture = newPicture; }

        public void setDistrictCode(string newVal) { this.district.setCode(newVal); }
        //les getteurs

        public string getCode() { return this.churchCode;}
        public string getName(){ return this.churchName;}
        public int getIsDelete() {return this.isDelete ; }
        public string getPictureLick() { return this.picture; }
       public List<Pastor> getPastor()
        {
           req = "SELECT * FROM fgm_pastor WHERE matriculePastor in(SELECT mleTransferedpastor FROM fgm_pastor_transfer WHERE codeStationTransfer ='"+ this.churchCode +"', and statusTransfer ='Encours')";
           cmd = new MySqlCommand(req, DBConnection.con);
           MySqlDataReader dr = cmd.ExecuteReader();
            List<Pastor> pastors = new List<Pastor>();
            while (dr.Read())
            {
                Pastor pst = new Pastor();
                pst.setMatricule(dr["matriculePastor"].ToString());
                pst.setName(dr["pastorName"].ToString());
                pst.setSurname(dr["pastorSurname"].ToString());
                pst.setDateOfBirth(dr["pastorBirthdayDate"].ToString());
                pst.setPastorPlaceOfBirth(dr["birthdayPlace"].ToString());
                pst.setPastorFotherName(dr["pastorFatherName"].ToString());
                pst.setPastorMotherName(dr["pastorMotherName"].ToString());
                pst.setGender(dr["pastorSexe"].ToString());
                pst.setTels(dr["pastorPhone"].ToString());
                pst.setEmail(dr["pastorEmail"].ToString());
                pst.setConversionDate(dr["dateConversion"].ToString());
                pst.setProfessionBeforeBibleschool(dr["workBeforeBibleSchool"].ToString());
                pst.setRankProbation(dr["rankProbation"].ToString());
                pst.setAreaOfCall(dr["areaOfCalling"].ToString());
                pst.setNumberYearInArea(Convert.ToInt32(dr["nberYearArea"]));
                pst.setNumberYearDistrict(Convert.ToInt32(dr["nbreYearDistrict"]));
                pst.setMartialStatus(dr["martialSituation"].ToString());
                pst.setCountry(dr["nationality"].ToString());
                pst.setPastorAdresse(dr["pastorAdresse"].ToString());
                pst.setPicture(dr["photoProfil"].ToString());
                pst.setRaisonIndisp(dr["raisonIndispoMissionnaire"].ToString());
                pst.setIsActif(Convert.ToInt32(dr["isActif"]));
                pst.setIsDelete(Convert.ToInt32(dr["isDelete"]));
                pst.setId(Convert.ToInt32(dr["id"]));
                pastors.Add(pst);
            }
            dr.Close();
            return pastors;
        }
    }
}
