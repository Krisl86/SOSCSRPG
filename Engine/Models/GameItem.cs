using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeId { get; protected set; }
        public string ItemName { get; protected set; }
        public int ItemPrice { get; protected set; }

        public GameItem(int itemTypeId, string itemName, int itemPrice)
        {
            this.ItemTypeId = itemTypeId;
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
        }

        public virtual GameItem Clone()
        {
            return new GameItem(this.ItemTypeId, this.ItemName, this.ItemPrice);

        }
    }
}
