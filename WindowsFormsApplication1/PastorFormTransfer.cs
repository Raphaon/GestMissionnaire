using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class PastorFormTransfer : Form
    {
        public PastorFormTransfer()
        {
            InitializeComponent();
        }

        private void PastorFormTransfer_Load(object sender, EventArgs e)
        {
            
            List<Area> areas = new List<Area>();
            List<District> dists = new List<District>();
            areas = appFunctions.getAreaList();
            cmb_tranferArea.Items.Clear();

            foreach (Area region in areas) 
            {
                cmb_tranferArea.Items.Add(region.getCode() +"-"+ region.getName());
                cmb_AreaTo.Items.Add(region.getCode() +"-"+ region.getName());
            }
            
        }

        private void cmb_tranferArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area region = new Area();
            region = appFunctions.getAreaByCode(cmb_tranferArea.Text.Split('-')[0]);
            List<District> dists = new List<District>();
            dists = region.getDistrict();
            cmb_tranferDistrict.Items.Clear();
            cmb_tranferDistrict.Text = "";
            foreach (District dist in dists)
            {
                cmb_tranferDistrict.Items.Add(dist.getCode() + "-" + dist.getName());
            }
            cmb_tranferDistrict_SelectedIndexChanged(sender, e);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_pastorConcer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_AreaTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Area region = new Area();
            region = appFunctions.getAreaByCode(cmb_AreaTo.Text.Split('-')[0]);
            List<District> dists = new List<District>();
            dists = region.getDistrict();
            cmb_DistrictTo.Items.Clear();
            cmb_DistrictTo.Text = "";
            cmb_churchTo.Text = "";
            cmb_churchTo.Items.Clear();
            foreach (District dist in dists)
            {
                cmb_DistrictTo.Items.Add(dist.getCode() + "-" + dist.getName());
            }
        }

        

        private void cmb_tranferDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmb_churchFrom.Items.Clear();
            cmb_churchFrom.Text = "";
            List<Church> churchs = new List<Church>();
            District dist = appFunctions.getDistrictByCode(cmb_tranferDistrict.Text.Split('-')[0]); 
            churchs = dist.getChurchOfDistrict();
            string codeDistrict = cmb_tranferDistrict.Text.Split('-')[0];
            foreach (Church ch in churchs)
            {
                cmb_churchFrom.Items.Add(ch.getCode() + '-' + ch.getName());
            }
            
        }

        private void cmb_DistrictTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_churchTo.Items.Clear();
            cmb_churchTo.Text = "";
            List<Church> churchs = new List<Church>();
            District dist = appFunctions.getDistrictByCode(cmb_DistrictTo.Text.Split('-')[0]);
            churchs = dist.getChurchOfDistrict();
            string codeDistrict = cmb_DistrictTo.Text.Split('-')[0];
            foreach (Church ch in churchs)
            {
                cmb_churchTo.Items.Add(ch.getCode() + '-' + ch.getName());
            }
        }

        private void cmb_tranferDistrict_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_tranferDistrict_SelectedIndexChanged(sender, e);
        }

        private void cmb_churchFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string churchCode = cmb_churchFrom.Text;
            churchCode = churchCode.Split('-')[0];
            List<Pastor>  pastors = appFunctions.getPastorByChurchCode(churchCode);
            foreach(Pastor pst in pastors)
            {
                cmb_churchPastor.Items.Add(pst.getCode() + '-' + pst.getName());
            }
   
        }

        private void cmb_DistrictTo_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_DistrictTo_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pastorTransfer transfer = new pastorTransfer();
            transfer.setChurchTo(new Church());
            transfer.getChurchTo().setCode(cmb_churchTo.Text.Split('-')[0]);
            transfer.setPastor(new Pastor());
            transfer.getPastor().setMatricule(cmb_churchPastor.Text.Split('-')[0]);
            transfer.setStartDate(dtp_dateEffet.Value.ToString("yyyy-MM-dd"));
            transfer.setTransferDate(dtp_dateOfTransfer.Value.ToString("yyyy-MM-dd"));
            transfer.setStatusTransfer("Encours");
            transfer.setOccupationPosition(cmb_pastorPosition.Text);
            if (transfer.doTransfer())
            {
                MessageBox.Show("Opération effectué avec succes !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PastorFormTransfer_Load(sender, e);
            }
           

        }

        private void Cmb_churchPastor_SelectedIndexChanged(object sender, EventArgs e)
        {
                //tb_oldPosition = appFunctions.getPastorByCode(cmb_churchPastor.Text.Split('-')[0]).getCode5;
        }

        private void Tb_code_trasfer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
