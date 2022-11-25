using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araweth
{
    public partial class frmComingSoon : Form
    {
        bool musicOn;

        public frmComingSoon()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbs.sp.Stop();
            



        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            gbs.sp.PlayLooping();
            

        }


    }
}
