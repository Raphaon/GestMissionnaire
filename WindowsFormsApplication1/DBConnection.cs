using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
   public static class DBConnection
    {
       public static  MySqlConnection con;
        public static bool connect() 
        {
           
               try 
               {
                   con = new MySqlConnection("server=localhost;database=fgm_pastor_db; user id=root; pwd=");
                    if (con.State == ConnectionState.Closed) 
                    {
                         con.Open();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Erreur "+ex.Message);
                }
               
            return true;
        }

        public static bool isConnect() 
        {
                if (con.State == ConnectionState.Open)
                {
                    return true;
                }
                return false;          
        }

       
       
    }
}
