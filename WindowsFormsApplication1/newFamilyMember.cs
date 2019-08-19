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
    public partial class newFamilyMember : Form
    {
        public newFamilyMember()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FindArea fa = new FindArea();
            fa.Show();
            fa.testVAr = "ici mon test";
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
