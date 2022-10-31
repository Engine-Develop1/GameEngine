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
        public void GiveItemToInv(ItemData itemData,int con)
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
