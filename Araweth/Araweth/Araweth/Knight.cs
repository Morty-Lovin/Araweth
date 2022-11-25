using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araweth
{
    
    class Knight
    {
        public UserInfo ui = new UserInfo();
        public void SetVariables()
        {
            frmClass fc = new frmClass();

            ui.info.strUserClass = "Knight";
            

            ui.info.intLevel = 1;
            ui.info.intHealth = 500;
            ui.info.strAbility1Name = "Slash";
            ui.info.strAbility2Name = "Block";
            ui.info.strAbility3Name = "Spining Blade";
            ui.info.strAbility4Name = "Sky Fall";


        }

    }
}
