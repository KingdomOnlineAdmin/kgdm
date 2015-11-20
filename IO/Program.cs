using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using kgdm;

namespace IO
{
    public class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32.dll")]
        static extern int AllocConsole();

        public static int KingdomID;
        static void Main(string[] args)
        {
            KingdomID = GetProcessIdByName("Kingdom");
            

            while (true)
            {
                AttachConsole(KingdomID);
                AllocConsole();
                Console.WriteLine("Loaded Console");
            }
            
        }
        public static int GetProcessIdByName(string name)
        {
            foreach(Process p in Process.GetProcesses())
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
