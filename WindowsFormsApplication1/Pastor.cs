using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public class Pastor
    {
        private string matricule;
        private string name;
        private string surname;
        private string dateOfBirth;
        private string tels;
        private string email;
        private string country;
        private string conversionDate;
        private string professionBeforeBibleschool;
        private string gender;
        private string areaOfCall;
        private string martialStatus;
        private int numberYearInArea;
        private int numberYearDistrict;
        private string rankProbation = "";
        private string pastorMotherName;
        private string pastorFotherName;
        private string pastorAdresse;
        private string pastorPlaceOfBirth;
        private string picture = "Nonepng";
        private int isActif = 1;
        private string raisonIndisp = "RAS";
        private int isDelete = 0;
        private string req;
        private int id ;
        public string getCode() { return this.matricule; }
        public string getMatricule()
        {
            return this.matricule;
        }

        public void setMatricule(string matricule)
        {
            this.matricule = matricule;
        }
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getDateOfBirth()
        {
            return this.dateOfBirth;
        }

        public void setDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public string getTels()
        {
            return this.tels;
        }

        public void setTels(string tels)
        {
            this.tels = tels;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getCountry()
        {
            return this.country;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }

        public string getConversionDate()
        {
            return this.conversionDate;
        }

        public void setConversionDate(string conversionDate)
        {
            this.conversionDate = conversionDate;
        }

        public string getProfessionBeforeBibleschool()
        {
            return this.professionBeforeBibleschool;
        }

        public void setProfessionBeforeBibleschool(string professionBeforeBibleschool)
        {
            this.professionBeforeBibleschool = professionBeforeBibleschool;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getAreaOfCall()
        {
            return this.areaOfCall;
        }

        public void setAreaOfCall(string areaOfCall)
        {
            this.areaOfCall = areaOfCall;
        }

        public string getMartialStatus()
        {
            return this.martialStatus;
        }

        public void setMartialStatus(string martialStatus)
        {
            this.martialStatus = martialStatus;
        }

        public int getNumberYearInArea()
        {
            return this.numberYearInArea;
        }

        public void setNumberYearInArea(int numberYearInArea)
        {
            this.numberYearInArea = numberYearInArea;
        }

        public int getNumberYearDistrict()
        {
            return this.numberYearDistrict;
        }

        public void setNumberYearDistrict(int numberYearDistrict)
        {
            this.numberYearDistrict = numberYearDistrict;
        }

        public string getRankProbation()
        {
            return this.rankProbation;
        }

        public void setRankProbation(string rankProbation)
        {
            this.rankProbation = rankProbation;
        }

        public string getPastorMotherName()
        {
            return this.pastorMotherName;
        }

        public void setPastorMotherName(string pastorMotherName)
        {
            this.pastorMotherName = pastorMotherName;
        }

        public string getPastorFotherName()
        {
            return this.pastorFotherName;
        }

        public void setPastorFotherName(string pastorFotherName)
        {
            this.pastorFotherName = pastorFotherName;
        }

        public string getPastorAdresse()
        {
            return this.pastorAdresse;
        }

        public void setPastorAdresse(string pastorAdresse)
        {
            this.pastorAdresse = pastorAdresse;
        }

        public string getPastorPlaceOfBirth()
        {
            return this.pastorPlaceOfBirth;
        }

        public void setPastorPlaceOfBirth(string pastorPlaceOfBirth)
        {
            this.pastorPlaceOfBirth = pastorPlaceOfBirth;
        }

        public string getPicture()
        {
            return this.picture;
        }

        public void setPicture(string picture)
        {
            this.picture = picture;
        }

        public int getIsActif()
        {
            return this.isActif;
        }

        public void setIsActif(int isActif)
        {
            this.isActif = isActif;
        }

        public string getRaisonIndisp()
        {
            return this.raisonIndisp;
        }

        public void setRaisonIndisp(string raisonIndisp)
        {
            this.raisonIndisp = raisonIndisp;
        }

        public int getIsDelete()
        {
            return this.isDelete;
        }

        public void setIsDelete(int isDelete)
        {
            this.isDelete = isDelete;
        }
        public bool isExist()
        {
            req = "SELECT COUNT(matriculePastor) FROM fgm_pastor WHERE matriculePastor = '" + this.matricule + "' ";
            MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Save()
        {
            if (!this.isExist())
            {
                this.id = appFunctions.getPastorNumber();
                this.id++;
                req = "INSERT INTO fgm_pastor VALUES('"
                    + this.matricule +
                    "','" + this.name +
                    "','" + this.surname +
                    "','" + this.dateOfBirth +
                    "','" + this.pastorPlaceOfBirth +
                    "','" + this.pastorFotherName +
                    "','" + this.pastorMotherName +
                    "','" + this.gender +
                    "','" + this.tels +
                    "','" + this.email +
                    "','" + this.conversionDate +
                    "','" + this.professionBeforeBibleschool +
                    "','" + this.rankProbation +
                    "','" + this.areaOfCall +
                    "'," + this.numberYearInArea +
                    "," + this.numberYearDistrict +
                    ",'" + this.martialStatus +
                    "','" + this.country +
                    "','" + this.pastorAdresse +
                    "','" + this.picture +
                    "'," + this.isActif +
                    ",'" + this.raisonIndisp +
                    "'," + this.isDelete +
                    "," + this.id + ")";
                MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        // Update methode 

        public bool Update()
        {
            if (this.isExist())
            {
                req = "UPDATE fgm_pastor SET  pastorName = '"
                     + this.name +
                    "', pastorSurname = '" + this.surname +
                    "', pastorBirthdayDate = '" + this.dateOfBirth +
                    "', birthdayPlace = '" + this.pastorPlaceOfBirth +
                    "', pastorFatherName = '" + this.pastorFotherName +
                    "', pastorMotherName = '" + this.pastorMotherName +
                    "', pastorSexe = '" + this.gender +
                    "', pastorPhone = '" + this.tels +
                    "', pastorEmail = '" + this.email +
                    "', dateConversion = '" + this.conversionDate +
                    "', workBeforeBibleSchool = '" + this.professionBeforeBibleschool +
                    "', rankProbation = '" + this.rankProbation +
                    "',areaOfCall = '" + this.areaOfCall +
                    "',nberYearArea = " + this.numberYearInArea +
                    ", nbreYearDistrict =" + this.numberYearDistrict +
                    ", martialSituation ='" + this.martialStatus +
                    "',nationality = '" + this.country +
                    "',pastorAdresse ='" + this.pastorAdresse +
                    "',photoProfil'" + this.picture +
                    "',isActif =" + this.isActif +
                    ",raisonIndispoMissionnaire ='" + this.raisonIndisp +
                    "',isDelete = " + this.isDelete +
                    ", id=" + this.id + ")";
                MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
                cmd.ExecuteNonQuery();
                pastorTransfer defaultTransfert = new pastorTransfer();
                defaultTransfert.setPastor(this);
                //defaultTransfert.setChurchTo(appFunctions.getChurchByCode())
                return true;
            }
            return false;
        }


        
    }

   
}
