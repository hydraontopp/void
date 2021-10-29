#region

using System;
using System.Windows.Forms;
using Void.ClientBase;
using Void.ClientBase.KeyBase;

#endregion

namespace Void.Modules
{
    internal class FixHitbox : Module
    {
        public FixHitbox() : base("FixHitbox", (char)0x07, "Others")
        {
        } // 0x07 = no keybind

        public override void OnEnable()
        {
            base.OnEnable();

            Game.teleport(Game.position);
        }
    }
}