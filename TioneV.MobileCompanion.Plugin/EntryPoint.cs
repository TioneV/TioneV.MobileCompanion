using LSPD_First_Response.Mod.API;
using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TioneV.MobileCompanion.Plugin
{
    public class EntryPoint : LSPD_First_Response.Mod.API.Plugin
    {
        public EntryPoint() : base()
        {

        }

        public override void Initialize()
        {
            Functions.OnOnDutyStateChanged += OnOnDutyStateChanged;

            Game.LogTrivial("TioneV.MobileCompanion initialized");
        }

        private void OnOnDutyStateChanged(bool onDuty)
        {

        }

        public override void Finally()
        {

        }
    }
}
