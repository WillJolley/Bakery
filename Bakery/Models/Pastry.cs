using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Unit { get; set; }

    public Pastry(int unit)
    {
      Unit = unit;
    }
  }
}