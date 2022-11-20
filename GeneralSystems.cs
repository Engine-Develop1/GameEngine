using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.NpcDialog;

namespace GameEngine
{
    public class Settings
    {
        public static int VolMusik;
        public static int VolSound;
        public static bool autoSave;
        public static bool TextAudio;
        //program exit value
        public static bool Stop = false;
        public static bool PrivateSet = false;
        public static bool dev = false;
        public static bool IsMetric = RegionInfo.CurrentRegion.IsMetric;
        public static DayOfWeek FirstDayOfWeek = DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek;
    }
    public class GeneralSystems
    {
        readonly string[] settingCom = { "set", "Set", "Settings", "settings", "Setting", "setting" };
        /// <summary>
        /// this is the main menu where the player can go settings
        /// </summary>
        public void start()
        {
            //main menu
            if (Dialog_DataBase.PlayerInputOptions(Console.ReadLine(), settingCom))
            {
                if (Dialog_DataBase.PlayerInputOptions(Console.ReadLine(), "help"))
                {
                    //the main menu in a string
                    string mess = "____________________|Help|____________________" + "\r\n" +
                                  "                     |  |                     " + "\r\n" +
                                  "                      ||                      " + "\r\n" +
                                 @"          Get to setting say ""Set""          " + "\r\n" +
                                 @"          Get to Start say ""Start""          " + "\r\n" +
                                 @"          Get to ________ say ""__""          " + "\r\n" +
                                 @"          Get to ________ say ""__""          " + "\r\n" +
                                 @"          Get to ________ say ""__""          " + "\r\n" +
                                  "                                              " + "\r\n" +
                                  "                                              ";
                    //writes the main menu to the console
                    Dialog_DataBase.NpcsDiaLog("", ' ', mess);
                    //player input
                    if(Dialog_DataBase.PlayerInputOptionsWin("=>:", "Set"))
                    {
                        //go to the settings
                        GetSet();
                    }
                    if(Dialog_DataBase.PlayerInputOptionsWin("=>:", "Start"))
                    {

                    }

                }
            }
        }
        public void update()
        {
            //input

            if(Dialog_DataBase.PlayerInputOptions(Console.ReadLine(),"hello"))
            {
                Dialog_DataBase.NpcsDiaLog("system", ':', "ok");
            }

            //other stuff
        }
        //stops the program with no error code
        public void StopProgram()
        {
            Settings.Stop = true;
        }
        //stops the program with an error code
        public void StopProgram(string Code)
        {
            Dialog_DataBase.NpcsDiaLog("", ' ', "there happend something." +
                "\r\n the you will see an error code, \r\n" +
                "go on the github repository and write an issue with the error code as the title, and write what happend before the crash \r\n" +
                Code);
            Settings.Stop = true;
        }
        /// <summary>
        /// the player can see the settings and more
        /// </summary>
        void GetSet()
        {
            //seting all the player input op
            string[] S_What = { "what", "What" };
            string[] S_Cha = { "Set new", "set new", "set New", "Set New", "SN", "sn", "change", "Change", "set", "Set" };
            string[] S_Exit = { "Exit menu", "exit menu", "exit Menu", "Exit Menu", "Exit", "exit" };
            //so the player can exit the settings menu
            bool exitSetMenu = false;
            //this will be if the player can do an input
            string StartUserWrite = "=-:";
            //player input asking for what settings there are and printing it to the console
            if (Dialog_DataBase.PlayerInputOptionsWin(StartUserWrite, S_What))
            {
                //all the settings the player can chanage
                string mess = "you can change this \r\n" +
                              "VolMusik:" + Settings.VolMusik + "\r\n" +
                              "VolSound:" + Settings.VolSound + "\r\n" +
                              "autoSave:" + Settings.autoSave + "\r\n" +
                              "TextAudio:" + Settings.TextAudio + "\r\n";
                //printing to the console
                Dialog_DataBase.NpcsDiaLog("", '|', mess);
            }
            if (Dialog_DataBase.PlayerInputOptionsWin(StartUserWrite, S_Cha))
            {

            }
            if(Dialog_DataBase.PlayerInputOptionsWin(StartUserWrite,S_Exit))
            {
                exitSetMenu = true;
            }
            if(exitSetMenu == false)
                GetSet();
        }
    }
}
