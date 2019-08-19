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
    public partial class leavingForm : Form
    {
        public static string test = "dfsdfsdf";

        public leavingForm()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FindArea fa = new FindArea();
            fa.Show();
        }

        private void LeavingForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = test;
        }
    }
}
