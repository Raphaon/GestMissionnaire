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
    public partial class FindArea : Form
    {
        public FindArea()
        {
         
            InitializeComponent();
             
        }
        public string testVAr = "Min tes areuss i : ";
        

       

        private void FindArea_Load(object sender, EventArgs e)
        {
          
            List<Area> areas = new List<Area>();
            areas = appFunctions.getAreaList();
            foreach(Area a in areas)
            {
                dataGridView1.Rows.Add(a.getCode(), a.getName(), a.getCity());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            
           string  code = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
            string city = dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
            /*GlobalVariables.tmp_area.setCode(code);
            GlobalVariables.tmp_area.setName(name);
            GlobalVariables.tmp_area.setCity(city);
            */
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string code = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
            string city = dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
           /*   GlobalVariables.tmp_area.setCode(code);
                GlobalVariables.tmp_area.setName(name);
                GlobalVariables.tmp_area.setCity(city);
            */
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            leavingForm.test = "Mon test à reussi ! ";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
