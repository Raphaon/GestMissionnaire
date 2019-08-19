using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
   public  class Ordination
    {
       private int id;
       private Pastor pastor;
       private string OrdinationDate;
       private string grade;
       //global variable for the class a dataReader, string to do commande and MysqlCommand to execute the Commande
       private MySqlCommand cmd;
       private string req;
       private MySqlDataReader dr;

       /**
        * part reserve for getters and setters methods
        * */
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

       public string getOrdinationDate()
       {
           return this.OrdinationDate;
       }

       public void setOrdinationDate(string OrdinationDate)
       {
           this.OrdinationDate = OrdinationDate;
       }

       public string getGrade()
       {
           return this.grade;
       }

       public void setGrade(string grade)
       {
           this.grade = grade;
       }    

       // Looking if the ordination already exist in the database 
       public bool isExist()
       {
           req = "SELECT count(id) FROM fgm_ordination WHERE id = '" + this.id + "' ";
           cmd = new MySqlCommand(req, DBConnection.con);
           if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
               return true;
           return false;
       }
       // saving the Ordination to the database 
       public bool Save()
       {
           if (!this.isExist())
           {
               req = "INSERT INTO fgm_ordination VALUES("
                   + this.id + ",'" +
                   this.pastor.getCode() + "','" +
                   this.OrdinationDate + "', '" +
                   this.grade + "')";
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
               req = "UPDATE fgm_ordination SET pastorConcernCode = '"
                   + this.pastor.getCode() + "', ordinationDate = '" +
                   this.OrdinationDate + "', grade  = '" +
                   this.grade + "' WHERE id = '" + this.id + "')";
               cmd = new MySqlCommand(req, DBConnection.con);
               cmd.ExecuteNonQuery();
               return true;
           }
           return false;
       }


    }
}
