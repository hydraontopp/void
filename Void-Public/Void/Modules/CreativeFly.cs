#region

using Void.ClientBase;

#endregion

namespace Void.Modules
{
    internal class CreativeFly : Module
    {
        public CreativeFly() : base("CreativeFly", (char)0x07, "Player")
        {
        } // Not defined

        public override void OnTick()
        {
            Game.isFlying = true;
        }
    }
}