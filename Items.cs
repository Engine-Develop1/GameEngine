using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.items
{
    public class ItemData
    {
        public ItemsEnum Item;
        public int ItemID;
        public string dis;
        public int attackDmg;
    }
    public struct Items
    {
        public static ItemData Stick()
        {
            ItemData itemData = new()
            {
                Item = ItemsEnum.stick,
                ItemID = 0,
                dis = "it's a stick, just a stick",
                attackDmg = 5
            };
            return itemData;
        }
    }
}
