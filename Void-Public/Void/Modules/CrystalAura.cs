#region

using Void.ClientBase;
using Void.ClientBase.KeyBase;
using Void.Modules.vModuleExtra;

#endregion

namespace Void.Modules
{
    internal class Crystalaura : Module
    {
        public Crystalaura() : base("Crystalaura", (char)0x07, "Combat")
        {
            addBypass(new BypassBox(new string[] { "Fast place: False", "Fast place: True" }));
        }

        public override void OnTick()
        {
            var list = Game.getPlayers();
            if (bypasses[0].curIndex == 1)
                list = Game.getEndcrystal();
            foreach (var ent in list)
                if (Game.position.Distance(ent.position) < 6f)
                    ent.hitbox = Base.Vec2(7f, 7f);
                else ent.hitbox = Base.Vec2(0.6f, 1.8f);

            if (Game.isLookingAtEntity && MCM.isMinecraftFocused())
                Mouse.MouseEvent(Mouse.MouseEventFlags.MOUSEEVENTF_LEFTDOWN);
        }
    }
}