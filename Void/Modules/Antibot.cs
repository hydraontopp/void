﻿#region

using Void.ClientBase;

#endregion

namespace Void.Modules
{
    internal class Antibot : Module
    {
        public Antibot() : base("Antibot", (char)0x07, "Other", true)
        {
        }

        public override void OnEnable()
        {
            Game.CustomDefines.antibot = true;
            Game.CustomDefines.antibotStates = new bool[] { true, false }; // default parser fixed
            base.OnEnable();
        }

        public override void OnDisable()
        {
            Game.CustomDefines.antibot = false;
            base.OnDisable();
        }
    }
}
