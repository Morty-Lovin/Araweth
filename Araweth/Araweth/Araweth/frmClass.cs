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

namespace Araweth
{
    public partial class frmClass : Form
    {


        public UserInfo ui = new UserInfo();

        public frmClass()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {


            ShowClassSelection();

        }

        private void ShowClassSelection()
        {
            frmMain fm = new frmMain();

            fm.Show();
            this.Hide();

            fm.btnInstructions.Hide();
            fm.lblMainMenu.Hide();
            fm.btnNewGame.Hide();
            fm.btnContinueSave.Hide();
            fm.btnHighScores.Hide();
            fm.btnExit.Hide();

            
            fm.lblSelectClass.Show();
            fm.btnKnight.Show();
            fm.btnMage.Show();
            fm.btnArcher.Show();
            fm.btnPaladin.Show();
            fm.btnReturnMain.Show();

        }



        private void Exit(object sender, FormClosingEventArgs e)
        {
            frmMain fm = new frmMain();

            fm.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //frmMain fm = new frmMain();
            frmBattle fb = new frmBattle();

            if (gbs.continueSave == true)
            {

                List<string> load = File.ReadLines(@"..\..\resources\Save.txt").ToList();

                gbs.Cursed_Bone = int.Parse(load[0]);
                gbs.Font_of_Life = int.Parse(load[1]);
                gbs.Hammer_of_Retribution = int.Parse(load[2]);
                gbs.Large_Potion = int.Parse(load[3]);
                gbs.Luck_Potion = int.Parse(load[4]);
                gbs.Poison_Arrow = int.Parse(load[5]);
                gbs.Small_Potion = int.Parse(load[6]);
                gbs.Speed_Potion = int.Parse(load[7]);
                gbs.Sword_of_the_Damned = int.Parse(load[8]);
                gbs.pLvl = int.Parse(load[11]);
                gbs.hardnessMultiplier = double.Parse(load[12]);

                fb.lblYourName.Text = load[9];

                gbs.continueSave = false;

                fb.Show();
                Hide();



            }
            else
            {


                if (tbxUserName.Text == "" || tbxUserName.Text == "(Enter Your Desired Name)" || tbxUserName.Text.Contains(' '))
                {

                    lblError.Text = "Please enter a Valid Username!";
                    tbxUserName.Text = "(Enter Your Desired Name)";
                    pnlError.Show();

                }
                else
                {
                    gbs.strUserName = tbxUserName.Text;
                    fb.lblYourName.Text = tbxUserName.Text;

                    fb.Show();
                    Hide();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlError.Hide();
        }


    }
}