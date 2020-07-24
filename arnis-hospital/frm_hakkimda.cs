using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arnis_hospital
{
    public partial class frm_hakkimda : Form
    {
        public frm_hakkimda()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Process.Start("http://denizartunaydin.com/");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/denizartunaydin");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/denizartunaydin/");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/denizartunaydin/");
        }
    }
}
