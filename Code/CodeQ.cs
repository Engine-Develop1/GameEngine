using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public struct CodeQ
    {
        public static string ForLoopData(Object[] array, bool withNL)
        {
            string re = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (withNL == true)
                    re = array[i] + "\r\n";
                else
                    re = array[i].ToString();
            }
            return re;
        }
        public static string ForLoopData(Object[] array, int Length, bool withNL)
        {
            string re = "";
            for (int i = 0; i < Length; i++)
            {
                if (withNL == true)
                    re = array[i] + "\r\n";
                else
                    re = array[i].ToString();
            }
            return re;
        }
    }
}
