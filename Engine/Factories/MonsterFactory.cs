using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        private static List<Monster> _monsters;
        private static Random _random;

        static MonsterFactory()
        {
            // Generating monsters
            _monsters = new List<Monster>()
            {
                new Monster("Snake", "Snake.png", 4, 4, 5, 1),
                new Monster("Rat", "Rat.png", 5, 5, 5, 1),
                new Monster("Giant Spider", "GiantSpider.png", 10, 10, 10, 3)
            };

            _random = new Random();

            // Giving monsters items

            // First monster
            AddLootItems(_monsters[0], 9001, 25);
            AddLootItems(_monsters[0], 9002, 75);
            // Second monster
            AddLootItems(_monsters[1], 9003, 25);
            AddLootItems(_monsters[1], 9004, 75);
            // Third...
            AddLootItems(_monsters[2], 9005, 25);
            AddLootItems(_monsters[2], 9006, 75);

        }

        public static Monster GetMonsterById(int monsterId)
        {
            try
            {
                return _monsters[monsterId];
            }
            catch
            {
                throw new IndexOutOfRangeException("Monster type ID doesn't exist");
            }
        }

        static void AddLootItems(Monster monster, int itemId, int percentageChance)
        {
            if (_random.Next(1, 101) <= percentageChance)
            {
                monster.Inventory.Add(new ItemQuantity(itemId, 1));
            }
        }
    }
}
