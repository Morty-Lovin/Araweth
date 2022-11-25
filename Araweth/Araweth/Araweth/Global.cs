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
    public static class gbs
    {


        public static string strClass { get; set; }
        public static string strUserName { get; set; }
        public static int
                Small_Potion,
                Large_Potion,
                Font_of_Life,
                Speed_Potion,
                Luck_Potion,
                Sword_of_the_Damned,
                Cursed_Bone,
                Poison_Arrow,
                Hammer_of_Retribution,
                pLvl;
        public static double hardnessMultiplier;


        public static List<string> scoreList = new List<string>();

        public static string[] fileContent;

        public static bool continueSave = false;

        public static ListViewItem lvi = new ListViewItem(strUserName);

        public static SoundPlayer sp = new SoundPlayer();

        public static SoundPlayer ea = new SoundPlayer();

        public static SoundPlayer pa = new SoundPlayer();



        static gbs()
        {
            pa.SoundLocation= @"..\..\resources\playerAttack.wav";
            ea.SoundLocation = @"..\..\resources\enemyAttack.wav";
            sp.SoundLocation = @"..\..\resources\background.wav";
            strClass = "_place_holder_";
            Small_Potion = 0;
            Large_Potion = 0;
            Font_of_Life = 0;
            Speed_Potion = 0;
            Luck_Potion = 0;
            Sword_of_the_Damned = 0;
            Cursed_Bone = 0;
            Poison_Arrow = 0;
            Hammer_of_Retribution = 0;
            pLvl = 1;
            hardnessMultiplier = .3;
        }


        public static void ScoresOut(int score, string name)
        {
            scoreList = new List<string>();

            fileContent = File.ReadAllLines(@"..\..\resources\highscore.txt");

            scoreList.AddRange(fileContent);

            scoreList.Add(" ," + name + "," + score.ToString());
            var sortedScoreList = scoreList.OrderByDescending(ss => int.Parse(ss.Substring(ss.LastIndexOf(",") + 1)));
            File.WriteAllLines(@"..\..\resources\highscore.txt", sortedScoreList.ToArray());
        }
    }
}
