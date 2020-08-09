using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSplit.Model
{
    public class Warrior : WarUnit
    {
        public long CoinAmount { get;private set; }
        public Warrior(string name) : base(name)
        {
        }

        public override void AssignCoins(long coins)
        {
            this.CoinAmount = coins;
        }

        public override string ToString()
        {
            return $"I'm {Name} and i have {this.CoinAmount} coins !";
        }
    }
}
