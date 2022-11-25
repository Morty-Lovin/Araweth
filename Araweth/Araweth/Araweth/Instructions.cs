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
    public partial class frmInstructs : Form
    {

        int pictureCounter = 0;

        public frmInstructs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureCounter++;

            if (pictureCounter == 1)
            {
                

                pictureBox1.Image = Properties.Resources.classSelection;

            }
            else if (pictureCounter == 2)
            {

               pictureBox1.Image = Properties.Resources.classView;

            }
            else if (pictureCounter == 3)
            {

                pictureBox1.Image = Properties.Resources.battleScreen;

            }
            else if (pictureCounter == 4)
            {

                pictureCounter = 0;

                pictureBox1.Image = Properties.Resources.items;

            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();

            fm.Show();
            Close();
        }
    }
}
