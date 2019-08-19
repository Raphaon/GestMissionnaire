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
    public static class appFunctions
    {
        private static MySqlCommand cmd;
        private static MySqlDataReader dr;


        public static int getAreaNumber()
        {
            string req = "SELECT MAX(id) FROM fgm_area";
            cmd = new MySqlCommand(req, DBConnection.con);
            return (int)Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static int getDistrictNumber()
        {

            string req = "SELECT count(districtCode) FROM fgm_district";
            cmd = new MySqlCommand(req, DBConnection.con);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }
        public static int getChurchNumber()
        {

            string req = "SELECT count(stationCode) FROM fgm_church";
            cmd = new MySqlCommand(req, DBConnection.con);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }
        public static int getPastorNumber()
        {

            string req = "SELECT count(id) FROM fgm_pastor";
            cmd = new MySqlCommand(req, DBConnection.con);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }


        public static int getSuperPastorNumber()
        {

            string req = "SELECT count(id) FROM fgm_area_supervisor";
            cmd = new MySqlCommand(req, DBConnection.con);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }


        public static int getTransferNumber()
        {
            string req = "SELECT count(*) FROM fgm_pastor_transfer";
            cmd = new MySqlCommand(req, DBConnection.con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /*
         * Get the all the area as a list COllectiion
         * */
        
        public static List<Area> getAreaList ()
           {
                
                string req = "SELECT * FROM fgm_area WHERE isDelete=0 order by(areaCode) asc";
                cmd = new MySqlCommand(req, DBConnection.con);
                dr = cmd.ExecuteReader();
                
                List<Area> areaLis = new List<Area>();
               
                while(dr.Read())
                {
                   Area region = new Area();
                    region.setCode(dr["areaCode"].ToString());
                    region.setCity(dr["areaCity"].ToString());
                    region.setName(dr["areaName"].ToString());
                    region.setIsDelete((Convert.ToInt32(dr["isDelete"])));
                    areaLis.Add(region);
                }
                dr.Close();
                return areaLis;
           }

        
         


           public static List<District> getDistrictList()
          {

              string req = "SELECT * FROM fgm_district WHERE isDelete=0 order by(districtCode) asc";
              cmd = new MySqlCommand(req, DBConnection.con);
             dr = cmd.ExecuteReader();
              List<District> areaLis = new List<District>();
              while (dr.Read())
              {
                  District dist = new District();
                  dist.setCode(dr["districtCode"].ToString());
                  dist.setCodeArea(dr["codeArea"].ToString());
                  dist.setName(dr["districtName"].ToString());
                  dist.setIsDelete((Convert.ToInt32(dr["isDelete"])));
                  areaLis.Add(dist);
              }
              dr.Close();
              return areaLis;
          }
        
            public static List<Church> getChurchList()
           {

              
               string req = "SELECT * FROM fgm_church WHERE isDelete = 0";
               cmd = new MySqlCommand(req, DBConnection.con);
               dr = cmd.ExecuteReader();
               List<Church> churchs = new List<Church>();

               while (dr.Read())
               {
                    Church church = new Church();
                    church.setCode(dr["stationCode"].ToString());
                   church.setName(dr["stationName"].ToString());
                   church.setPicture(dr["stationPicture"].ToString());
                   church.setIsDelete((int)dr["isDelete"]);
                   church.setDistrict(new District());
                   church.setDistrictCode((dr["districtParentReff"].ToString()));
                   churchs.Add(church);
               }
               dr.Close();
               return churchs;
           }


          public static Area getAreaByCode(string codeArea) 
          {
              string req = "SELECT * FROM fgm_area where areaCode = '"+ codeArea + "'";
              cmd = new MySqlCommand(req, DBConnection.con);
              dr = cmd.ExecuteReader();
              Area region = new Area ();
              while (dr.Read())
              {
                  region.setCode(dr["areaCode"].ToString());
                  region.setCity(dr["areaCity"].ToString());
                  region.setName(dr["areaName"].ToString());
                  region.setIsDelete((Convert.ToInt32(dr["isDelete"])));
              }
              dr.Close();
              return region;
          }




           public static District getDistrictByCode(string codeDistrict)
           {

              string req = "SELECT * FROM fgm_district WHERE districtCode = '" + codeDistrict + "' and isDelete = 0";
               cmd = new MySqlCommand(req, DBConnection.con);

               dr = cmd.ExecuteReader();
               District dist = new District();
          
                while (dr.Read())
                {
                    dist.setCode(dr["districtCode"].ToString());
                    dist.setName(dr["districtName"].ToString());
                    dist.setCodeArea(dr["codeArea"].ToString());
                    dist.setIsDelete((Convert.ToInt32(dr["isDelete"])));
                }
            
               
               dr.Close();
               return dist;
           }
        
           public static Church getCurentPastorChurch(Pastor p)
           {
               Church church = new Church();
               string req = "SELECT * FROM fgm_church WHERE stationCode in( SELECT codeStationTransfer FROM fgm_pastor_transfer WHERE mleTransferedPastor = '"+ p.getCode() +"' and statusTransfert = 'Encours')";
               cmd = new MySqlCommand(req, DBConnection.con);
               dr = cmd.ExecuteReader();
               if (dr.Read())
               {
                   church.setCode(dr["stationCode"].ToString());
                   church.setName(dr["stationName"].ToString());
                  church.setDistrict(getDistrictByCode(dr["districtParentReff"].ToString()));
                   church.setSlogang(dr["stationSlogang"].ToString());
                   church.setIsDelete(Convert.ToInt32(dr["isBaseArea"]));
                  
               }
               dr.Close();
               return church;
           }

           public static Church getChurchByCode(string churchCode) 
           {
              
               string req = "SELECT * FROM fgm_church WHERE stationCode =  '"+ churchCode +"' and isDelete = 0";
               cmd = new MySqlCommand(req, DBConnection.con);
               dr = cmd.ExecuteReader();
               Church church = new Church();
               while (dr.Read())
               {
                   church.setCode(dr["stationCode"].ToString());
                   church.setName(dr["stationName"].ToString());
                   church.setDistrict(getDistrictByCode(dr["districtParentReff"].ToString()));
                   church.setSlogang(dr["stationSlogang"].ToString());
                   church.setIsDelete(Convert.ToInt32(dr["isDelete"]));
               }
               dr.Close();
               return church;
              
       }

       public static List<Pastor> getPastorByChurchCode(string churchCode)
       {

           List<Pastor> pastors = new List<Pastor>();
           string req = "SELECT * FROM fgm_pastor WHERE matriculePastor IN (SELECT mleTransferedPastor FROM fgm_pastor_transfer WHERE codeStationTransfer ='"+churchCode+"' and statusTransfert = 'Encours' ) ";
           cmd = new MySqlCommand(req, DBConnection.con);
           dr  = cmd.ExecuteReader();
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


        public static List<Pastor> getPastors()
        {

            List<Pastor> pastors = new List<Pastor>();
            string req = "SELECT * FROM fgm_pastor WHERE isDelete = 0 and isActif =1";
            cmd = new MySqlCommand(req, DBConnection.con);
            dr = cmd.ExecuteReader();
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

        public static Pastor getPastorByCode(string mlePastor)
        {

            
            string req = "SELECT * FROM fgm_pastor WHERE matriculePastor = '"+ mlePastor+"'";
            cmd = new MySqlCommand(req, DBConnection.con);
            dr = cmd.ExecuteReader();
            Pastor pst = new Pastor();
            while (dr.Read())
            {
                
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
            }
            dr.Close();
            return pst;
        }
        public static bool transfert(Pastor pastor, Church churTo, string startDate, string transferDate, string OccupationPosition, string statusTransfer)
       {


           return false;
       }
       
    }
}
