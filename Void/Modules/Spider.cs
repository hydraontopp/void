#region

using System.Windows.Forms;
using Void.ClientBase;
using Void.ClientBase.KeyBase;
using Void.ClientBase.VersionBase;
using Void.Modules.vModuleExtra;

#endregion

namespace Void.Modules
{
    internal class Spider : Module
    {
        public Spider() : base("Spider", (char)0x07, "Player")
        {
        } // Not defined

        public override void OnTick()
        {
            float speed = 0.4f;

            if (Game.touchingObject != 1) return;
            if (Keymap.GetAsyncKeyState(Keys.Space))
                MCM.writeFloat(Game.localPlayer + VersionClass.GetData("velocity") + 4, speed);
            else MCM.writeFloat(Game.localPlayer + VersionClass.GetData("velocity") + 4, -speed);
        }
    }
}