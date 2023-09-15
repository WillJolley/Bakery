using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Unit { get; set; }
    public int PastryCost { get; set; }
    public List<int> pastryList = new List <int> {};

    public Pastry(int unit)
    {
      Unit = unit;
      PastryCost = 0;
    }

    public int CalcCost()
    {
      while (Unit >= 0) 
      {
        pastryList.Add(+ Unit--);
      }

      pastryList.RemoveAll(element => element % 4 == 0);

      foreach (int element in pastryList)
      {
        PastryCost += 2;
      }

      return PastryCost;
    }
  }
}