Void#region

using System.Diagnostics;

#endregion

namespace Void.Modules
{
    internal class KillGame : Module
    {
        public KillGame() : base("KillGame", (char)0x07)
        {
        } // Not defined

        public override void OnEnable()
        {
            Process.GetProcessesByName("ApplicationFrameHost")[0].Kill();
            Process.GetProcessesByName("Minecraft.Windows")[0].Kill();
            Program.quit = true;
        }
    }
}