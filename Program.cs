using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_statements_in_C_.pptx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can vote.");
            }
            else
            { 
                Console.WriteLine("You cannot vote.");
            }
            Console.ReadLine();
        }
    }
}
