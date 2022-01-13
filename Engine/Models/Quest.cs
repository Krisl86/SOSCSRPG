using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
    public class Quest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ItemQuantity> ItemsToComplete { get; set; }

        public int XpReward { get; set; }
        public int GoldReward { get; set; }
        public List<ItemQuantity> ItemsReward { get; set; }

        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete, int xpReward, int goldReward, List<ItemQuantity> itemsReward)
        {
            Id = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            XpReward = xpReward;
            GoldReward = goldReward;
            ItemsReward = itemsReward;
        }
    }
}
