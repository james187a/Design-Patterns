using System;
using System.Collections.Generic;

namespace Composite.Armor
{
    public class ComplexArmor : BaseArmor, IComplexArmorOperations
    {
        private readonly List<BaseArmor> _piecesOfArmor;

        public ComplexArmor(string name, double weight) : base(name, weight)
        {
            _piecesOfArmor = new List<BaseArmor>();
        }

        public void Add(BaseArmor armor)
        {
            _piecesOfArmor.Add(armor);
        }

        public void Remove(BaseArmor armor)
        {
            _piecesOfArmor.Remove(armor);
        }

        public override double CalculateWeight()
        {
            double total = _weight;

            Console.WriteLine($"{_name} weighs {_weight} Lbs. and contains the following augments with their weights:");

            foreach (var a in _piecesOfArmor)
            {
                total += a.CalculateWeight();
            }

            return total;
        }
    }
}
