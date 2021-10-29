#region

using Void.ClientBase;
using Void.Modules.vModuleExtra;

#endregion

namespace Void.Modules
{
    internal class Gamemode : Module
    {
        public Gamemode() : base("Gamemode", (char)0x07, "Exploits")
        {
            addBypass(new BypassBox(new string[] { "Survival", "Creative", "Adventure" }));
        } // 0x07 = no keybind

        public override void OnEnable()
        {
            base.OnEnable();
            Game.gamemode = bypasses[0].curIndex;
        }

        public override void OnDisable()
        {
            base.OnDisable();
            Game.gamemode = 0;
        }
    }
}