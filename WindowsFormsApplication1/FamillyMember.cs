using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class FamillyMember
    {
        private string matricule;
        private string name;
        private string surname;
        private string dateOfBirth;
        private string PlaceOfBirth;
        private string MotherName;
        private string FatherName;
        private string gender;
        private string tels;
        private string email;
        private string conversionDate;
        private string profession;
        private string typeOfLinkWithPastor;
        private Pastor pastor;
       private string satusLink;
        private string picture = "Nonepng";

       /**
        * getters and setters functions to get data in other class
        * */

        public string getMatricule()
        {
            return this.matricule;
        }

        public void setMatricule(string matricule)
        {
            this.matricule = matricule;
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

        public string getPlaceOfBirth()
        {
            return this.PlaceOfBirth;
        }

        public void setPlaceOfBirth(string PlaceOfBirth)
        {
            this.PlaceOfBirth = PlaceOfBirth;
        }

        public string getMotherName()
        {
            return this.MotherName;
        }

        public void setMotherName(string MotherName)
        {
            this.MotherName = MotherName;
        }

        public string getFatherName()
        {
            return this.FatherName;
        }

        public void setFatherName(string FatherName)
        {
            this.FatherName = FatherName;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
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

        public string getConversionDate()
        {
            return this.conversionDate;
        }

        public void setConversionDate(string conversionDate)
        {
            this.conversionDate = conversionDate;
        }

        public string getProfession()
        {
            return this.profession;
        }

        public void setProfession(string profession)
        {
            this.profession = profession;
        }

        public string getTypeOfLinkWithPastor()
        {
            return this.typeOfLinkWithPastor;
        }

        public void setTypeOfLinkWithPastor(string typeOfLinkWithPastor)
        {
            this.typeOfLinkWithPastor = typeOfLinkWithPastor;
        }

        public Pastor getPastor()
        {
            return this.pastor;
        }

        public void setPastor(Pastor pastor)
        {
            this.pastor = pastor;
        }

        public string getSatusLink()
        {
            return this.satusLink;
        }

        public void setSatusLink(string satusLink)
        {
            this.satusLink = satusLink;
        }

        public string getPicture()
        {
            return this.picture;
        }

        public void setPicture(string picture)
        {
            this.picture = picture;
        }

    }
}
