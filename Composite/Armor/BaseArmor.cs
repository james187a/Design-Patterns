namespace Composite.Armor
{
    public abstract class BaseArmor
    {
        protected string _name;
        protected double _weight;

        public BaseArmor(string name, double weight)
        {
            _name = name;
            _weight = weight;
        }

        public abstract double CalculateWeight();
    }
}