using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSplit.Model
{
    public abstract class WarUnit
    {
        public string Name { get; private set; }
        protected WarUnit(string name)
        {
            Name = name;
        }
        public abstract void AssignCoins(long amount);
    }
}
