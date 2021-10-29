#region

using System;
using System.Windows.Forms;
using Void.ClientBase;
using Void.ClientBase.KeyBase;
using Void.ClientBase.UIBase;
using Void.ClientBase.VersionBase;

#endregion

namespace Void.Modules
{
    internal class MineplexFlyv2 : Module
    {
        public MineplexFlyv2() : base("BhopFlight", (char)0x07, "Flies")
        {
        } // Not defined

        public override void OnEnable()
        {
            foreach (Module mod in Program.Modules)
                if (mod.name == "MineplexFly" || mod.name == "Bhop")
                    mod.OnEnable();
            base.OnEnable();
        }

        public override void OnDisable()
        {
            foreach (Module mod in Program.Modules)
                if (mod.name == "MineplexFly" || mod.name == "Bhop")
                    mod.OnDisable();
            base.OnDisable();
        }
    }
}