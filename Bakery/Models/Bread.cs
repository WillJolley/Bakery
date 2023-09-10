using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Loaf { get; set; }

    public Bread(int loaf)
    {
      Loaf = loaf;
    }
  }
}