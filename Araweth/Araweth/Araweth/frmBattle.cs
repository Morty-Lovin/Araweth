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
using System.Threading;
using System.Media;

namespace Araweth
{
    public partial class frmBattle : Form
    {
        Knight knight = new Knight();
        Mage mage = new Mage();
        Archer archer = new Archer();
        Paladin paladin = new Paladin();
        Random rnd = new Random();



        List<string> adjectives = File.ReadLines(@"..\..\resources\adjectives.txt").ToList();
        List<string> monsters = File.ReadLines(@"..\..\resources\monsters.txt").ToList();
        List<string> goodies = File.ReadLines(@"..\..\resources\loot.txt").ToList();



        public double


            ability1,
            ability2,
            ability3,
            ability4,
            newPHP,
            newEHP,
            pATK,
            eATK,
            eHP,
            pHP,
            currentEHP,
            currentPHP,

            damage = 0;



        string
            charClass;

        public int
            eHPBarUpdate,
            pHPBarUpdate,
            hardnessCounter = 1,
            eLvlDisplay = 1,
            eLvl = 1,
            skill2Count = 0,
            skill3Count = 0,
            skill4Count = 0;


        public int
            playerStatusCount = 0,
            enemyStatusCount = 0,
            itemIndex = 0,

        luck = 0;

        bool
            skill2CD = false,
            skill3CD = false,
            skill4CD = false;


        const double
            PHEALTH = 160,
            EHEALTH = 160,
            PATTACK = 90,
            EATTACK = 30;

        public const double
            atkKNIGHT = .40,
            atkMAGE = .45,
            atkARCHER = .43,
            atkPALADIN = .36,

            atkGOBLIN = .18,
            atkZOMBIE = .25,
            atkBANSHEE = .3,
            atkWEREWOLF = .4,
            atkORC = .55,
            atkDRAGON = .9,


            hthKNIGHT = 1,
            hthMAGE = .78,
            hthARCHER = .8,
            hthPALADIN = 1.5,

            hthGOBLIN = .725,
            hthZOMBIE = 1.0375,
            hthBANSHEE = 1.0625,
            hthWEREWOLF = 1.0875,
            hthORC = 1.2125,
            hthDRAGON = 1.675;

        private void button1_Click_1(object sender, EventArgs e)
        {


            gbs.sp.Stop();
            
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmComingSoon fcs = new frmComingSoon();
            fcs.ShowDialog();
            fcs.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerDeath();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlSave.Hide();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //List<string> save = new List<string> { gbs.Cursed_Bone.ToString(), gbs.Font_of_Life.ToString() , gbs.Hammer_of_Retribution.ToString() ,
            //    gbs.Large_Potion.ToString() ,gbs.Luck_Potion.ToString(),gbs.Poison_Arrow.ToString(),gbs.Small_Potion.ToString(),
            //    gbs.Speed_Potion.ToString(),gbs.Sword_of_the_Damned.ToString(),lblYourName.Text,gbs.pLvl.ToString(),gbs.hardnessMultiplier.ToString() };
            List<string> save = new List<string> { gbs.Cursed_Bone.ToString(), gbs.Font_of_Life.ToString() , gbs.Hammer_of_Retribution.ToString() ,
                gbs.Large_Potion.ToString() ,gbs.Luck_Potion.ToString(),gbs.Poison_Arrow.ToString(),gbs.Small_Potion.ToString(),
                gbs.Speed_Potion.ToString(),gbs.Sword_of_the_Damned.ToString(),lblYourName.Text,gbs.strClass,gbs.pLvl.ToString(),
                gbs.hardnessMultiplier.ToString()};
            TextWriter tw = new StreamWriter(@"..\..\resources\Save.txt");

            foreach (string s in save)
            {
                tw.WriteLine(s);
            }

            tw.Close();

            pnlSave.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            lblSave.Text = "Are you sure you want to overwrite your previous data?";
            pnlSave.Show();

        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            pbxEnemy.Left = 497;
            pbxEnemy.Top = 28;
            pbxChar.Left = 34;
            pbxChar.Top = 260;
            this.Refresh();
            tmrAnimation.Enabled = false;

        }

        private void btnThrow_Click(object sender, EventArgs e)
        {

            pnlLoot.Hide();
        }

