using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("__________Bienvenue à le boulangerie de Pierre____________");
      Console.WriteLine("At this bakery, we offer pastries and loaves of bread.");
      Console.WriteLine("Bread costs $5 a loaf, and for every 2 loaves you buy, we throw in a third one for free!");
      Console.WriteLine("Pastries cost $2 each, and for every 3 pastries you buy, we throw in a fourth one for free!");
      Console.WriteLine("How many loaves of bread would you like to purchase?");
      string breadOrder = Console.ReadLine();
      Console.WriteLine("How many pastries would you like to purchase?");
      string pastryOrder = Console.ReadLine();
      int loaf = int.Parse(breadOrder);
      int unit = int.Parse(pastryOrder);
      Bread bread = new Bread(loaf);
      Pastry pastry = new Pastry(unit);
      bread.CalcCost();
      pastry.CalcCost();
      Console.WriteLine($"Your total will be: ${bread.BreadCost + pastry.PastryCost}");
    }
  }
}