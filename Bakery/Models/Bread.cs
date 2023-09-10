using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Loaf { get; set; }
    public List<int> loafList = new List<int> {};

    public Bread(int loaf, int breadCost)
    {
      Loaf = loaf;
      this.breadCost = 0;
    }

    public int CalcCost()
    {
      while (this.loaf >= 0) 
      {
        loafList.Add(+ this.loaf--);
      }

      loafList.RemoveAll(element % 3 == 0);

      foreach (int element in loafList)
      {
        this.breadCost += 5;
      }
    }
  }
}