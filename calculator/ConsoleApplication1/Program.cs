using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Dodaj");
                Console.WriteLine("2. Odejmij");
                Console.WriteLine("3. Integration");
                int menuOption = Convert.ToInt16(Console.ReadLine());
                if (menuOption == 3)
                    break;
            }
        }
    }
}
