using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessert_Choice_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like some dessert?");
            string dessert = (Console.ReadLine());
            if (dessert.Contains("yes") == true)
            {
                Console.WriteLine("Awesome. I'll grab you a dessert menu");
                Console.WriteLine("Here are this option: Rose water rice pudding, Tres Lech cakes, Kulfi, Bread pudding, Beignets");
                string Side = (Console.ReadLine());
                Console.WriteLine($"I will grab {Side} right away");
            }
            else if (dessert.Contains("no") == true)
            {
                Console.WriteLine("No Worries. I'll grab you the check");
             }

            Console.ReadKey();

        }
    }
}
