using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubbleSorting;

namespace LibForBubbleSorting
{
  public  class SumElements: IComparabe
    {
        bool IsRightOrder;
        public SumElements(bool isRightOrder)
        {
            IsRightOrder = isRightOrder;
        }
        public bool Compare(int[] current, int[] prev)
        {
            if (IsRightOrder)
            {
                if (SummArr(prev) < SummArr(current))
                    return true;
                return false;
            }
            if (SummArr(prev) > SummArr(current))
                return true;
            return false;

        }
        static int SummArr(int[] arr)
        {
            int Summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Summ += arr[i];
            }
            return Summ;
        }
    }
}
