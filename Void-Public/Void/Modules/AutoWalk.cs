#region

using System;
using System.Windows.Forms;
using Void.ClientBase;
using Void.ClientBase.KeyBase;
using Void.Modules.vModuleExtra;

#endregion

namespace Void.Modules
{
    internal class AutoWalk : Module
    {
        public AutoWalk() : base("AutoWalk", (char)0x07, "Player")
        {
            addBypass(new BypassBox(new string[] { "Normal", "Fast", "Slow" }));
        } // Not defined

        public override void OnTick()
        {
            var newVel = Game.velocity;

            var cy = (Game.bodyRots.y + 89.9f) * ((float)Math.PI / 180F);

            int speed = 4;

            if (bypasses[0].curIndex == 1)
                speed = 6;
            if (bypasses[0].curIndex == 2)
                speed = 2;

            newVel.z = (float)Math.Sin(cy) * (speed / 9f);
            newVel.x = (float)Math.Cos(cy) * (speed / 9f);

            Game.velocity = newVel;
        }
    }
}