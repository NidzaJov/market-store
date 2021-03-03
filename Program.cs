using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DetailsPrinter printer = new DetailsPrinter();
            BronzeCard bronze = new BronzeCard(0);
            SilverCard silver = new SilverCard(600);
            GoldenCard gold = new GoldenCard(1500);
            printer.PrintDetails(bronze, 150);
            printer.PrintDetails(silver, 850);
            printer.PrintDetails(gold, 1300);
            Console.ReadLine();
        }
    }
}
