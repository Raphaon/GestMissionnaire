using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class addTrainning : Form
    {
        public addTrainning()
        {
            InitializeComponent();
        }

        private void AddTrainning_Load(object sender, EventArgs e)
        {
            List<Area> areas = new List<Area>();
            List<District> dists = new List<District>();
            areas = appFunctions.getAreaList();
            cmb_Area.Items.Clear();

            foreach (Area region in areas)
            {
                cmb_Area.Items.Add(region.getCode() + "-" + region.getName());
            }
        }

        private void Cmb_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area region = new Area();
            region = appFunctions.getAreaByCode(cmb_Area.Text.Split('-')[0]);
            List<District> dists = new List<District>();
            dists = region.getDistrict();
            cmb_district.Items.Clear();
            cmb_district.Text = "";
            foreach (District dist in dists)
            {
                cmb_district.Items.Add(dist.getCode() + "-" + dist.getName());
            }
            Cmb_district_SelectedIndexChanged(sender, e);
            
        }

        private void Cmb_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_church.Items.Clear();
            cmb_church.Text = "";
            List<Church> churchs = new List<Church>();
            District dist = appFunctions.getDistrictByCode(cmb_district.Text.Split('-')[0]);
            churchs = dist.getChurchOfDistrict();
            string codeDistrict = cmb_district.Text.Split('-')[0];
            foreach (Church ch in churchs)
            {
                cmb_church.Items.Add(ch.getCode() + '-' + ch.getName());
            }
            Cmb_church_SelectedIndexChanged(sender, e);
        }

        private void Cmb_church_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_pastor.Text = "";
            cmb_pastor.Items.Clear();

            string churchCode = cmb_church.Text;
            churchCode = churchCode.Split('-')[0];
            List<Pastor> pastors = appFunctions.getPastorByChurchCode(churchCode);
            foreach (Pastor pst in pastors)
            {
                cmb_pastor.Items.Add(pst.getCode() + '-' + pst.getName());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Trainning train = new Trainning();
            train.setPastorConcern(appFunctions.getPastorByCode(cmb_pastor.Text.Split('-')[0]));
            train.setStartDate(dtp_TrainDateStart.Value.ToString("yyyy-MM-dd"));
            train.setEndDate(dtp_trainDateEnd.Value.ToString("yyyy-MM-dd"));
            train.setCode(train.getPastorConcern().getCode() + "-" + train.getStartDate() + train.getEndDate());
            train.setInstitutName(tb_trainName.Text);
            train.setQualification(tb_trainGrade.Text);
            train.setTypeOftrainning(cmb_typeOfTrain.Text);
            if (train.Save())
            {
                MessageBox.Show("Formation Enregistrer avec success !!","information");
                AddTrainning_Load(sender, e);
            }
            else
            {
                MessageBox.Show("We encounter and error while tring to add that trainning ! ", "Error");
            }
        }
    }
}
