using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
  public  interface IComparabe
    {
       bool Compare(int[] prev, int[] current);
    }
}
