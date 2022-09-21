using System;

namespace Composite.Armor
{
    public class PrimitiveArmor : BaseArmor
    {
        public PrimitiveArmor(string name, double weight) : base(name, weight)
        {
        }

        public override double CalculateWeight()
        {
            Console.WriteLine($"{_name} weighs {_weight} Lbs.");

            return _weight;
        }
    }
}