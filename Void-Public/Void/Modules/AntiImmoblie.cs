﻿#region

using Void.ClientBase;

#endregion

namespace Void.Modules
{
    internal class AntiImmoblie : Module
    {
        public AntiImmoblie() : base("AntiImmoblie", (char)0x07, "Exploits")
        {
        } // Not defined

        public override void OnEnable()
        {
            MCM.writeBaseBytes(0x1CAEB90, MCM.ceByte2Bytes("90 90")); // nop anti immobile address
            base.OnEnable();
        }

        public override void OnDisable()
        {
            MCM.writeBaseBytes(0x1CAEB90, MCM.ceByte2Bytes("75 16")); // restore anti immobile address
            base.OnDisable();
        }
    }
}