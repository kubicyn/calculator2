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
                Console.WriteLine("1000. Dodaj");
                Console.WriteLine("999. Odejmij");
                Console.WriteLine("3. Integration");
                int menuOption = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("3000. Mnożenie");
                Console.WriteLine("40000. Dzielenie.");
                Console.WriteLine("5. Exit");
                
                if (menuOption == 5)
                    break;
            }
        }
    }
}