        private void btnKeep_Click(object sender, EventArgs e)
        {

            if (lblLootName.Text.Contains("SMALL"))
            {
                gbs.Small_Potion++;

                lblSmPotCount.Text = gbs.Small_Potion.ToString();

                pnlLoot.Hide();


            }
            else if (lblLootName.Text.Contains("LARGE"))
            {
                gbs.Large_Potion++;

                lblLgPotCount.Text = gbs.Large_Potion.ToString();

                pnlLoot.Hide();
            }
            else if (lblLootName.Text.Contains("FONT"))
            {
                gbs.Font_of_Life++;

                lblFullHpCount.Text = gbs.Font_of_Life.ToString();

                pnlLoot.Hide();
            }
            else if (lblLootName.Text.Contains("SPEED"))
            {
                gbs.Speed_Potion++;

                lblSpeedCount.Text = gbs.Speed_Potion.ToString();

                pnlLoot.Hide();
            }
            else if (lblLootName.Text.Contains("LUCK"))
            {

                gbs.Luck_Potion++;

                lblLuckCount.Text = gbs.Luck_Potion.ToString();

                pnlLoot.Hide();
            }
            else if (lblLootName.Text.Contains("POISON"))
            {
                gbs.Poison_Arrow++;

                lblPoisonCount.Text = gbs.Poison_Arrow.ToString();

                pnlLoot.Hide();
            }
            else if (lblLootName.Text.Contains("damned"))
            {
                gbs.Sword_of_the_Damned++;

                lblDamnedCount.Text = gbs.Sword_of_the_Damned.ToString();

                pnlLoot.Hide();
            }
            else if (lblLootName.Text.Contains("CURSED"))
            {
                gbs.Cursed_Bone++;

                lblCursedCount.Text = gbs.Cursed_Bone.ToString();

                pnlLoot.Hide();
            }
            else if (lblLootName.Text.Contains("hammer"))
            {
                gbs.Hammer_of_Retribution++;

                lblHammerCount.Text = gbs.Hammer_of_Retribution.ToString();

                pnlLoot.Hide();

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlError.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlItems.Hide();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {

            if (lbxItems.SelectedIndex == 0)
            {
                if (gbs.Small_Potion == 0)
                {

                    lblError.Text = "You do not have enough of this item";
                    pnlError.Show();

                }
                else
                {
                    SmallPot();

                    lblSmPotCount.Text = gbs.Small_Potion.ToString();

                    pnlItems.Hide();
                }

            }
            else if (lbxItems.SelectedIndex == 1)
            {

                if (gbs.Large_Potion == 0)
                {

                    lblError.Text = "You do not have enough of this item";
                    pnlError.Show();

                }
                else
                {
                    LargePot();

                    lblLgPotCount.Text = gbs.Large_Potion.ToString();

                    pnlItems.Hide();
                }

            }
            else if (lbxItems.SelectedIndex == 2)
            {

                if (gbs.Font_of_Life == 0)
                {

                    lblError.Text = "You do not have enough of this item";
                    pnlError.Show();

                }
                else
                {
                    Life();

                    lblFullHpCount.Text = gbs.Font_of_Life.ToString();

                    pnlItems.Hide();
                }


            }
            else if (lbxItems.SelectedIndex == 3)
            {

                if (gbs.Speed_Potion == 0)
                {

                    lblError.Text = "You do not have enough of this item";
                    pnlError.Show();

                }
                else
                {
                    Speed();

                    lblSpeedCount.Text = gbs.Speed_Potion.ToString();

                    pnlItems.Hide();
                }

            }
            else if (lbxItems.SelectedIndex == 4)
            {
                if (gbs.Luck_Potion == 0)
                {

                    lblError.Text = "You do not have enough of this item";
                    pnlError.Show();

                }
                else
                {
                    Luck();

                    lblLuckCount.Text = gbs.Luck_Potion.ToString();

                    pnlItems.Hide();
                }

            }
            else if (lbxItems.SelectedIndex == 5)
            {

                lblError.Text = "Can't use this item! This item permenantly increases your stats.";
                pnlError.Show();

            }
            else if (lbxItems.SelectedIndex == 6)
            {

                lblError.Text = "Can't use this item! This item permenantly increases your stats.";
                pnlError.Show();
            }
            else if (lbxItems.SelectedIndex == 7)
            {

                lblError.Text = "Can't use this item! This item permenantly increases your stats.";
                pnlError.Show();
            }
            else if (lbxItems.SelectedIndex == 8)
            {

                lblError.Text = "Can't use this item! This item permenantly increases your stats.";
                pnlError.Show();
            }

        }

        public frmBattle()
        {
            InitializeComponent();

        }

        public void frmBattle_Load(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();




            PlayerInitialize();
            PlayerHealthAndAttack();
            EnemyInitialize();
            EnemyHealthAndAttack();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();

            fm.Show();
            this.Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            tmrWait.Interval = 750; // here time in milliseconds
            tmrWait.Tick += timer_Tick;
            tmrWait.Start();
            btnAbility1.Enabled = false;
            btnAbility2.Enabled = true;
            btnAbility3.Enabled = true;
            btnAbility4.Enabled = true;

            pnlItems.Left = (821 / 2) - (301 / 2) - 11;

            lblSmPotCount.Text = gbs.Small_Potion.ToString();
            lblLgPotCount.Text = gbs.Large_Potion.ToString();
            lblFullHpCount.Text = gbs.Font_of_Life.ToString();
            lblSpeedCount.Text = gbs.Speed_Potion.ToString();
            lblLuckCount.Text = gbs.Luck_Potion.ToString();
            lblCursedCount.Text = gbs.Cursed_Bone.ToString();
            lblHammerCount.Text = gbs.Hammer_of_Retribution.ToString();
            lblPoisonCount.Text = gbs.Poison_Arrow.ToString();
            lblDamnedCount.Text = gbs.Sword_of_the_Damned.ToString();

            pnlItems.Visible = true;
        }

        private void btnAbility1_Click(object sender, EventArgs e)
        {

            tmrAnimation.Enabled = true;
            pbxChar.Left += 50;
            pbxChar.Top -= 30;
            pbxEnemy.Left -= 30;
            pbxEnemy.Top += 50;

            this.Refresh();

            tmrWait.Interval = 750; // here time in milliseconds
            tmrWait.Tick += timer_Tick;
            tmrWait.Start();
            btnAbility1.Enabled = false;
            btnAbility2.Enabled = true;
            btnAbility3.Enabled = true;
            btnAbility4.Enabled = true;

            newEHP = currentEHP;

            newEHP -= ability1;

            if (newEHP <= 0)
            {
                pnlCurrentEHP.Width = 0;

                newEHP = 0;

                lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();
                lblEnemyHealth.Refresh();

                lblPlayerDamage.Text = ((int)(-ability1)).ToString();
                lblPlayerDamage.Show();
                lblPlayerDamage.Refresh();
                Thread.Sleep(750);
                lblPlayerDamage.Hide();
                lblPlayerDamage.Refresh();

                CDChecker();

                EnemyDeath();

            }
            else
            {
                eHPBarUpdate = (int)(newEHP / eHP * 377);

                pnlCurrentEHP.Width = eHPBarUpdate;

                currentEHP = newEHP;

                lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                lblEnemyHealth.Refresh();

                lblPlayerDamage.Text = ((int)(-ability1)).ToString();
                lblPlayerDamage.Show();
                lblPlayerDamage.Refresh();
                Thread.Sleep(750);
                lblPlayerDamage.Hide();
                lblPlayerDamage.Refresh();


                EnemyAttack();

                CDChecker();


            }



        }

        private void btnAbility2_Click(object sender, EventArgs e)
        {

            tmrAnimation.Enabled = true;
            pbxEnemy.Left -= 30;
            pbxEnemy.Top += 50;

            this.Refresh();

            tmrWait.Interval = 750;
            tmrWait.Tick += timer_Tick;
            tmrWait.Start();
            btnAbility1.Enabled = false;
            btnAbility2.Enabled = true;
            btnAbility3.Enabled = true;
            btnAbility4.Enabled = true;

            skill2CD = true;

            if (charClass == "paladin")
            {
                newPHP += pHP * .3;

                if (newPHP > pHP)
                {

                    newPHP = pHP;

                }

                pHPBarUpdate = (int)(newPHP / pHP * 377);

                pnlCurrentPHP.Width = pHPBarUpdate;


                currentPHP = newPHP;

                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();
                lblPlayerHealth.Refresh();

                EnemyAttack();

                CDChecker();

            }
            else if (charClass == "archer")
            {
                lblEnemyDamage.Text = "DODGED!";
                lblEnemyDamage.Show();
                lblEnemyDamage.Refresh();
                Thread.Sleep(750);
                lblEnemyDamage.Hide();
                lblEnemyDamage.Refresh();

                CDChecker();
            }
            else
            {
                lblEnemyDamage.Text = "Blocked!";
                lblEnemyDamage.Show();
                lblEnemyDamage.Refresh();
                Thread.Sleep(750);
                lblEnemyDamage.Hide();
                lblEnemyDamage.Refresh();

                CDChecker();

            }


        }

        private void btnAbility3_Click(object sender, EventArgs e)
        {

            tmrAnimation.Enabled = true;
            pbxChar.Left += 50;
            pbxChar.Top -= 30;
            pbxEnemy.Left -= 30;
            pbxEnemy.Top += 50;
            this.Refresh();

            tmrWait.Interval = 1000; // here time in milliseconds
            tmrWait.Tick += timer_Tick;
            tmrWait.Start();
            btnAbility1.Enabled = false;
            btnAbility2.Enabled = true;
            btnAbility3.Enabled = true;
            btnAbility4.Enabled = true;

            if (charClass == "paladin")
            {
                skill3CD = true;

                newPHP = pHP;

                pHPBarUpdate = (int)(newPHP / pHP * 377);

                pnlCurrentPHP.Width = 377;

                Thread.Sleep(750);

                currentPHP = newPHP;

                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();

                lblPlayerHealth.Refresh();

                CDChecker();

            }
            else if (charClass == "archer")
            {
                skill3CD = true;
                if (currentEHP >= (ability3 * 10))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(200);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    CDChecker();

                    EnemyAttack();
                }
                else if (currentEHP >= (ability3 * 9))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= (ability3 * 8))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= (ability3 * 7))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= (ability3 * 6))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= (ability3 * 5))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= (ability3 * 4))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= (ability3 * 3))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= (ability3 * 2))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP >= ability3)
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(175);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();
                }
                else if (currentEHP < ability3)
                {

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;

                    Thread.Sleep(175);

                    CDChecker();

                    EnemyDeath();

                }
            }
            else
            {
                skill3CD = true;

                if (currentEHP >= (ability3 * 3))
                {
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(500);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(500);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(500);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();


                    CDChecker();

                    EnemyAttack();
                }
                else if (currentEHP >= (ability3 * 2))
                {

                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(500);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();
                    Ability3();
                    lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(500);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP).ToString() + "/" + ((int)eHP).ToString();

                    pnlCurrentEHP.Width = 0;


                    CDChecker();

                    EnemyDeath();

                }
                else
                {
                    Ability3();
                    lblPlayerDamage.Text = ((int)(-ability3)).ToString();
                    lblPlayerDamage.Show();
                    lblPlayerDamage.Refresh();
                    Thread.Sleep(500);
                    lblPlayerDamage.Hide();
                    lblPlayerDamage.Refresh();

                    newEHP = 0;

                    lblEnemyHealth.Text = ((int)newEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                    lblEnemyHealth.Refresh();

                    pnlCurrentEHP.Width = 0;

                    EnemyDeath();


                    CDChecker();

                }



            }


        }

        private void btnAbility4_Click(object sender, EventArgs e)
        {
            tmrAnimation.Enabled = true;
            pbxChar.Left += 50;
            pbxChar.Top -= 30;
            pbxEnemy.Left -= 30;
            pbxEnemy.Top += 50;
            this.Refresh();

            tmrWait.Interval = 750; // here time in milliseconds
            tmrWait.Tick += timer_Tick;
            tmrWait.Start();
            btnAbility1.Enabled = false;
            btnAbility2.Enabled = true;
            btnAbility3.Enabled = true;
            btnAbility4.Enabled = true;

            skill4CD = true;

            newEHP = currentEHP;

            newEHP -= ability4;


            if (newEHP <= 0)
            {
                pnlCurrentEHP.Width = 0;

                newEHP = 0;

                lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();

                lblEnemyHealth.Refresh();


                lblPlayerDamage.Text = ((int)(-ability4)).ToString();
                lblPlayerDamage.Show();
                lblPlayerDamage.Refresh();
                Thread.Sleep(750);
                lblPlayerDamage.Hide();
                lblPlayerDamage.Refresh();

                eHP = 0;

                CDChecker();

                EnemyDeath();

            }
            else
            {


                eHPBarUpdate = (int)(newEHP / eHP * 377);

                pnlCurrentEHP.Width = eHPBarUpdate;

                currentEHP = newEHP;

                lblEnemyHealth.Text = ((int)currentEHP + 1).ToString() + "/" + ((int)eHP).ToString();
                lblEnemyHealth.Refresh();

                lblPlayerDamage.Text = ((int)(-ability4)).ToString();
                lblPlayerDamage.Show();
                lblPlayerDamage.Refresh();
                Thread.Sleep(750);
                lblPlayerDamage.Hide();
                lblPlayerDamage.Refresh();

                EnemyAttack();

                CDChecker();

            }


        }

        private void PlayerInitialize()
        {
            double cursedMult = .1 * gbs.Cursed_Bone,
            swordMult = .1 * gbs.Sword_of_the_Damned,
            hammerMult = .1 * gbs.Hammer_of_Retribution,
            poisonMult = .1 * gbs.Poison_Arrow;

            if (gbs.strClass == "knight")
            {
                knight.SetVariables();

                btnAbility1.BackgroundImage = Properties.Resources.slash;
                btnAbility2.BackgroundImage = Properties.Resources.block;
                btnAbility3.BackgroundImage = Properties.Resources.spin;
                btnAbility4.BackgroundImage = Properties.Resources.fall;

                pbxChar.Image = Properties.Resources.knightReal;

                charClass = "knight";

                lblAbility1.Text = knight.ui.info.strAbility1Name;
                lblAbility2.Text = knight.ui.info.strAbility2Name;
                lblAbility3.Text = knight.ui.info.strAbility3Name;
                lblAbility4.Text = knight.ui.info.strAbility4Name;

                pHP = (gbs.pLvl * PHEALTH * hthKNIGHT) + (swordMult * gbs.pLvl * PHEALTH * hthKNIGHT);

                currentPHP = pHP;

                pnlCurrentPHP.Width = 377;

                lblYourLevel.Text = "lvl" + gbs.pLvl;


            }
            else if (gbs.strClass == "mage")
            {
                mage.SetVariables();

                btnAbility1.BackgroundImage = Properties.Resources.firebolt;
                btnAbility2.BackgroundImage = Properties.Resources.barrier;
                btnAbility3.BackgroundImage = Properties.Resources.firestorm;
                btnAbility4.BackgroundImage = Properties.Resources.inferno;

                pbxChar.Image = Properties.Resources.mageReal;

                charClass = "mage";

                lblAbility1.Text = mage.ui.info.strAbility1Name;
                lblAbility2.Text = mage.ui.info.strAbility2Name;
                lblAbility3.Text = mage.ui.info.strAbility3Name;
                lblAbility4.Text = mage.ui.info.strAbility4Name;

                pHP = (gbs.pLvl * PHEALTH * hthMAGE) + (cursedMult * 1.5 * gbs.pLvl * PHEALTH * hthMAGE);

                currentPHP = pHP;

                pnlCurrentPHP.Width = 377;

                lblYourLevel.Text = "lvl" + gbs.pLvl;


            }
            else if (gbs.strClass == "archer")
            {
                archer.SetVariables();

                btnAbility1.BackgroundImage = Properties.Resources.quickshot;
                btnAbility2.BackgroundImage = Properties.Resources.roll;
                btnAbility3.BackgroundImage = Properties.Resources.hail_of_arrows;
                btnAbility4.BackgroundImage = Properties.Resources.snipe;

                pbxChar.Image = Properties.Resources.archerReal;

                charClass = "archer";

                lblAbility1.Text = archer.ui.info.strAbility1Name;
                lblAbility2.Text = archer.ui.info.strAbility2Name;
                lblAbility3.Text = archer.ui.info.strAbility3Name;
                lblAbility4.Text = archer.ui.info.strAbility4Name;

                pHP = (gbs.pLvl * PHEALTH * hthARCHER) + (poisonMult * gbs.pLvl * PHEALTH * hthARCHER);

                currentPHP = pHP;

                pnlCurrentPHP.Width = 377;

                lblYourLevel.Text = "lvl" + gbs.pLvl;


            }
            else if (gbs.strClass == "paladin")
            {
                paladin.SetVariables();

                btnAbility1.BackgroundImage = Properties.Resources.Bash;
                btnAbility2.BackgroundImage = Properties.Resources.divine_blessing;
                btnAbility3.BackgroundImage = Properties.Resources.over_heal;
                btnAbility4.BackgroundImage = Properties.Resources.justice;

                pbxChar.Image = Properties.Resources.paladinReal;

                charClass = "paladin";

                lblAbility1.Text = paladin.ui.info.strAbility1Name;
                lblAbility2.Text = paladin.ui.info.strAbility2Name;
                lblAbility3.Text = paladin.ui.info.strAbility3Name;
                lblAbility4.Text = paladin.ui.info.strAbility4Name;

                pHP = (gbs.pLvl * PHEALTH * hthPALADIN) + (hammerMult * gbs.pLvl * PHEALTH * hthPALADIN);

                currentPHP = pHP;

                pnlCurrentPHP.Width = 377;
                lblYourLevel.Text = "lvl" + gbs.pLvl;



            }
        }

        private void EnemyInitialize()
        {

            if (gbs.pLvl % 10 == 0)
            {
                int adj = rnd.Next(adjectives.Count);

                lblEnemyName.Text = string.Format(adjectives[adj]) + " Dragon";

                EnemyLevel();

                EnemyHealthAndAttack();

            }
            else
            {
                int adj = rnd.Next(adjectives.Count);
                int mon = rnd.Next(monsters.Count - 1);

                lblEnemyName.Text = string.Format(adjectives[adj]) + " " + monsters[mon];

                EnemyLevel();

                EnemyHealthAndAttack();
            }

        }

        private void EnemyLevel()
        {

            int lvlChoice = rnd.Next(1, 101);

            if (gbs.pLvl <= 2)
            {

                eLvl = gbs.pLvl;
                eLvlDisplay = eLvl;

                lblEnemyLvl.Text = "lvl" + eLvlDisplay.ToString();

            }
            else if (lvlChoice >= 0 && lvlChoice < 50)
            {


                eLvl = gbs.pLvl;
                eLvlDisplay = eLvl;

                lblEnemyLvl.Text = "lvl" + eLvlDisplay.ToString();

            }
            else if (lvlChoice >= 50 && lvlChoice < 85)
            {

                eLvl = gbs.pLvl - 1;
                eLvlDisplay = eLvl;

                lblEnemyLvl.Text = "lvl" + eLvlDisplay.ToString();

            }
            else if (lvlChoice >= 85 && lvlChoice <= 377)
            {

                eLvl = gbs.pLvl + 2;
                eLvlDisplay = eLvl;

                lblEnemyLvl.Text = "lvl" + eLvlDisplay.ToString();

            }

        }

        private void EnemyHealthAndAttack()
        {
            if (lblEnemyName.Text.Contains("Dragon"))
            {
                pbxEnemy.Image = Properties.Resources.dragon;
                pnlCurrentEHP.Width = 377;
                eHP = eLvl * EHEALTH * hthDRAGON * gbs.hardnessMultiplier * 2.5;

                currentEHP = eHP;
                eATK = eLvl * EATTACK * atkDRAGON * gbs.hardnessMultiplier * .8;

                lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();

                luck = 1;
            }

            if (lblEnemyName.Text.Contains("Goblin"))
            {
                pbxEnemy.Image = Properties.Resources.goblin;
                pnlCurrentEHP.Width = 377;
                eHP = eLvl * EHEALTH * hthGOBLIN * gbs.hardnessMultiplier;

                currentEHP = eHP;
                eATK = eLvl * EATTACK * atkGOBLIN * gbs.hardnessMultiplier;

                lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();


            }
            else if (lblEnemyName.Text.Contains("Zombie"))
            {

                pbxEnemy.Image = Properties.Resources.zombie;
                pnlCurrentEHP.Width = 377;
                eHP = eLvl * EHEALTH * hthZOMBIE * gbs.hardnessMultiplier;

                currentEHP = eHP;
                eATK = eLvl * EATTACK * atkZOMBIE * gbs.hardnessMultiplier;

                lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();

            }
            else if (lblEnemyName.Text.Contains("Banshee"))
            {

                pbxEnemy.Image = Properties.Resources.banshee;
                pnlCurrentEHP.Width = 377;
                eHP = eLvl * EHEALTH * hthBANSHEE * gbs.hardnessMultiplier;

                currentEHP = eHP;
                eATK = eLvl * EATTACK * atkBANSHEE * gbs.hardnessMultiplier;

                lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();

            }
            else if (lblEnemyName.Text.Contains("Werewolf"))
            {

                pbxEnemy.Image = Properties.Resources.werewolf;
                pnlCurrentEHP.Width = 377;
                eHP = eLvl * EHEALTH * hthWEREWOLF * gbs.hardnessMultiplier;

                currentEHP = eHP;
                eATK = eLvl * EATTACK * atkWEREWOLF * gbs.hardnessMultiplier;

                lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();

            }
            else if (lblEnemyName.Text.Contains("Orc"))
            {

                pbxEnemy.Image = Properties.Resources.orc;
                pnlCurrentEHP.Width = 377;
                eHP = eLvl * EHEALTH * hthORC * gbs.hardnessMultiplier;

                currentEHP = eHP;
                eATK = eLvl * EATTACK * atkORC * gbs.hardnessMultiplier;

                lblEnemyHealth.Text = ((int)currentEHP).ToString() + "/" + ((int)eHP).ToString();

            }



        }

        private void PlayerHealthAndAttack()
        {

            double cursedMult = .1 * gbs.Cursed_Bone, swordMult = .1 * gbs.Sword_of_the_Damned;
            double poisonMult = .1 * gbs.Poison_Arrow, hammerMult = .1 * gbs.Hammer_of_Retribution;

            if (charClass == "knight")
            {

                lblYourLevel.Text = "lvl" + gbs.pLvl.ToString();

                pATK = (gbs.pLvl * PATTACK * atkKNIGHT) + (swordMult * gbs.pLvl * PATTACK * atkKNIGHT * 1.5)
                    + (hammerMult * gbs.pLvl * PATTACK * atkKNIGHT) + (poisonMult * gbs.pLvl * PATTACK * atkKNIGHT)
                    + (cursedMult * gbs.pLvl * PATTACK * atkKNIGHT);
                ability1 = .85 * pATK;
                ability3 = .6 * pATK;
                ability4 = 2.3 * pATK;

                ttAbilities.SetToolTip(btnAbility1, "Slash at the enemy for " + ((int)ability1).ToString() + " damage.");
                ttAbilities.SetToolTip(btnAbility2, "Block the next incoming attack.");
                ttAbilities.SetToolTip(btnAbility3, "Spin arround hitting the enemy three times for " 
                    + ((int)ability3).ToString() + " damage each.");
                ttAbilities.SetToolTip(btnAbility4, "Call down a giant sword from the sky, dealing " 
                    + ((int)ability4).ToString() + " damage.");

                if (gbs.pLvl % 10 == 0)
                {
                    pHP = (gbs.pLvl * PHEALTH * hthKNIGHT*.8) + (swordMult * gbs.pLvl * PHEALTH * hthKNIGHT);

                    pnlCurrentPHP.Width = 377;

                    currentPHP = pHP;
                }
                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();


            }
            else if (charClass == "mage")
            {

                lblYourLevel.Text = "lvl" + gbs.pLvl.ToString();
                pATK = (gbs.pLvl * PATTACK * atkMAGE) + (swordMult * gbs.pLvl * PATTACK * atkMAGE)
                    + (hammerMult * gbs.pLvl * PATTACK * atkMAGE) + (poisonMult * gbs.pLvl * PATTACK * atkMAGE)
                    + (cursedMult * gbs.pLvl * PATTACK * atkMAGE * 1.5);
                ability1 = .9 * pATK;
                ability3 = .7 * pATK;
                ability4 = 1.6 * pATK;

                ttAbilities.SetToolTip(btnAbility1, "Shoot a fire ball, dealing " + ((int)ability1).ToString() + " damage.");
                ttAbilities.SetToolTip(btnAbility2, "Block the next incoming attack.");
                ttAbilities.SetToolTip(btnAbility3, "Set the enemy ablaze, dealing " + ((int)ability3).ToString() 
                    + " damage three times each tick.");
                ttAbilities.SetToolTip(btnAbility4, "Conjure a giant meteor and hurl it at the enemy for " 
                    + ((int)ability4).ToString() + " damage.");

                if (gbs.pLvl % 10 == 0)
                {
                    pHP = (gbs.pLvl * PHEALTH * hthMAGE * .8) + (cursedMult * gbs.pLvl * PHEALTH * hthMAGE);

                    pnlCurrentPHP.Width = 377;

                    currentPHP = pHP;
                }
                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();

            }
            else if (charClass == "archer")
            {

                lblYourLevel.Text = "lvl" + gbs.pLvl.ToString();
                pATK = (gbs.pLvl * PATTACK * atkARCHER) + (swordMult * gbs.pLvl * PATTACK * atkARCHER)
                    + (hammerMult * gbs.pLvl * PATTACK * atkARCHER) + (poisonMult * gbs.pLvl * PATTACK * atkARCHER * 1.5)
                    + (cursedMult * gbs.pLvl * PATTACK * atkARCHER);
                ability1 = .95 * pATK;
                ability3 = .2 * pATK;
                ability4 = 2 * pATK;

                ttAbilities.SetToolTip(btnAbility1, "Fire a an arrow rapidly, dealling " + ((int)ability1).ToString() + " damage.");
                ttAbilities.SetToolTip(btnAbility2, "Dodge the next incoming attack.");
                ttAbilities.SetToolTip(btnAbility3, "Shoot ten arrows into the sky to rain down on the enemy, dealing " + ((int)ability3).ToString() + " damage ten times.");
                ttAbilities.SetToolTip(btnAbility4, "Take careful aim to fire an arrow straight at the enemies head, dealing " + ((int)ability4).ToString() + " damage.");

                if (gbs.pLvl % 10 == 0)
                {
                    pHP = (gbs.pLvl * PHEALTH * hthARCHER * .8) + (poisonMult * gbs.pLvl * PHEALTH * hthARCHER);

                    pnlCurrentPHP.Width = 377;

                    currentPHP = pHP;
                }
                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();

            }
            else if (charClass == "paladin")
            {

                lblYourLevel.Text = "lvl" + gbs.pLvl.ToString();
                pATK = (gbs.pLvl * PATTACK * atkPALADIN) + (swordMult * gbs.pLvl * PATTACK * atkPALADIN)
                    + (hammerMult * gbs.pLvl * PATTACK * atkPALADIN * 1.5) + (poisonMult * gbs.pLvl * PATTACK * atkPALADIN)
                    + (cursedMult * gbs.pLvl * PATTACK * atkPALADIN);
                ability1 = .9 * pATK;
                ability2 = .3 * pHP;
                ability4 = 2 * pATK;

                ttAbilities.SetToolTip(btnAbility1, "Bash the enemy for " + ((int)ability1).ToString() + " damage.");
                ttAbilities.SetToolTip(btnAbility2, "Heal yourself for " + ((int)ability2).ToString() + " health.");
                ttAbilities.SetToolTip(btnAbility3, "Heal yourself to full health.");
                ttAbilities.SetToolTip(btnAbility4, "Deliver a handful of JUSTICE straight to the enemy, dealing " + ((int)ability4).ToString() + " damage.");

                if (gbs.pLvl % 10 == 0)
                {
                    pHP = (gbs.pLvl * PHEALTH * hthPALADIN) + (hammerMult * gbs.pLvl * PHEALTH * hthKNIGHT);

                    pnlCurrentPHP.Width = 377;

                    currentPHP = pHP;
                }
                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();

            }

        }

        private void EnemyDeath()
        {
            Thread.Sleep(150);

            Loot();
            hardnessCounter++;
            if ((hardnessCounter % 2) == 0)
            {
                hardnessCounter -= 2;
                gbs.hardnessMultiplier += .03;
            }
            gbs.pLvl++;
            eLvl++;



            EnemyInitialize();

            PlayerHealthAndAttack();

        }

        private double EnemyDamage(double atk)
        {
            int rand = rnd.Next(1, 101);

            if (rand >= 0 && rand < 50)
            {

                damage = atk;

            }
            else if (rand >= 50 && rand < 85)
            {

                damage = .75 * atk;

            }
            else if (rand >= 85 && rand <= 100)
            {

                damage = 1.1 * atk;

            }

            return damage;

        }

        private void EnemyAttack()
        {
            gbs.ea.Play();

            newPHP = currentPHP;

            newPHP -= EnemyDamage(eATK);

            if (newPHP <= 0)
            {
                pnlCurrentPHP.Width = 0;

                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();

                lblEnemyDamage.Text = ((int)(EnemyDamage(-eATK))).ToString();
                lblEnemyDamage.Show();
                lblEnemyDamage.Refresh();
                Thread.Sleep(750);
                lblEnemyDamage.Hide();
                lblEnemyDamage.Refresh();

                PlayerDeath();

            }
            else
            {
                pHPBarUpdate = (int)(newPHP / pHP * 377);

                pnlCurrentPHP.Width = pHPBarUpdate;
                pnlCurrentPHP.Refresh();

                currentPHP = newPHP;

                lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();

                lblEnemyDamage.Text = ((int)(EnemyDamage(-eATK))).ToString();
                lblEnemyDamage.Show();
                lblEnemyDamage.Refresh();
                Thread.Sleep(750);
                lblEnemyDamage.Hide();
                lblEnemyDamage.Refresh();

                lblPlayerHealth.Refresh();

            }


        }

        private void Ability3()
        {

            newEHP = currentEHP;

            newEHP -= ability3;

            if (newEHP <= 0)
            {
                pnlCurrentEHP.Width = 0;

                newEHP = 0;

                eHP = 0;

                EnemyDeath();

            }
            else
            {
                eHPBarUpdate = (int)(newEHP / eHP * 377);

                pnlCurrentEHP.Width = eHPBarUpdate;

                currentEHP = newEHP;

            }

        }

        private void PlayerDeath()
        {

            lblFinish.Text = "You made it to level " + gbs.pLvl + ". You scored " + (gbs.pLvl * 150).ToString() + "this round";
            pnlFinish.Show();

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();

            gbs.ScoresOut((gbs.pLvl * 150), gbs.strUserName);

            List<string> save = new List<string> { gbs.Cursed_Bone.ToString(), gbs.Font_of_Life.ToString() , gbs.Hammer_of_Retribution.ToString(),
                gbs.Large_Potion.ToString() ,gbs.Luck_Potion.ToString(),gbs.Poison_Arrow.ToString(),gbs.Small_Potion.ToString(),
                gbs.Speed_Potion.ToString(),gbs.Sword_of_the_Damned.ToString(),gbs.strUserName,gbs.strClass,(gbs.pLvl = 1).ToString(),
                (gbs.hardnessMultiplier = .3).ToString()};

            TextWriter saved = new StreamWriter(@"..\..\resources\Save.txt");

            foreach (string s in save)
            {
                saved.WriteLine(s);
            }

            saved.Close();



            fm.Show();
            Close();

        }

        private void KnightCDCounter()
        {

            if (skill2CD == true)
            {
                lblSkill2CD.Text = (2 - skill2Count).ToString();
                lblSkill2CD.Show();
                skill2Count++;
                btnAbility2.Enabled = false;


                if (skill2Count > 2)
                {
                    skill2Count = 0;
                    btnAbility2.Enabled = true;
                    lblSkill2CD.Text = "";
                    lblSkill2CD.Hide();
                    skill2CD = false;

                }


            }

            if (skill3CD == true)
            {
                lblSkill3CD.Text = (4 - skill3Count).ToString();
                lblSkill3CD.Show();
                btnAbility3.Enabled = false;
                skill3Count++;

                if (skill3Count > 4)
                {
                    skill3Count = 0;
                    btnAbility3.Enabled = true;
                    lblSkill3CD.Text = "";
                    lblSkill3CD.Hide();
                    skill3CD = false;

                }


            }

            if (skill4CD == true)
            {
                lblSkill4CD.Text = (8 - skill4Count).ToString();
                lblSkill4CD.Show();
                btnAbility4.Enabled = false;
                skill4Count++;

                if (skill4Count > 8)
                {
                    skill4Count = 0;
                    btnAbility4.Enabled = true;
                    lblSkill4CD.Text = "";
                    lblSkill4CD.Hide();
                    skill4CD = false;

                }


            }

        }

        private void MageArcherCDCounter()
        {

            if (skill2CD == true)
            {
                lblSkill2CD.Text = (2 - skill2Count).ToString();
                lblSkill2CD.Show();
                btnAbility2.Enabled = false;
                skill2Count++;

                if (skill2Count > 2)
                {
                    skill2Count = 0;
                    btnAbility2.Enabled = true;
                    lblSkill2CD.Text = "";
                    lblSkill2CD.Hide();
                    skill2CD = false;

                }


            }

            if (skill3CD == true)
            {
                lblSkill3CD.Text = (5 - skill3Count).ToString();
                lblSkill3CD.Show();
                btnAbility3.Enabled = false;
                skill3Count++;

                if (skill3Count > 5)
                {
                    skill3Count = 0;
                    btnAbility3.Enabled = true;
                    lblSkill3CD.Text = "";
                    lblSkill3CD.Hide();
                    skill3CD = false;

                }


            }

            if (skill4CD == true)
            {
                lblSkill4CD.Text = (9 - skill4Count).ToString();
                lblSkill4CD.Show();
                btnAbility4.Enabled = false;
                skill4Count++;

                if (skill4Count > 9)
                {
                    skill4Count = 0;
                    btnAbility4.Enabled = true;
                    lblSkill4CD.Text = "";
                    lblSkill4CD.Hide();
                    skill4CD = false;

                }


            }

        }

        private void PaladinCDCounter()
        {

            if (skill2CD == true)
            {
                lblSkill2CD.Text = (12 - skill2Count).ToString();
                lblSkill2CD.Show();
                btnAbility2.Enabled = false;
                skill2Count++;

                if (skill2Count > 12)
                {
                    skill2Count = 0;
                    btnAbility2.Enabled = true;
                    lblSkill2CD.Text = "";
                    lblSkill2CD.Hide();
                    skill2CD = false;

                }


            }

            if (skill3CD == true)
            {
                lblSkill3CD.Text = (30 - skill3Count).ToString();
                lblSkill3CD.Show();
                btnAbility3.Enabled = false;
                skill3Count++;

                if (skill3Count > 30)
                {
                    skill3Count = 0;
                    btnAbility3.Enabled = true;
                    lblSkill3CD.Text = "";
                    lblSkill3CD.Hide();
                    skill3CD = false;

                }


            }

            if (skill4CD == true)
            {
                lblSkill4CD.Text = (6 - skill4Count).ToString();
                lblSkill4CD.Show();
                skill4Count++;
                btnAbility4.Enabled = false;
                if (skill4Count > 6)
                {
                    skill4Count = 0;
                    btnAbility4.Enabled = true;
                    lblSkill4CD.Text = "";
                    lblSkill4CD.Hide();
                    skill4CD = false;

                }


            }

        }

        private void CDChecker()
        {

            if (charClass == "knight")
            {

                KnightCDCounter();

            }
            else if (charClass == "mage" || charClass == "archer")
            {

                MageArcherCDCounter();

            }
            else if (charClass == "paladin")
            {

                PaladinCDCounter();

            }


        }

        private void Loot()
        {



            if (luck == 1)
            {

                int shloot = rnd.Next(560, 900);

                if (shloot >= 500 && shloot <650)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "THE FONT OF LIFE!";
                    pbxLoot.Image = Properties.Resources.font;
                    pnlLoot.Show();
                    luck = 0;

                }
                else if (shloot >= 650 && shloot < 760)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A SPEED POTION!";
                    pbxLoot.Image = Properties.Resources.speed;
                    pnlLoot.Show();
                    luck = 0;


                }
                else if (shloot >= 810 && shloot < 860)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A LUCK POTION!";
                    pbxLoot.Image = Properties.Resources.luck;
                    pnlLoot.Show();
                    luck = 0;


                }
                else if (shloot >= 860 && shloot < 870)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "the sword of the damned";
                    pbxLoot.Image = Properties.Resources.damned;
                    pnlLoot.Show();
                    luck = 0;


                }
                else if (shloot >= 870 && shloot < 880)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A CURSED BONE!";
                    pbxLoot.Image = Properties.Resources.bone;
                    pnlLoot.Show();
                    luck = 0;


                }
                else if (shloot >= 880 && shloot < 890)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;



                    lblLootName.Text = "A POISON ARROW";
                    pbxLoot.Image = Properties.Resources.poison;
                    pnlLoot.Show();
                    luck = 0;


                }
                else if (shloot >= 890 && shloot <= 900)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;



                    lblLootName.Text = "the hammer of retribution!";
                    pbxLoot.Image = Properties.Resources.hammer;
                    pnlLoot.Show();
                    luck = 0;


                }

            }
            else
            {

                int sloot = rnd.Next(0, 900);


                if (sloot >= 570 && sloot < 680)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A SMALL POTION!";
                    pbxLoot.Image = Properties.Resources.small_pot;
                    pnlLoot.Show();

                }
                else if (sloot >= 680 && sloot < 740)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A LARGE POTION!!";
                    pbxLoot.Image = Properties.Resources.large_pot;
                    pnlLoot.Show();

                }
                else if (sloot >= 740 && sloot < 800)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "THE FONT OF LIFE!";
                    pbxLoot.Image = Properties.Resources.font;
                    pnlLoot.Show();

                }
                else if (sloot >= 800 && sloot < 840)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A SPEED POTION!";
                    pbxLoot.Image = Properties.Resources.speed;
                    pnlLoot.Show();


                }
                else if (sloot >= 840 && sloot < 880)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A LUCK POTION!";
                    pbxLoot.Image = Properties.Resources.luck;
                    pnlLoot.Show();


                }
                else if (sloot >= 880 && sloot < 885)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "the sword of the damned";
                    pbxLoot.Image = Properties.Resources.damned;
                    pnlLoot.Show();


                }
                else if (sloot >= 885 && sloot < 890)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;

                    lblLootName.Text = "A CURSED BONE!";
                    pbxLoot.Image = Properties.Resources.bone;
                    pnlLoot.Show();


                }
                else if (sloot >= 890 && sloot < 895)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;



                    lblLootName.Text = "A POISON ARROW";
                    pbxLoot.Image = Properties.Resources.poison;
                    pnlLoot.Show();


                }
                else if (sloot >= 895 && sloot <= 900)
                {
                    tmrWait.Interval = 1500; // here time in milliseconds
                    tmrWait.Tick += timer_Tick;
                    tmrWait.Start();
                    btnAbility1.Enabled = false;
                    btnAbility2.Enabled = false;
                    btnAbility3.Enabled = false;
                    btnAbility4.Enabled = false;



                    lblLootName.Text = "the hammer of retribution!";
                    pbxLoot.Image = Properties.Resources.hammer;
                    pnlLoot.Show();
                }
            }

        }



        public void SmallPot()
        {
            gbs.Small_Potion--;

            currentPHP += pHP * .25;




            if (newPHP > pHP)
            {

                newPHP = pHP;

            }

            pHPBarUpdate = (int)(currentPHP / pHP * 377);

            pnlCurrentPHP.Width = pHPBarUpdate;

            newPHP = currentPHP;

            lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();
            lblPlayerHealth.Refresh();

        }
        public void LargePot()
        {

            gbs.Large_Potion--;

            currentPHP += pHP * .5;




            if (newPHP > pHP)
            {

                newPHP = pHP;

            }

            pHPBarUpdate = (int)(currentPHP / pHP * 377);

            pnlCurrentPHP.Width = pHPBarUpdate;

            newPHP = currentPHP;

            lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();
            lblPlayerHealth.Refresh();

        }
        public void Life()
        {
            gbs.Font_of_Life--;

            newPHP = pHP;

            pHPBarUpdate = (int)(newPHP / pHP * 377);

            pnlCurrentPHP.Width = pHPBarUpdate;

            currentPHP = newPHP;

            lblPlayerHealth.Text = ((int)currentPHP).ToString() + "/" + ((int)pHP).ToString();
            lblPlayerHealth.Refresh();

        }
        public void Speed()
        {
            gbs.Speed_Potion--;

            playerStatusCount = 2;

            CDChecker();
            CDChecker();


        }
        public void Luck()
        {
            gbs.Luck_Potion--;
            luck = 1;

        }



        void timer_Tick(object sender, System.EventArgs e)
        {
            btnAbility1.Enabled = true;
            btnAbility2.Enabled = true;
            btnAbility3.Enabled = true;
            btnAbility4.Enabled = true;
            tmrWait.Stop();
        }

    }
}

