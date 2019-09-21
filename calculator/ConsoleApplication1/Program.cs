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

                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie.");
                Console.WriteLine("5. Exit");
                
                if (menuOption == 3)
                    break;
            }
        }
    }
}
