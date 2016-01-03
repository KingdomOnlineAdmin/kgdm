using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patcher
{
    class Program
    {
        static string searchin;
        static string replacewith; 
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Patcher v0.2: "+args[0]+", "+args[1]+", "+args[2]+", "+args[3]);
            Console.WriteLine("Beginning Patch...");
            searchin = System.IO.File.ReadAllText(args[0]);
            replacewith = System.IO.File.ReadAllText(args[1]);
            string old = System.IO.File.ReadAllText(args[2]);
            string output = args[3];
            if (searchin.Contains(old))
            {
                string newtext = searchin.Replace(old, replacewith);
                System.IO.File.WriteAllText(output, newtext);
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("Failed to find string!");
                System.IO.File.WriteAllText("errorstring", old);
            }
            Console.WriteLine("Done!");

        }
    }
}
