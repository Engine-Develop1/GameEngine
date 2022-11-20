using System;

namespace GameEngine.NpcDialog
{
    public struct Dialog_DataBase
    {
        
        public static bool PlayerInputOptions(string user, string input)
        {
            if (user == input)
                return true;
            else
                return false;
        }
        public static bool PlayerInputOptionsWin(string inputFelt, string input)
        {
            Console.Write(inputFelt);
            if (Console.ReadLine() == input)
                return true;
            else
                return false;
        }
        public static bool PlayerInputOptionsWin(string inputFelt, string[] input)
        {
            Console.Write(inputFelt);
            string User = Console.ReadLine();
            bool re = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (User == input[i])
                    re = true;
                else
                    re = false;
            }
            return re;
        }
        public static bool PlayerInputOptions(string user, string[] input)
        {
            bool re = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (user == input[i])
                    re = true;
                else
                    re = false;
            }
            return re;
        }
        public static void NpcsDiaLog(string name, char format, string Mess)
        {
            Console.WriteLine(name + format + Mess);
        }
        public static string RandomSayLine(string[] lines, int min, int max)
        {
            Random random = new();
            return lines[random.Next(min, max)];
        }
        public static void NotItemCon()
        {
            Console.WriteLine("you do not have enough of this");
        }
    }
}