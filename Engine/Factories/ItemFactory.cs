﻿using System.Collections.Generic;
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
                new Weapon(1002, "Rusty Sword", 5, 1, 3)
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
