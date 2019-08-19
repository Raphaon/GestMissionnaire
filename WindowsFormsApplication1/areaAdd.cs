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
    public partial class areaAdd : Form
    {
        public areaAdd()
        {
            InitializeComponent();
        }

        private void areaAdd_Load(object sender, EventArgs e)
        {
            
            List<Church> churchs = new List<Church>();
           churchs = appFunctions.getChurchList();
            foreach (Church church in churchs)
            {
                cmb_areaBase.Items.Add(church.getCode() + "-" + church.getName());   
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Tb_areaName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
