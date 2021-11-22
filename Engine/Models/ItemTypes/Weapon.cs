using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Models.ItemTypes
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; private set; }
        public int MaximumDamage { get; private set; }

        public Weapon(int itemTypeId, string itemName, int itemPrice, int minimumDamage, int maximumDamage)
               : base(itemTypeId, itemName, itemPrice)
        {
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
        }

        public override GameItem Clone()
        {
            return new Weapon(this.ItemTypeId, this.ItemName, this.ItemPrice, this.MinimumDamage, this.MaximumDamage);
        }
    }
}
