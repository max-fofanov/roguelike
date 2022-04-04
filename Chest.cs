using System;
using System.Drawing;

namespace roguelike_spbu
{
    [Serializable]
    public class Chest : Entity
    {
        public Chest(int x, int y) : base(x, y)
        {

            this.SetHealth(1);
            PrimaryForegroundColor = Color.White;
            Symbol = "П";
            Name = "Chest";
            Description = "Chest with items";
            Inventory = new List<Item>() { new Helmet() };
        }
    }
}