using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Loaf { get; set; }
    public int BreadCost { get; set; }
    public List<int> loafList = new List<int> {};

    public Bread(int loaf)
    {
      Loaf = loaf;
      BreadCost = 0;
    }

    public int CalcCost()
    {
      while (Loaf >= 0) 
      {
        loafList.Add(+ Loaf--);
      }

      foreach (int element in loafList)
      {
        loafList.RemoveAll(element % 3 == 0);
        BreadCost += 5;
      }
    }
  }
}