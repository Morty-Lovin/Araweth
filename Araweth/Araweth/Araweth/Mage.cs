using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araweth
{
    class Mage
    {
        public UserInfo ui = new UserInfo();
        public void SetVariables()
        {
            frmMain fm = new frmMain();
            frmClass fc = new frmClass();

            ui.info.strUserClass = "Mage";
            

            ui.info.intLevel = 1;
            ui.info.intHealth = 500;
            ui.info.strAbility1Name = "Fire Bolt";
            ui.info.strAbility2Name = "Barrier";
            ui.info.strAbility3Name = "Fire Storm";
            ui.info.strAbility4Name = "Sky Fall";
        }

    }
}
