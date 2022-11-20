using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;

namespace GameEngine.items
{
    public class ItemData
    {
        public ItemsEnum Item;
        public Armor ArmorItems;
        public int ItemID;
        public string dis;
        public int def;
        public int attackDmg;
        public int BlockChance;
    }
    public struct Items
    {
        public static ItemData Stick()
        {
            ItemData itemData = new()
            {
                Item = ItemsEnum.stick,
                ItemID = (int)ItemsEnum.stick,
                dis = "it's a stick, just a stick",
                attackDmg = 5,
            };
            return itemData;
        }
        public static ItemData Stone()
        {
            ItemData itemData = new()
            {
                Item = ItemsEnum.stone,
                ItemID = (int)ItemsEnum.stone,
                dis = "it's a Stone, just a Stone",
                attackDmg = 7,
            };
            
            return itemData;
        }
        public static ItemData Getflint()
        {
            ItemData itemData = new()
            {
                Item = ItemsEnum.flint,
                ItemID = (int)ItemsEnum.flint,
                dis = "it's a pointy stone ",
                attackDmg = 2,
            };
            return itemData;
        }
        public static ItemData Getironore()
        {
            ItemData itemData = new()
            {
                Item = ItemsEnum.ironore,
                ItemID = (int)ItemsEnum.ironore,
                dis = "raw. raw what? just raw",
                attackDmg = 0,
            };
            return itemData;
        }

        /// <summary>
        /// this function to get the item data of coal
        /// </summary>
        /// <returns>the item data of coal</returns>
        public static ItemData Getcoal()
        {
            ItemData itemData = new()
            {
                Item = ItemsEnum.coal,
                ItemID = (int)ItemsEnum.coal,
                dis = "well let so cook it if it's raw if(meat == ram) cook(100c)",
                attackDmg = 2,
            };
            return itemData;
        }
    }
}
