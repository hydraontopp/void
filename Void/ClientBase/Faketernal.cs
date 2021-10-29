﻿#region

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Void.ClientBase.FaketernalBase;
using Void.ClientBase.KeyBase;
using Void.ClientBase.VersionBase;

#endregion

namespace Void.ClientBase
{
    internal class Faketernal
    {
        public static class ClientObj // most of this has been removed because i need to update the pointers and im to tired rn so
        {
            // removed code from here
        }

        public static class Potions
        {
            public static bool destroy = false;

            public static void ClearActions()
            {
                destroy = true;
                Thread.Sleep(10);
                destroy = false;
            }

            public static void CreateAction(Action<int, int> actionTick, iRGB effectColor, int time = 30, int strength = 1, float fov = 1, Action actionExit = null)
            {
                bool effectActive = true;
                int timeLeft = time;
                Game.effectsColor = effectColor;
                Task.Run(() => {
                    Game.setFieldOfView(fov);
                    while (!destroy && effectActive)
                    {
                        actionTick(strength, strength);
                        Game.effectsColor = effectColor; // so the effects flicker when mixed
                    }
                    Game.effectsColor = new iRGB(0, 0, 0, 0);
                    Game.setFieldOfView(1f);

                    if (actionExit != null)
                        actionExit();
                });
                Task.Run(() => {
                    for (int i = 0; i < time; ++i)
                    {
                        Thread.Sleep(1000); // delay a second
                        timeLeft = i;
                    }
                    effectActive = false;
                });
            }
        }

        public static class Utils
        {
            public static float NextFloat(float min, float max)
            {
                var random = new Random();
                var val = random.NextDouble() * (max - min) + min;
                return (float)val;
            }
        }
    }
}