using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Interfaces;
using task1.Models;
using task1.Enums;
using task1.Models.Candies;
using task1.Models.Waffels;
using task1.Models.Zephyrs;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfectionery confectionery1 = new Znichka();
            IConfectionery confectionery2 = new Stolichnyye();
            IConfectionery confectionery3 = new StroopWaffel();
            IConfectionery confectionery4 = new Zemlyanichnyy();

            IGift gift = new Gift();
            gift.Add(confectionery1);
            gift.Add(confectionery2);
            gift.Add(confectionery3);
            gift.Add(confectionery4);

            Console.WriteLine("Gift:");
            Console.WriteLine(gift);

            Console.WriteLine("Total weight:");
            Console.WriteLine(gift.Weight);
            Console.WriteLine();


            gift.OrderByDescending(x => x.Name);
            Console.WriteLine("Gift after sorting by name:");
            Console.WriteLine(gift);

            int min = 40;
            int max = 50;
            var result = gift.FindBySugarWeight(min, max);
            IGift resultGift = new Gift();
            resultGift.AddRange(result);
            Console.WriteLine($"Confectioneries with sugar weight between {min} and {max}");
            Console.WriteLine(resultGift);

            Console.ReadKey();
        }
    }
}
