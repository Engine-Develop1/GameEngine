using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.items;

namespace GameEngine.Inv
{
    public class InvSystem
    {
        const int InvSpace = 10;
        public ItemData[] ItemsInv = new ItemData[InvSpace];
        public int[] ConInv = new int[InvSpace];
        public int InvIndex;
        public ItemData[] EquipedItems = new ItemData[8];
        public string GetArmorData()
        {
            return CodeQ.ForLoopData(EquipedItems, 5, true);
        }
        public string GetEquipedData()
        {
            return "you have " + GetArmorData() + "on";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="slot">
        /// the slot is for what Equipment slot you will put it in
        /// </param>
        public void EquipItem(ItemData item, int slot)
        {
            if (item.ArmorItems != EquipedItems[slot].ArmorItems)
            {
                EquipedItems[slot] = item;
                //take the item from inv
            }
            else
                NpcDialog.Dialog_DataBase.NpcsDiaLog("System", ':', "you have that item equip");
        }
        public int FindItemIndexInInv(ItemsEnum item)
        {
            int index = 0;
            for (int i = 0; i < InvSpace; i++)
            {
                if (ItemsInv[i].Item == item)
                    index = i;

            }
            return index;
        }
        public void TakeItemFromInv(ItemData itemData, int con)
        {
            for (int i = 0; i < InvSpace; i++)
            {
                if (ItemsInv[i].Item == itemData.Item)
                {
                    ConInv[i] -= con;
                }
                else
                {
                    if (InvIndex != InvSpace)
                    {
                        if (ConInv[i] < con)
                        {
                            NpcDialog.Dialog_DataBase.NotItemCon();
                        }
                        else
                        {
                            InvIndex++;
                            ConInv[InvIndex] -= con;
                        }
                    }
                }
            }
        }
        public void AddItemToInv(ItemData itemData,int con)
        {
            for (int i = 0; i < InvSpace; i++)
            {
                if(ItemsInv[i].Item == itemData.Item)
                {
                    ConInv[i] += con;
                }
                else
                {
                    if (InvIndex != InvSpace)
                    {
                        ItemsInv[InvIndex] = itemData;
                        ConInv[InvIndex] += con;
                        InvIndex++;
                    }
                }
            }
        }
    }
}
