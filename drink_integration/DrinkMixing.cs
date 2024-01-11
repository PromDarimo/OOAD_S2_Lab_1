using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_integration
{

    public abstract class DrinkMixing : AbstractDrink
    {
        protected AbstractDrink _drink = default!;
        protected string _name = "";
        protected double _weight = 0.0;

        public DrinkMixing(AbstractDrink drink)
        {
            _drink = drink;
        }
        public override string GetDescr(double weight)
        {
            if (_drink == null) return "";
            return _drink.GetDescr(weight);
        }
        public override double TotalWeight => _drink.TotalWeight + _weight;
    }

}
