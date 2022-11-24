using System.Runtime.CompilerServices;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
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
        string PathAppdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); 
        //appdata for mac linex and win
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
        public static ConsoleColor consoleColorKey = ConsoleColor.White;
    }
    public class GeneralSystems
    {
        readonly string[] settingCom = { "#set", "#Set", "#Settings", "#settings", "#Setting", "#setting" };
        //the main menu in a string
        string mess = "____________________|Help|____________________" + "\r\n" +
                      "                     |  |                     " + "\r\n" +
                      "                      ||                      " + "\r\n" +
                     @"         Get to setting say ""#Set""!         " + "\r\n" +
                     @"         Get to Start say ""#Start""!         " + "\r\n" +
                     @"         Get to ________ say ""#__""!         " + "\r\n" +
                     @"         Get to ________ say ""#__""!         " + "\r\n" +
                     @"         Get to ________ say ""#__""!         " + "\r\n" +
                      "                                              " + "\r\n" +
                      "                                              ";
        string[] DBmess = {
                      "_____________________|DB|_____________________" + "\r\n",
                      "          Welcome to the Debug meun!          " + "\r\n",
                      "                  What to do                  " + "\r\n",
                     @"                     Get a value(""GetValue"")" + "\r\n",
                     @"Set a value(""SetValue"")                     " + "\r\n",
                     @"                                              " + "\r\n",
                     @"                                              " + "\r\n",
                     @"                                              " + "\r\n",
                      "                                              " + "\r\n"
        };
        public void SetMainMeun(string Text)
        {
            mess = Text;
        }
        /// <summary>
        /// this is the main menu where the player can go settings
        /// </summary>
        public virtual void start(string test)
        {
            //main menu
            //writes the main menu to the console
            Dialog_DataBase.NpcsDiaLog("", ' ', mess);
            Console.Write("test:");
            string User = Dialog_DataBase.GetUserInput();
            //player input
            if (User == "#Set")
            {
                //go to the settings
                GetSet();
            }
            if (User == "#Start")
            {
                update();
            }
        }
        public virtual void update()
        {
            Console.Write("test:");
            string User = Dialog_DataBase.GetUserInput();
            //input
            switch (User)
            {
                default:
                    break;
            }
            if(User == "#DB")
            {
                Dialog_DataBase.NpcsDiaLog("", ' ', "password");
                User = Dialog_DataBase.GetUserInput();
                if(User == "#10231")
                {
                    DeBugMeun();
                }
            }

            //other stuff
        }
        void DeBugMeun()
        {
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[0]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[1]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[2]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[3]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[4]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[5]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[6]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[7]);
            Dialog_DataBase.NpcsDiaLog("", ' ', DBmess[8]);
            string User = Dialog_DataBase.GetUserInput();
            switch (User)
            {
                case "SetValue":
                    break;
            }
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
                              "TextAudio:" + Settings.TextAudio + "\r\n" + 
                              "Text color:" + Settings.consoleColorKey + "\r\n";
                //printing to the console
                Dialog_DataBase.NpcsDiaLog("", '|', mess);
            }
            if (Dialog_DataBase.PlayerInputOptionsWin(StartUserWrite, S_Cha))
            {
                switch (Dialog_DataBase.GetUserInput())
                {
                    case "Musik":
                        break;
                    case "Text color":
                        //get a convert
                        break;
                }
            }
            if (Dialog_DataBase.PlayerInputOptionsWin(StartUserWrite, S_Exit))
            {
                exitSetMenu = true;
            }
            if (exitSetMenu == false)
                GetSet();
        }
    }
}
