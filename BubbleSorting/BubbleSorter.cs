using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    public class BubbleSorter
    {
        delegate int ToS(int[] arr);
        delegate bool OrS(int a, int b);
        public static void Sorting(int[][] arr,IComparabe comp)
        {
            int capacity = PreSorting(arr);
           
            for (int i = 0; i < capacity; i++)
            {
                for (int j = capacity - 1; j > i; j--)
                {
                    if(comp.Compare(arr[j-1],arr[j]))
                   // if (op(O(arr[j]), O(arr[j - 1])))
                    {

                        int[] ar = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = ar;
                    }
                }
            }

        }

        static int PreSorting(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j - 1] == null && arr[j] != null)
                    {
                        int[] ar = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = ar;
                    }
                }
            }
            int C = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null) C++;
            }
            return C;
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
        static int MinElem(int[] arr)
        {
            int Min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Min < arr[i]) Min = arr[i];
            }
            return Min;
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
        static bool CompR(int a, int b)
        {
            return a > b;
        }
        static bool CompS(int a, int b)
        {
            return a < b;
        }

    }
    public enum Order
    {
        Inverse,
        Straight
    }
    public enum TypeOfSort
    {
        Min,
        Max,
        Summ
    }
}
