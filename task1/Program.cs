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
            IConfectionery sweet1 = new Znichka();
            IConfectionery sweet2 = new Stolichnyye();
            IConfectionery sweet3 = new StroopWaffel();
            IConfectionery sweet4 = new Zemlyanichnyy();

            IGift gift = new Gift();
            gift.Add(sweet1);
            gift.Add(sweet2);
            gift.Add(sweet3);
            gift.Add(sweet4);

            gift.OrderByDesceding(x => x.Name);

            ChocolateCandy candy1 = new Znichka();
            ChocolateCandy candy2 = new Stolichnyye();
            Console.WriteLine(candy1.Calorie);
            Console.WriteLine(candy2.Calorie);
        }
    }
}
