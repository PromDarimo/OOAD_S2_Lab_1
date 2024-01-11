using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_integration
{
    public  abstract class AbstractDrink
    {
        public abstract double TotalWeight { get; }
        public abstract string GetDescr(double weight);
        public string Descr => GetDescr(TotalWeight);
    }
}
