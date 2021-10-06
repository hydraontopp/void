#region

using System.Linq;
using System.Threading;
using Microsoft.VisualBasic;
using Void.ClientBase;

#endregion

namespace Void.Modules
{
    internal class PlayerTP : Module
    {
        public PlayerTP() : base("PlayerTP", (char)0x07, "Exploits")
        {
        } // Not defined

        public override void OnEnable()
        {
            new Thread(() =>
            {
                var username = Interaction.InputBox("Please enter player username", "Void (PlayerTP)").ToLower();

                foreach (var entity in Game.getPlayers().Where(entity => entity.username.ToLower().Contains(username)))
                {
                    Game.position = entity.position;
                    break;
                }
            }).Start();
        }
    }
}