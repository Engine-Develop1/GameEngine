using System;
using System.Linq;
using System.Globalization;
using GameEngine;
namespace GameEngine.DataBase
{
    class Store
    {
        public string[] NameDataBase;
        public object[] valueDataBase;
    }
    public class DataBase
    {
        //the array Length
        readonly int LEngth = 0xa;
        private int Length;
        Store[] stores;
        int[] index;
        public void SetL(int value)
        {
            Length = value;
            stores = new Store[value];
            for (int i = 0; i < Length; i++)
            {
                stores[i] = new Store();
            }
            for (int i = 0; i < stores.Length; i++)
            {
                stores[i].NameDataBase = new string[LEngth];
                stores[i].valueDataBase = new object[LEngth];
            }
            index = new int[Length];
        }

        private static bool Dev => Settings.dev;
        void WriteData(int DataRow, string name, object val)
        {
            stores[DataRow - 1].NameDataBase[index[DataRow - 1]] = name;
            stores[DataRow - 1].valueDataBase[index[DataRow - 1]] = val;
        }
        public object ReadData(int database, int index)
        {
            return stores[database - 1].valueDataBase[index - 1].ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataRow">is the L on the database</param>
        /// <param name="name">it's the name of the value</param>
        /// <param name="val">it's the value in the database</param>
        public void SetValue(int DataRow, string name, object val)
        {
            object vis;
            if (Settings.PrivateSet == true)
                vis = "#*******XD*#";
            else
                vis = val;
            WriteData(DataRow, name, val);
            if (Dev)
                Console.WriteLine(index[DataRow - 1] + ": " + name + "," + vis + " database:" + DataRow);
            index[DataRow - 1]++;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataRow"></param>
        /// <param name="longstring"></param>
        /// <param name="spiltPoints">the 1 split is the name the 2 is the val</param>
        public void SetValueWarray(int DataRow, string name, string[] longstring)
        {
            object vis;
            for (int i = 0; i < longstring.Length; i++)
            {
                if (Settings.PrivateSet == true)
                    vis = "#*******XD*#";
                else
                    vis = longstring[i];
                WriteData(DataRow, name, longstring[i]);
                if (Dev)
                    Console.WriteLine(index[DataRow - 1] + ": " + name + "," + vis + " database:" + DataRow);
                index[DataRow - 1]++;
            }
        }
    }
}