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
using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public partial class districtsAddForm : Form
    {
        private string name;
        private string code;
        private string codeArea;
        private int isDelete = 0;
        public districtsAddForm()
        {
            InitializeComponent();
        }

        public string Name1 { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string CodeArea { get => codeArea; set => codeArea = value; }
        public int IsDelete { get => isDelete; set => isDelete = value; }
        District dist = new District();
        private void DistrictsAddForm_Load(object sender, EventArgs e)
        {
            List<Area> areas = appFunctions.getAreaList();
            cmb_area.Items.Clear(); 
            foreach (Area area in areas)
            {
                cmb_area.Items.Add(area.getCode()+"-"+ area.getName());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (tb_districtName.Text == "" || tb_districtName.TextLength < 2)
            {
                MessageBox.Show("Veuillez remplier les champs obligatoires !! ");
                tb_districtName.Focus();
               
            }
            else if(tb_district_Code.Text =="")
            {
               
            }else if(cmb_area.Text == "")
            {
                MessageBox.Show("Veuillez remplier les champs obligatoires !! ");
                cmb_area.Focus();
            }
            else
            {
                dist.setName(tb_districtName.Text);
                dist.setCodeArea(cmb_area.Text.Split('-')[0]);
                if (dist.Save()) { MessageBox.Show("Enregistrement reussi !"); }
                else { MessageBox.Show("Echec  de l'opération "); }
            }
            
        }

        private void Cmb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Tb_districtName_TextChanged(object sender, EventArgs e)
        {
            if (tb_districtName.TextLength >= 2)
            {
                dist.setCodeArea(cmb_area.Text.Split('-')[0]);
                dist.setCode(dist.generateDistrictCode(tb_districtName.Text));
                tb_district_Code.Text = dist.getCode();
            }
        }
    }
}
