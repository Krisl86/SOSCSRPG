using System.Collections.Generic;
using System.Linq;
using Engine.Models;
using Engine.Models.ItemTypes;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>
            {
                new Weapon(1001, "Pointy Stick", 1, 1, 2),
                new Weapon(1002, "Rusty Sword", 5, 1, 3),
                new GameItem(9001, "Snake Fang", 1),
                new GameItem(9002, "Snakefin", 2),
                new GameItem(9003, "Rat tail", 1),
                new GameItem(9004, "Rat fur", 2),
                new GameItem(9005, "Spider fang", 1),
                new GameItem(9006, "Spider silk", 2)
            };

        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem standardGameItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeId == itemTypeId);

            if (standardGameItem != null)
            {
                return standardGameItem.Clone();
            }
            return null;
        }
    }
}
