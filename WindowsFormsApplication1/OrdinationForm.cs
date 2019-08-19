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
    public partial class OrdinationForm : Form
    {
        public OrdinationForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ordination ordination = new Ordination();
            if (tb_otherOrdination.Text == "" && cmb_grade.Text != "") { ordination.setGrade(cmb_grade.Text); }
            if(tb_otherOrdination.Text != "") { ordination.setGrade(tb_otherOrdination.Text); }
            if (tb_otherOrdination.Text == "" && cmb_grade.Text == "") { MessageBox.Show("Veuillez choisir un grade ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            ordination.setOrdinationDate(dtp_ordinationDate.Value.ToString("yyyy-MM-dd"));
            ordination.setPastor(appFunctions.getPastorByCode(cmb_pastor.Text.Split('-')[0]));
            if (ordination.Save()) { MessageBox.Show("Opération effectué avec succes !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdinationForm_Load(sender, e); }
        }

        private void OrdinationForm_Load(object sender, EventArgs e)
        {
            cmb_area.Items.Clear();
            cmb_church.Items.Clear();
            cmb_district.Items.Clear();
            cmb_pastor.Items.Clear();
            cmb_pastor.Text = "";
            cmb_grade.Text = "";
            cmb_church.Text = "";
            cmb_area.Text = "";
            cmb_district.Text = "";
            List<Area> areas  = appFunctions.getAreaList();
            foreach (Area region in areas)
            {
                cmb_area.Items.Add(region.getCode() + "-" + region.getName());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area region = new Area();
            region = appFunctions.getAreaByCode(cmb_area.Text.Split('-')[0]);
            List<District> dists = new List<District>();
            dists = region.getDistrict();
            cmb_district.Items.Clear();
            cmb_district.Text = "";
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
            List<Church> churchs =  dist.getChurchOfDistrict();
            string codeDistrict = cmb_district.Text.Split('-')[0];
            foreach (Church ch in churchs)
            {
                cmb_church.Items.Add(ch.getCode() + '-' + ch.getName());
            }
        }

        private void Cmb_church_SelectedIndexChanged(object sender, EventArgs e)
        {
            string churchCode = cmb_church.Text;
            churchCode = churchCode.Split('-')[0];
            List<Pastor> pastors = appFunctions.getPastorByChurchCode(churchCode);
            foreach (Pastor pst in pastors)
            {
                cmb_pastor.Items.Add(pst.getCode() + '-' + pst.getName());
            }
        }

        private void OrdinationForm_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
