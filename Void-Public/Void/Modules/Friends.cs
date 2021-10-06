#region

using System;
using System.Threading;
using Microsoft.VisualBasic;
using Void.ClientBase;

#endregion

namespace Void.Modules
{
    internal class Friends : Module
    {
        public Friends() : base("Friends", (char)0x07)
        {
        } // Not defined

        public override void OnEnable()
        {
            new Thread(() =>
            {
                var VoidAction = Interaction.InputBox("Please enter action (remove/add/list)", "Void (Friends)")
                    .ToLower();

                if (VoidAction == "list")
                {
                    foreach (var str in Game.CustomDefines.friends)
                        Console.WriteLine(str);
                    return;
                }

                var username = Interaction.InputBox("Please enter player username", "Void (Friends)").ToLower();

                if (VoidAction != "remove")
                {
                    if (VoidAction != "add") return;
                    Game.CustomDefines.friends.Add(username);
                    return;
                }

                for (var index = 0; index < Game.CustomDefines.friends.Count; index++)
                {
                    var str = Game.CustomDefines.friends[index];
                    if (username == str)
                        Game.CustomDefines.friends.Remove(str);
                }
            }).Start();
        }
    }
}