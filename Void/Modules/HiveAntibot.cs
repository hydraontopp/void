#region

using Void.ClientBase;

#endregion

namespace Void.Modules
{
    internal class HiveAntibot : Module
    {
        public HiveAntibot() : base("HiveAntibot", (char)0x07, "Other", false)
        {
        }

        public override void OnEnable()
        {
            Game.CustomDefines.antibot = true;
            Game.CustomDefines.antibotStates = new bool[] { false, true }; // hive parser
            base.OnEnable();
        }

        public override void OnDisable()
        {
            Game.CustomDefines.antibot = false;
            base.OnDisable();
        }
    }
}