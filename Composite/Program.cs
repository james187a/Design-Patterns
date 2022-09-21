using System;
using Composite.Armor;

namespace Composite
{
    public class Program
    {
        public static void Main()
        {
            var armorSet = new ComplexArmor("Armor Set", 0);
            var helmet = new ComplexArmor("Helmet", 3.5);
            armorSet.Add(helmet);
            var breastplate = new ComplexArmor("Breastplate", 10.1);
            armorSet.Add(breastplate);
            var shield = new ComplexArmor("Shield", 6.3);
            armorSet.Add(shield);
            var earrings = new PrimitiveArmor("Earrings", 0.5);
            armorSet.Add(earrings);
            var shinyAugment = new PrimitiveArmor("Shiny Augment", 0);
            shield.Add(shinyAugment);
            var sparklyAugment = new PrimitiveArmor("Sparkly Augment", 0);
            helmet.Add(sparklyAugment);

            Console.WriteLine($"Total weight of this set of armor is: {armorSet.CalculateWeight()}");
        }
    }
}