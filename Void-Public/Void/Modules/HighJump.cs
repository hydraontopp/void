#region

using System.Windows.Forms;
using Void.ClientBase;
using Void.ClientBase.KeyBase;
using Void.ClientBase.VersionBase;
using Void.Modules.vModuleExtra;

#endregion

namespace Void.Modules
{
    internal class HighJump : Module
    {
        public HighJump() : base("HighJump", (char)0x07, "Player")
        {
            //addBypass(new BypassBox(new string[] { "Default", "High", "Super Low", "Low" }));
        } // 0x07 = no keybind

        public override void OnTick()
        {
            if (Game.isNull) return;

            if (Keymap.GetAsyncKeyState(Keys.Space) && Game.onGround == true)
            {
                MCM.writeFloat(Game.localPlayer + VersionClass.GetData("velocity") + 4, 0.8f);
            }
        }
    }
}