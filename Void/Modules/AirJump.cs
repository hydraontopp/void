#region

using Void.ClientBase;
using Void.Modules.vModuleExtra;

#endregion

namespace Void.Modules
{
    internal class AirJump : Module
    {
        public AirJump() : base("AirJump", (char)0x07, "World")
        {
            addBypass(new BypassBox(new string[] { "onGround: True", "onGround: False" }));
        }

        public override void OnTick()
        {
            if (!Game.isNull)
                Game.onGround = (bypasses[0].curIndex != 0);
        }
    }
}