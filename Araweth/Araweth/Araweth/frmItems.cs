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
    public partial class frmItems : Form
    {
        frmBattle fb = new frmBattle();

        public frmItems()
        {
            InitializeComponent();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (lbxItems.SelectedIndex == 0)
            {

                fb.SmallPot();
                Hide();

            }
            else if (lbxItems.SelectedIndex == 1)
            {

                fb.LargePot();
                Hide();
            }



            else if (lbxItems.SelectedIndex == 2)
            {

                fb.Life();
                Hide();
            }
            else if (lbxItems.SelectedIndex == 3)
            {
                if (fb.playerStatusCount != 0)
                {

                    MessageBox.Show("Only one status can be applied at one time.", "Status Overload)");

                }
                else
                {
                    fb.Speed();
                    Hide();
                }
            }
            else if (lbxItems.SelectedIndex == 4)
            {
                if (fb.playerStatusCount != 0)
                {

                    MessageBox.Show("Only one status can be applied at one time.", "Status Overload)");

                }
                else
                {
                    fb.Luck();
                    Hide();
                }
            }
            else if (lbxItems.SelectedIndex == 5)
            {
                if (fb.enemyStatusCount != 0)
                {

                    MessageBox.Show("Only one status can be applied at one time.", "Status Overload)");

                }
                else
                {
                    fb.Damned();
                    Hide();
                }
            }
            else if (lbxItems.SelectedIndex == 6)
            {

                if (fb.enemyStatusCount != 0)
                {

                    MessageBox.Show("Only one status can be applied at one time.", "Status Overload)");

                }
                else
                {
                    fb.Curse();
                    Hide();
                }
            }
            else if (lbxItems.SelectedIndex == 7)
            {

                if (fb.enemyStatusCount != 0)
                {

                    MessageBox.Show("Only one status can be applied at one time.", "Status Overload)");

                }
                else
                {
                    fb.Poison();
                    Hide();
                }
            }
            else if (lbxItems.SelectedIndex == 8)
            {
                if (fb.playerStatusCount != 0)
                {

                    MessageBox.Show("Only one status can be applied at one time.", "Status Overload)");

                }
                else
                {
                    fb.Hammer();
                    Hide();
                }
            }
        }

        private void Counts()
        {

            lblSmPotCount.Text = gbs.Small_Potion.ToString();
            lblLgPotCount.Text = gbs.Large_Potion.ToString();
            lblFullHpCount.Text = gbs.Font_of_Life.ToString();
            lblLuckCount.Text = gbs.Luck_Potion.ToString();
            lblSpeedCount.Text = gbs.Speed_Potion.ToString();
            lblPoisonCount.Text = gbs.Poison_Arrow.ToString();
            lblCursedCount.Text = gbs.Cursed_Bone.ToString();
            lblDamnedCount.Text = gbs.Sword_of_the_Damned.ToString();
            lblHammerCount.Text = gbs.Hammer_of_Retribution.ToString();

        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            Counts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
