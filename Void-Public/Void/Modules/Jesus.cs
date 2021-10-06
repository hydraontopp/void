#region

using Void.ClientBase;
using Void.ClientBase.VersionBase;

#endregion

namespace Void.Modules
{
    internal class Jesus : Module
    {
        public Jesus() : base("Jesus", (char)0x07, "Player")
        {
        } // Not defined

        public override void OnTick()
        {
            if (Game.isNull) return;

            if (Game.inWater)
            {
                MCM.writeFloat(Game.localPlayer + VersionClass.GetData("velocity") + 4, 0.01f);
                Game.onGround = true;
            }
        }
    }
}