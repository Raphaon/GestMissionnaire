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
    public class pastorTransfer
    {
        private Church churchTo;
        private Pastor pastor;
        private string startDate;
        private  string transferDate;
        private string OccupationPosition;
        private string statusTransfer;
        private int id;


        private MySqlCommand cmd;
        private MySqlDataReader dr;
        private string req;
        public bool doTransfer()
        {
            id = appFunctions.getTransferNumber();
            id++;
            if(this.pastor != null && this.churchTo != null)
            {

                req = "UPDATE fgm_pastor_transfer SET statusTransfert = 'END' WHERE mleTransferedPastor ='"+ this.pastor.getCode()+"' and statusTransfert = 'Encours' ";
                cmd = new MySqlCommand(req, DBConnection.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(churchTo.getCode());
                req = "INSERT INTO fgm_pastor_transfer VALUES('"
                    + this.churchTo.getCode() +"','"+
                    this.pastor.getCode()+"','"+
                    this.transferDate+"','"+
                    this.startDate+"','"+
                    this.OccupationPosition+"','"+
                    this.statusTransfer+"',"+
                    this.id+" )";
                cmd = new MySqlCommand(req, DBConnection.con);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }


        public Church getChurchTo()
        {
            return this.churchTo;
        }

        public void setChurchTo(Church churchTo)
        {
            this.churchTo = churchTo;
        }

        public Pastor getPastor()
        {
            return this.pastor;
        }

        public void setPastor(Pastor pastor)
        {
            this.pastor = pastor;
        }

        public string getStartDate()
        {
            return this.startDate;
        }

        public void setStartDate(string startDate)
        {
            this.startDate = startDate;
        }

        public string getTransferDate()
        {
            return this.transferDate;
        }

        public void setTransferDate(string transferDate)
        {
            this.transferDate = transferDate;
        }

        public string getOccupationPosition()
        {
            return this.OccupationPosition;
        }

        public void setOccupationPosition(string OccupationPosition)
        {
            this.OccupationPosition = OccupationPosition;
        }

        public string getStatusTransfer()
        {
            return this.statusTransfer;
        }

        public void setStatusTransfer(string statusTransfer)
        {
            this.statusTransfer = statusTransfer;
        }


        //UpDating a transfer 

        public bool Update() 
        {
            req = "UPDATE fgm_pastor_transfer SET codeStationTransfer = '"
                   + this.churchTo.getCode() + "', mleTransferedPastor = '" +
                   this.pastor.getCode() + "', dateTransfert  = '" +
                   this.transferDate + "', startDate = '" +
                   this.startDate + "', occupationPosition ='"+
                   this.OccupationPosition+"', statusTransfert ='"+
                   this.statusTransfer+"' WHERE id = '" + this.id + "')";
            cmd = new MySqlCommand(req, DBConnection.con);
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
