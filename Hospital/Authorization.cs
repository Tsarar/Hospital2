using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            People frm = new People();
            frm.Show();
        }

        private void bRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}
