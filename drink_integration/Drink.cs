using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_integration
{

    public class Drink : AbstractDrink
    {
        protected string _name = "Unknown Drink";
        public Drink(string? name = null)
        {
            if (name != null)
            {
                name = name.Trim();
                if (!string.IsNullOrEmpty(name)) _name = name;
            }
        }
        public override string GetDescr(double weight)
        {
            return $"{_name}: {weight:N2}gs";
        }
        public override double TotalWeight => 0.0;
    }

}
