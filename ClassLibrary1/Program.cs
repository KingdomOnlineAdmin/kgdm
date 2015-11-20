using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public class Program
    {
        [DllImport("kernel32.dll")]
        static extern int AllocConsole();

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        static void Main(string[] args)
        {
            while (true)
            {
                AllocConsole();
                Console.WriteLine("Test");
            }
         

        }
    }
}
