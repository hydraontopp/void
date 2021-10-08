#region

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace Void.Modules
{
    internal class Welcome : Module // due to set person (superlupita#4062), (552396139232624640) you now have to include this extra annoying module!
    {
        public Welcome() : base("Welcome", (char)0x07, "Other", true)
        {
        } // 0x07 = no keybind

        public override void OnEnable()
        {
            Console.Clear();
            Console.WriteLine("--- Links ---\r\n" +
                "Void Utility: \r\n" +
                "discord.gg/TWVMz53D5H\r\n" +
                "Hydra Hub: \r\n" +
                "discord.gg/jHYB2GZQpg");
        }
    }
}