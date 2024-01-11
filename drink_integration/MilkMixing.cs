namespace drink_integration
{
    public class MilkMixing : DrinkMixing
    {
        public MilkMixing(string name, double weight, AbstractDrink drink)
        : base(drink)
        {
            _name = name.Trim();
            if (string.IsNullOrEmpty(_name)) _name = "Unknown Drink";
            _weight = weight;
        }
        public override string GetDescr(double weight)
        {
            double per = 0.0;
            if (weight != 0) per = _weight / weight;
            string temp = base.GetDescr(weight).Trim();
            if (!string.IsNullOrEmpty(temp)) temp += Environment.NewLine;
            return $"{temp}+Coffee({_name}, {_weight:N2}gs, {per:P2})";
        }
    }

}
