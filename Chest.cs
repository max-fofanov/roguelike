using System;
using System.Drawing;

namespace roguelike_spbu
{
    public class Chest : Entity
    {
        public Chest(int x, int y) : base(x, y)
        {
            List<Item> items = new List<Item>();
                items.Add( new SwordOneHanded());
                items.Add( new BastardSword() );
                items.Add( new TwoHandedSword());
                items.Add( new Rapier());
                items.Add( new Aerondight());
                items.Add( new Dager());
                items.Add( new Frostmourne());
                items.Add( new Mjolnir());
                items.Add( new CrossBow());
                items.Add( new Bow());
                items.Add( new Vijaya());
                items.Add( new MagicBolt());
                items.Add( new Lifesteal());
                items.Add( new Flamestrike());
                items.Add( new MagicLince());
                items.Add( new MagicStrike());
                items.Add( new EnchantedAxe());
                items.Add( new Mace());
                items.Add( new Spear());
                items.Add( new LanceOfLonginus());
                items.Add( new Shield());
                items.Add( new Buckler());
                items.Add( new BigShield());
                items.Add( new UltimateShield());
                items.Add( new Aegis());
                items.Add( new LeatherArmor());
                items.Add( new ChainArmor());
                items.Add( new PlateArmor());
                items.Add( new EnchantedMithrilArmor());
                items.Add( new MoonguardPlate());

            this.SetHealth(1);
            PrimaryForegroundColor = Color.White;
            Symbol = "П";
            Name = "Chest";
            Description = "Chest with items";
            float[] itemschance = {30 - GameInfo.player.LVL * 2, 20 - GameInfo.player.LVL, 15 - GameInfo.player.LVL, 20 - GameInfo.player.LVL, -6 + GameInfo.player.LVL, 1 + 2 * GameInfo.player.LVL, -7 + GameInfo.player.LVL, -7 + GameInfo.player.LVL, 3 + GameInfo.player.LVL, 30 - 2 * GameInfo.player.LVL, -10 + GameInfo.player.LVL, Math.Min(3* GameInfo.player.LVL, 30), 2 + GameInfo.player.LVL, GameInfo.player.LVL, GameInfo.player.LVL + 10, -3 + GameInfo.player.LVL, GameInfo.player.LVL, 25, GameInfo.player.LVL + 5, -6 + GameInfo.player.LVL, 25 - GameInfo.player.LVL, 10, 5 + GameInfo.player.LVL, 25, -5 + GameInfo.player.LVL, 25 - GameInfo.player.LVL * 3, 15, GameInfo.player.LVL, -3 + GameInfo.player.LVL, -6 +GameInfo.player.LVL};
            Item tmp = items[Walker.Alias(itemschance)];
            Inventory = new List<Item>() { tmp };
        }
    }
}