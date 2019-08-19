using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;    
namespace WindowsFormsApplication1
{
    public partial class areaFormAdd : Form
    {
        
        public areaFormAdd()
        {
            InitializeComponent();
        }

        Area myarea = new Area();

        
      
     
        

        private void button1_Click(object sender, EventArgs e)
        {
           if (tb_areaName.Text == "" && tb_areaName.TextLength>2)
            {
                MessageBox.Show("the name of an area must containt at least 03 character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                myarea.generateAreaCode(tb_areaName.Text);
                myarea.setName(tb_areaName.Text);
                myarea.setCity(cb_areaTown.Text);
                myarea.setCode(tb_areaCode.Text);
                MessageBox.Show(myarea.getCode());
                if (myarea.Save()) { MessageBox.Show("Opération reussi !", "Success !",MessageBoxButtons.OK,  MessageBoxIcon.Information); } else { MessageBox.Show("Erreur Lors de l'operation !!","Echec de L'opération ", MessageBoxButtons.OK, MessageBoxIcon.Error); MessageBox.Show("Mon code : " + myarea.getCode()); }
               
          
                area_Load(sender, e);
            }
        }

        private void tb_areaName_TextChanged(object sender, EventArgs e)
        {
            if (tb_areaName.TextLength > 2) 
            tb_areaCode.Text = myarea.generateAreaCode(tb_areaName.Text);
        }

        private void area_Load(object sender, EventArgs e)
        {

            cmb_areaBase.Text = "";
            tb_areaCode.Text = "";
            cb_areaTown.Text = "";
            tb_areaName.Text = "";
            dataGridView1.Rows.Clear();
            cmb_areaBase.Items.Clear();
            List<Church> churchs = new List<Church>();
            List<Area> areas = new List<Area>();
            areas = appFunctions.getAreaList();
            churchs = appFunctions.getChurchList();
            foreach (Church chu in churchs) 
            {
                cmb_areaBase.Items.Add(chu.getCode() + '-' + chu.getName());
            }

            foreach (Area area in areas)
            {
                dataGridView1.Rows.Add(area.getCode(), area.getName(), area.getCity());

            }
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
