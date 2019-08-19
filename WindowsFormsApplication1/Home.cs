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
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.nbreFormActive < 1)
            {
                newPastor newPastorForm= new newPastor();
                newPastorForm.Show();
            }
            else
            {
                this.Focus();
                
            }

            
            


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            areaFormAdd areaForm = new areaFormAdd();
            GlobalVariables.nbreFormActive++;
            areaForm.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPastor findPastor;
            findPastor = new FindPastor();
            findPastor.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void affectationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastorFormTransfer affectationForm = new PastorFormTransfer();
            affectationForm.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutApp aboutPages = new AboutApp();
            aboutPages.Show();
        }

        private void ordiantionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdinationForm ordinationF = new OrdinationForm();
            ordinationF.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupervisorForm supervisorForm = new AddSupervisorForm();
            supervisorForm.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            btn_total_Area.Text = "Total Area  : " + appFunctions.getAreaNumber();
            btn_total_church.Text = "Total Church : " + appFunctions.getDistrictNumber();
            btn_total_District.Text = "Total District : " + appFunctions.getDistrictNumber();
            btn_total_Pastor.Text = "Total Pastor : " + appFunctions.getPastorNumber();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            districtsAddForm districtForm = new districtsAddForm();
            districtForm.Show();
        }

        private void RetraiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leavingForm leavingForm = new leavingForm();
            leavingForm.Show();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addTrainning addtrain = new addTrainning();
            addtrain.Show();
        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formAddChurch addChurchForm = new formAddChurch();
            addChurchForm.Show();
        }
    }
}
