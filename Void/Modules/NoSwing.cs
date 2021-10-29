#region

using Void.ClientBase;

#endregion

namespace Void.Modules
{
    internal class NoSwing : Module
    {
        public NoSwing() : base("NoSwing", (char)0x07, "Visual")
        {
        } // Not defined

        public override void OnTick()
        {
            if (Game.isNull) return;

            Game.swingAn = 0;
        }
    }
}