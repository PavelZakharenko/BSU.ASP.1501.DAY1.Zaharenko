using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubbleSorting;

namespace LibForBubbleSorting
{
    public class MAxElement :IComparabe
    {
        bool IsRightOrder=true;
        public MAxElement(bool isRightOrder)
        {
            IsRightOrder = isRightOrder;
        }
        public bool Compare(int[] current,int[] prev)
        {
            if (IsRightOrder)
            {
                if (MaxElem(prev) < MaxElem(current))
                    return true;
                return false;
            }
            if (MaxElem(prev) > MaxElem(current))
                return true;
            return false;

        }
        static int MaxElem(int[] arr)
        {
            int Max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Max < arr[i]) Max = arr[i];
            }
            return Max;
        }
    }
}
