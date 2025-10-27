using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_Output_in_C_.pptx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
    }
}
