using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinSplit.Model;

namespace CoinSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var david = new Warrior("David");

            var jack = new Warrior("Jack");
            var pack = new Warrior("Pack");
            var groupA = new Army("Gang of palang", jack, pack);

            var rootGroup = new Army("Group1", david, groupA);
            rootGroup.AssignCoins(500);

            Console.WriteLine(david);
            Console.WriteLine(jack);
            Console.WriteLine(pack);
            Console.ReadLine();
        }
    }
}
