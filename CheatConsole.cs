using System;

namespace roguelike_spbu {
    public static class CheatConsole {
        
        public static void Cheat(Engine engine) {
            
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key) {
                case ConsoleKey.H:
                    engine.player.SetHealth(999999);
                    break;
                case ConsoleKey.A:
                    engine.player.Damage = 999999;
                    break;
                case ConsoleKey.K:
                    void foo(Entity entity) {
                        if (entity is Chest) {}
                        else {
                            entity.HealthPoints = -999;
                        }
                    }
                    engine.entities.ForEach(e =>  foo(e));
                    break;
                case ConsoleKey.P:
                    engine.entities.ForEach(e => e.Damage = 0);
                    break;
                case ConsoleKey.V:
                    engine.allVisible = ! engine.allVisible;
                    break;
                case ConsoleKey.M:
                    if (Walkman.IsPlaying) Walkman.Stop();
                    else Walkman.Play();
                    break;
                default:
                    // engine.player.PrimaryForegroundColor = new System.Drawing.Color[] { System.Drawing.Color.Blue, 
                    // System.Drawing.Color.Yellow, System.Drawing.Color.Green, System.Drawing.Color.Red }[new Random().Next(4)];
                    break;

            }
        }
    }
}