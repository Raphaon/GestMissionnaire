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
    public partial class newPastor : Form
    {
        public newPastor()
        {
            InitializeComponent();
        }
        private string matricule;
        private string name;
        private string surname;
        private string dateOfBirth;
        private string tels;
        private string email;
        private string country;
        private string conversionDate;
        private string professionBeforeBibleschool;
        private string gender;
        private string areaOfCall;
        private string martialStatus;
        private int numberYearInArea;
        private int numberYearDistrict;
        private string rankProbation="";
        private string pastorMotherName;
        private string pastorFotherName;
        private string pastorAdresse;
        private string pastorPlaceOfBirth;
        private string picture ="Nonepng";
        private int isActif = 1;
        private string raisonIndisp = "RAS";
        private int isDelete = 0;
        private string req;
        private int id = appFunctions.getPastorNumber();
        


        private void newPastor_Load(object sender, EventArgs e)
        {
            
            
            List<Area> areas = appFunctions.getAreaList();
            foreach(Area region in areas)
            {
                cmb_area_list.Items.Add(region.getCode() + "-" + region.getName());
            }
            for (int i = 0; i < 65; i++) 
            {
                cmb_nomberyearArea.Items.Add(i);
                cmb_numberYearDistrict.Items.Add(i);
            }

          
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (
                cmb_area_list.Text != "" &&
                cmb_district_list.Text != "" &&
                tb_matricule_pastor.Text != "" &&
                tb_pastorName.Text != "" &&
                tb_pastorSurname.Text != "" &&
                tb_pastorProfession.Text != "" &&
                tb_pastorMotherNames.Text != "" &&
                tb_PastorFatherNames.Text != "" &&
                tb_pastorPlaceOfbirth.Text != "" &&
                dtP_pastorBirthDate.Value != null &&
                cmb_country_pastor.Text !="" &&
                dtp_PastorConversionDate.Value != null
              )
            {
                
                this.matricule = tb_matricule_pastor.Text;
                this.name = tb_pastorName.Text;
                this.surname = tb_pastorSurname.Text;
                this.professionBeforeBibleschool = tb_pastorProfession.Text;
                this.dateOfBirth = dtP_pastorBirthDate.Value.ToString("yyyy-MM-dd");
                this.email = tb_pastorEmail.Text;
                this.pastorAdresse = tb_pastorAdresse.Text;
                this.gender = cmbGender.Text;
                this.country = cmb_country_pastor.Text;
                this.numberYearDistrict = Convert.ToInt32(cmb_numberYearDistrict.Text);
                this.numberYearInArea = Convert.ToInt32(cmb_nomberyearArea.Text);
                MessageBox.Show("Area : " + numberYearInArea + " District : " + numberYearDistrict);
                if(chkb_pastor_rank_probation_full.Checked == true){rankProbation = rankProbation + "Full Time";}
                if(chkb_pastor_rank_probation_inObervation.Checked ){rankProbation = rankProbation + "-- In Observation" ;}
                if(chkb_pastor_rank_probation_ordain.Checked){ rankProbation = rankProbation + "-- Ordained";}
                if(rankProbation =="")
                {
                    MessageBox.Show("Please choise a rank probation");
                }
               if (tb_pastor_tel1.Text != "") { this.tels = this.tels + tb_pastor_tel1CodePos.Text + tb_pastor_tel1.Text; }
               if (tb_pastor_tel2.Text != "") { this.tels = this.tels + "--- "+ tb_pastor_tel2CodePos.Text + tb_pastor_tel2.Text; }
               if (tb_pastor_tel3.Text != "") { this.tels = this.tels +"---"+ tb_pastor_tel3CodePos.Text + tb_pastor_tel3.Text; }
                if(this.tels==""){MessageBox.Show("Please Fill your Phone Number ") ;}
                this.pastorFotherName = tb_PastorFatherNames.Text;
                this.pastorMotherName = tb_pastorMotherNames.Text ;
                this.pastorPlaceOfBirth  = tb_pastorPlaceOfbirth.Text ;


                this.conversionDate = dtp_PastorConversionDate.Value.ToString("yyyy-MM-dd");
                if(brad_martialSia_single.Checked) { this.martialStatus = "Single" ;}
                if(brad_martialSia_married.Checked) { this.martialStatus = "Married" ;}
                if(brad_martialSia_widower.Checked) { this.martialStatus = "Widower "; }
                if(brad_martialSia_divorced.Checked) { this.martialStatus = "Divorced "; }
                if(chkb_AreaCallEvang.Checked){ areaOfCall = areaOfCall + "Evangeliste-";}
                if(chkb_AreaCallPastor.Checked) {areaOfCall = areaOfCall + "Pastor - "; }
                if(chkb_AreaCallProphet.Checked) { areaOfCall = areaOfCall + "Prophet-"; }
                if(chkb_AreaCallTeacher.Checked) {areaOfCall = areaOfCall + "Teacher - "; }
                if(chkb_AreaCall_Apostle.Checked) { areaOfCall = areaOfCall + "Apostle - ";}
                if(tb_OtherAreaOfCall.Text != ""){areaOfCall = areaOfCall + tb_OtherAreaOfCall.Text; }
                if(this.Save() ) { MessageBox.Show("Pasteur ajoute avec success !! "); newPastor_Load(sender, e) ;}
                this.country = cmb_country_pastor.Text;
                

            }
            else 
            
            {
                MessageBox.Show("Veuillez renseigner tous les champs obligatoires");
            
            }
        }
        public bool isExist() 
        {
            req = "SELECT COUNT(matriculePastor) FROM fgm_pastor WHERE matriculePastor = '" + this.matricule + "' ";
            MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Save() 
        {
            if (!this.isExist())
            {
                id++;
                req = "INSERT INTO fgm_pastor" +
                    "(matriculePastor, " +
                    "pastorName," +
                    " pastorSurname, " +
                    "pastorBirthdayDate ," +
                    "birthdayPlace," +
                    " pastorFathername," +
                    " pastorMothername," +
                    " pastorSexe," +
                    " pastorPhone," +
                    " pastorEmail," +
                    " dateConversion," +
                    " workBeforeBibleSchool," +
                    " rankProbation," +
                    " areaOfCalling," +
                    " nberYearArea," +
                    " nbreYearDistrict" +
                    ", martialSituation," +
                    " nationality," +
                    " pastorAdresse," +
                    " photoProfil," +
                    " raisonIndispoMissionnaire, id) VALUES('"
                    + this.matricule +
                    "','" + this.name +
                    "','" + this.surname + 
                    "','" + this.dateOfBirth + 
                    "','" + this.pastorPlaceOfBirth + 
                    "','" + this.pastorFotherName +
                    "','" + this.pastorMotherName + 
                    "','" + this.gender +
                    "','" + this.tels +
                    "','" + this.email +
                    "','" + this.conversionDate +
                    "','" + this.professionBeforeBibleschool +
                    "','" + this.rankProbation +
                    "','" + this.areaOfCall +
                    "'," + this.numberYearInArea +
                    "," + this.numberYearDistrict + 
                    ",'" + this.martialStatus + 
                    "','" + this.country +
                    "','" + this.pastorAdresse +
                    "','" + this.picture + 
                    "','" + this.raisonIndisp +
                    "'," + this.id + ")";
                MessageBox.Show(req);
                MySqlCommand cmd = new MySqlCommand(req, DBConnection.con);
                        cmd.ExecuteNonQuery();
                

                return true;
            }
            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           // tb_areaCode.Text =  GlobalVariables.tmp_area.getCode();
            FindArea fA = new FindArea();
            fA.Show();
            timer1.Start();
           
            
        }

       

       

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_area_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<District> districts = new  List<District>();
            string[] areaInfo = cmb_area_list.Text.ToString().Split('-');
           Area regi = appFunctions.getAreaByCode(areaInfo[0]);
            districts = regi.getDistrict();
            cmb_district_list.Items.Clear();
            cmb_district_list.Text = "";
            tb_matricule_pastor.Text = "";
            foreach(District dist in districts)
            {
                cmb_district_list.Items.Add(dist.getCode() + '-' + dist.getName());
            };
 
        }

        private void cmb_district_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int  datejour = DateTime.Now.Year;
            string pastorMatricule =cmb_district_list.Text.ToString().Split('-')[0]+ datejour+appFunctions.getPastorNumber().ToString();
            tb_matricule_pastor.Text = pastorMatricule;



        }

        private void cmb_area_list_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cmb_area_list_SelectedIndexChanged(sender, e);
        }

        private void label21_Click(object sender, EventArgs e)
        {
             openFileDialog1.Title = "Choise a the pastor picture "; 
             openFileDialog1.ShowDialog();
             this.picture = openFileDialog1.FileName;
             openFileDialog1.OpenFile();
             pictureBox1.Width = 300;
             pictureBox1.Height = 300;
             pictureBox1.Load(this.picture);
             MessageBox.Show(picture);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       
    }
}
