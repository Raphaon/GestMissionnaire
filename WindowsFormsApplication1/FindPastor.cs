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
    public partial class FindPastor : Form
    {
        public FindPastor()
        {
            InitializeComponent();
        }

        private void FindPastor_Load(object sender, EventArgs e)
        {
            cmb_area.Items.Clear();
            cmb_district.Items.Clear();
            List <Pastor> pastors = appFunctions.getPastors();
            List<Area> areas = appFunctions.getAreaList();
            int numOrder = 1;
            foreach (Pastor pst in pastors)
            {
                dataGridView1.Rows.Add(numOrder, pst.getMatricule(), pst.getName() + " " + pst.getSurname(), pst.getDateOfBirth(), pst.getPastorPlaceOfBirth(), pst.getTels(), pst.getEmail());
                numOrder++;
            }
            cmb_area.Items.Add("All");
            cmb_area.Text = "All";

            foreach (Area are in areas)
            {
                cmb_area.Items.Add(are.getCode() + "-" + are.getName());
            }
            List<District> districts = appFunctions.getDistrictList();
            cmb_district.Items.Add("All");
            foreach (District dist in districts)
            {
                cmb_district.Items.Add(dist.getCode() + '-' + dist.getName());
            }
        }

        private void Cmb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area region =  appFunctions.getAreaByCode(cmb_area.Text.Split('-')[0]);
            List<District> dists = region.getDistrict();
            cmb_district.Items.Clear();
            cmb_district.Text = "All";
            cmb_area.Items.Add("All");
            Cmb_district_SelectedIndexChanged(sender, e);
            foreach (District dist in dists)
            {
                cmb_district.Items.Add(dist.getCode() + "-" + dist.getName());
            }
            
        }

        private void Cmb_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_church.Items.Clear();
            cmb_church.Text = "";
            District dist = appFunctions.getDistrictByCode(cmb_district.Text.Split('-')[0]);
            List<Church>  churchs = dist.getChurchOfDistrict();
            string codeDistrict = cmb_district.Text.Split('-')[0];
            foreach (Church ch in churchs)
            {
                cmb_church.Items.Add(ch.getCode() + '-' + ch.getName());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
