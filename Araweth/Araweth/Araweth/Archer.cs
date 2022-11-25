using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araweth
{
    class Archer
    {
        public UserInfo ui = new UserInfo();
        public void SetVariables()
        {
            frmMain fm = new frmMain();
            frmClass fc = new frmClass();

            ui.info.strUserClass = "Archer";
           

            ui.info.intLevel = 1;
            ui.info.intHealth = 500;
            ui.info.strAbility1Name = "Quickshot";
            ui.info.strAbility2Name = "Roll";
            ui.info.strAbility3Name = "Hail of Arrows";
            ui.info.strAbility4Name = "Snipe";
        }

    }
}
