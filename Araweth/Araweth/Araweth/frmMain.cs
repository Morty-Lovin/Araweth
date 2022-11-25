using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Araweth
{

    public partial class frmMain : Form
    {


        
        //public string strClass;
        UserInfo ui = new UserInfo();
        frmBattle fb = new frmBattle();

        public frmMain()
        {
            InitializeComponent();
        }

        //button clicks



        private void btnNewGame_Click(object sender, EventArgs e)
        {
            gbs.continueSave = false;
            ShowClassSelection();
        }

        private void btnContinueSave_Click(object sender, EventArgs e)
        {

            List<string> load = File.ReadLines(@"..\..\resources\Save.txt").ToList();

            gbs.strUserName = load[9];

            if (load[9] == "0" || load[9] == "")
            {

                lblError.Text = "You do not currently have a save file.";

                pnlError.Show();

            }
            else
            {
                gbs.continueSave = true;

                

                ShowClassSelection();
            }

        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {

            ShowClassSelection();

            lvwHigh.Items.Clear();

            ScoresIn();

            pnlHigh.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {

            ShowKnightAbilities();

        }

        private void btnMage_Click(object sender, EventArgs e)
        {

            ShowMageAbilities();

        }

        private void btnArcher_Click(object sender, EventArgs e)
        {

            ShowArcherAbilities();

        }

        private void btnPaladin_Click(object sender, EventArgs e)
        {

            ShowPaladinAbilities();

        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            gbs.continueSave = true;
            ShowMainMenu();

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            frmInstructs fi = new frmInstructs();

            fi.Show();
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            ShowMainMenu();

            pnlHigh.Hide();

        }

        //Methods

        private void ShowClassSelection()
        {
            btnInstructions.Hide();
            pictureBox1.Hide();
            lblMainMenu.Hide();
            btnOptions.Hide();
            btnNewGame.Hide();
            btnContinueSave.Hide();
            btnHighScores.Hide();
            btnExit.Hide();

            lblSelectClass.Show();
            btnKnight.Show();
            btnMage.Show();
            btnArcher.Show();
            btnPaladin.Show();
            btnReturnMain.Show();

        } //hides main and shows class selection menu

        public void ShowMainMenu()
        {

            lblSelectClass.Hide();
            btnKnight.Hide();
            btnMage.Hide();
            btnArcher.Hide();
            btnPaladin.Hide();
            btnReturnMain.Hide();

            btnInstructions.Show();
            pictureBox1.Show();
            btnOptions.Show();
            lblMainMenu.Show();
            btnNewGame.Show();
            btnContinueSave.Show();
            btnHighScores.Show();
            btnExit.Show();

        }   //hides class selection menu and returns to main menu

        private void ShowKnightAbilities()
        {
            frmClass knight = new frmClass();

            if (gbs.continueSave == true)
            {
                knight.tbxUserName.Text = gbs.strUserName;
            }

            gbs.strClass = "knight";

            

            Hide();
            knight.Show();

            knight.pbxClassImage.Image = Properties.Resources.knightReal;
            knight.lblClassName.Text = "KNIGHT";
            knight.lblSkill1.Text = "Slash\nPerform a quick slash at the enemy. Cooldown (0)";
            knight.lblSkill2.Text = "Block\nBlock the next incoming attack. Cooldown (2)";
            knight.lblSkill3.Text = "Spinning Blade\nWhirl around with your sword, hitting 3 times. Cooldown (4)";
            knight.lblSkill4.Text = "Sky Fall\nCall down a sword from the sky. Cooldown (8)";

        }//show knight abilities in new Class form

        private void ShowMageAbilities()
        {
            frmClass mage = new frmClass();

            if (gbs.continueSave == true)
            {
                mage.tbxUserName.Text = gbs.strUserName;
            }

            gbs.strClass = "mage";

            

            Hide();
            mage.Show();

            mage.pbxClassImage.Image = Araweth.Properties.Resources.mageReal;
            mage.lblClassName.Text = "MAGE";
            mage.lblSkill1.Text = "Fire Bolt\nSummon a ball of fire. \nCooldown (0)";
            mage.lblSkill2.Text = "Barrier\nBlock the next incoming attack. Cooldown (2)";
            mage.lblSkill3.Text = "Fire Storm\nBombard the enemy with flames. Cooldown (5)";
            mage.lblSkill4.Text = "Inferno\nWrap the enemy in a storm of fire. Cooldown (9)";

        }//show mage abilities in new Class form

        private void ShowArcherAbilities()
        {
            frmClass archer = new frmClass();

            if (gbs.continueSave == true)
            {
                archer.tbxUserName.Text = gbs.strUserName;
            }

            gbs.strClass = "archer";

            

            Hide();
            archer.Show();

            archer.pbxClassImage.Image = Araweth.Properties.Resources.archerReal;
            archer.lblClassName.Text = "ARCHER";
            archer.lblSkill1.Text = "Quickshot\nFire an quick arrow at the enemy. Cooldown (0)";
            archer.lblSkill2.Text = "Roll\nDodge the next incoming attack. Cooldown (2)";
            archer.lblSkill3.Text = "Hail of Arrows\nFire arrows to rain down on the enemy. Cooldown (5)";
            archer.lblSkill4.Text = "Snipe\nFocus your skills to unleash a powerful arrow. Cooldown (9)";

        }//show archer abilities in new Class form

        private void ShowPaladinAbilities()
        {
            frmClass paladin = new frmClass();

            if (gbs.continueSave == true)
            {
                paladin.tbxUserName.Text = gbs.strUserName;
            }

            gbs.strClass = "paladin";

            

            Hide();
            paladin.Show();

            paladin.pbxClassImage.Image = Araweth.Properties.Resources.paladinReal;
            paladin.lblClassName.Text = "PALADIN";
            paladin.lblSkill1.Text = "Bash\nUse your hammer to strike the enemy. Cooldown (0)";
            paladin.lblSkill2.Text = "Devine Blessing\nPerform a small heal on yourself. Cooldown (12)";
            paladin.lblSkill3.Text = "Over Heal\nHeal to full health. Cooldown (30)";
            paladin.lblSkill4.Text = "Justice\nServe Justice to the enemy. Cooldown (6)";

        }//show paladin abilities in new Class form



        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlError.Hide();
        }



        private void ScoresIn()
        {
            List<string> data = File.ReadAllLines(@"..\..\resources\highscore.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' });

                lvwHigh.Items.Add(new ListViewItem(items));
            }

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmComingSoon fcs = new frmComingSoon();

            fcs.ShowDialog();
        }
    }
}