using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {

            try
            {
                DBConnection.connect();
            if (!DBConnection.isConnect()) 
               {
                // menu.Enabled = false;
               }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex);
            }
            Home menu = new Home();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(menu);
            
        }
    }
}
