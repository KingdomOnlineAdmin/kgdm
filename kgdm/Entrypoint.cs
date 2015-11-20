using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace kgdm
{


    public class Entrypoint
    {
        [DllImport("kernel32.dll")]
        static extern int AllocConsole();

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        public static FileStream ostrm;
        public static StreamWriter writer;

        static string Gamestate;
        public static void Show()
        {
            AttachConsole(-1);
            AllocConsole();
            //this is not working, console is displayed but text is not written to the console. 
            
        }
        
        static List<object> datalist = new List<object>();
        static object recieved;
        public static void SendValue(object variblevalue)
        {
            recieved = variblevalue;
            datalist.Add(recieved);
        }

        /// <summary>
        /// This method is called from Game.Update in Assembly-CSharp,
        /// basicly the point is that you can run code in a method that will be
        /// updated as the game is updated. 
        /// </summary>

        static string lgs = "";
        public static void Update()
        {
            


            if(Convert.ToString(recieved) == "Game"||Convert.ToString(recieved) == "Paused")
            {
                Gamestate = Convert.ToString(recieved);
                File.WriteAllText("Gamestate.txt", Gamestate);
 

            }
        }
        public static int GetProcessIdByName(string name)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == name)
                {
                    return p.Id;
                }
                return -1;
            }
            return -1;
        }
    }
}
