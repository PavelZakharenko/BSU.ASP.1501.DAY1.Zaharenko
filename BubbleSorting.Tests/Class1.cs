using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BubbleSorting;
using LibForBubbleSorting;

namespace BubbleSorting.Tests
{
    [TestFixture]
    public class BubbleSorterTests
    {
        [Test]
           public void SortingMaxTestStright()
        {
            int[][] arr =
{
    new int[] {1,3,5,7,9},
    new int[] {0,2,4,6},
    new int[] {11,22}
};
            MAxElement max = new MAxElement(true);
            BubbleSorter.Sorting(arr, max);
            int[][] arr2 =
{
    new int[] {0,2,4,6},
   new int[] {1,3,5,7,9},
    new int[] {11,22}
};
            CollectionAssert.AreEqual(arr2, arr);

        }
        [Test]
        public void SortingMaxTestReverse()
        {
            int[][] arr =
{
    new int[] {1,3,5,7,9},
    new int[] {0,2,4,6},
    new int[] {11,22}
};
            SumElements max = new SumElements(false);
            BubbleSorter.Sorting(arr, max);
            int[][] arr2 =
{
   new int[] {11,22},
   new int[] {1,3,5,7,9},
    new int[] {0,2,4,6}
};
            CollectionAssert.AreEqual(arr2, arr);

        }
        /////////////////////////
        [Test]
        public void SortingSumTestStright()
        {
            int[][] arr =
{
    new int[] {1,3,5,7,9},
    new int[] {0,2,4,6},
    new int[] {11,22}
};
            SumElements max = new SumElements(true);
            BubbleSorter.Sorting(arr, max);
            int[][] arr2 =
{
    new int[] {0,2,4,6},
   new int[] {1,3,5,7,9},
    new int[] {11,22}
};
            CollectionAssert.AreEqual(arr2, arr);

        }
        [Test]
        public void SortingSumTestReverse()
        {
            int[][] arr =
{
    new int[] {1,3,5,7,9},
    new int[] {0,2,4,6},
    new int[] {11,22}
};
            MAxElement max = new MAxElement(false);
            BubbleSorter.Sorting(arr, max);
            int[][] arr2 =
{
   new int[] {11,22},
   new int[] {1,3,5,7,9},
    new int[] {0,2,4,6}
};
            CollectionAssert.AreEqual(arr2, arr);

        }
    }
}
