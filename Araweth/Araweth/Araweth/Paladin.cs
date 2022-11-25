using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araweth
{
    class Paladin
    {
        public UserInfo ui = new UserInfo();
        public void SetVariables()
        {
            frmMain fm = new frmMain();
            frmClass fc = new frmClass();

            ui.info.strUserClass = "Knight";
            

            ui.info.intLevel = 1;
            ui.info.intHealth = 500;
            ui.info.strAbility1Name = "Bash";
            ui.info.strAbility1Image = "bash";
            ui.info.strAbility2Name = "Divine Blessing";
            ui.info.strAbility3Name = "Over Heal";
            ui.info.strAbility4Name = "Justice";
        }

    }
}
