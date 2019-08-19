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
    public partial class AddSupervisorForm : Form
    {
        public AddSupervisorForm()
        {
            InitializeComponent();
        }

        private void AddSupervisorForm_Load(object sender, EventArgs e)
        {
            List<Area> areas = new List<Area>();
            areas = appFunctions.getAreaList();
            List<Pastor> pastors = new List<Pastor>();
            pastors = appFunctions.getPastors();
            foreach (Area area in areas)
            {
                cmb_area.Items.Add(area.getCode() + "-" + area.getName());
            }
            foreach (Pastor pastor in pastors)
            {
               cmb_supervisor.Items.Add(pastor.getCode()+"-"+pastor.getName());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Supervisor areaSupervisor = new Supervisor();
            areaSupervisor.setAreaSupervised(appFunctions.getAreaByCode(cmb_area.Text.Split('-')[0]));
            areaSupervisor.setNominationDate(dtp_nomination_date.Value.ToString("yyyy-MM-dd"));
            areaSupervisor.setPastor(appFunctions.getPastorByCode(cmb_supervisor.Text.Split('-')[0]));
            if (areaSupervisor.Save("area"))
            {
                MessageBox.Show("Opération reussi avec succes ! ");
            }
            else { MessageBox.Show("Une erreur est survenu lors de la validation ! "); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
