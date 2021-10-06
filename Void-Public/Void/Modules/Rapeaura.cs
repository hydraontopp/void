#region

using Void.ClientBase;
using Void.ClientBase.KeyBase;

#endregion

namespace Void.Modules
{
    internal class Rapeaura : Module
    {
        public Rapeaura() : base("Rapeaura", (char)0x07, "Combat")
        {
        } // Not defined

        public override void OnTick()
        {
            if (Game.isNull) return;

            var plr = Game.getClosestPlayer();
            if (Game.position.Distance(plr.position) < 6f)
                Game.SexActor(plr);

            if (Game.isLookingAtEntity && MCM.isMinecraftFocused())
                Mouse.MouseEvent(Mouse.MouseEventFlags.MOUSEEVENTF_LEFTDOWN);
        }
    }
}