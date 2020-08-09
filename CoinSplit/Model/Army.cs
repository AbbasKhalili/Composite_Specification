using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSplit.Model
{
    public class Army : WarUnit
    {
        public List<WarUnit> _units;
        public Army(string name, params WarUnit[] units) : base(name)
        {
            this._units = units.ToList();
        }

        public override void AssignCoins(long coinAmount)
        {
            var eachShare = coinAmount / this._units.Count;
            this._units.ForEach(a=> a.AssignCoins(eachShare));
        }
    }
}
