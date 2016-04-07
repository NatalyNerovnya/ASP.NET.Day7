using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinarySearch
{
    public class BinarySearch<T>
    {
        #region Private Methods
        private static bool IsSorted(T[] arr, Comparison<T> comparer)
        {
            bool isGreater = comparer(arr[0], arr[1]) >= 0;
            for (int i = 1; i < arr.Length;)
            {
                if (comparer(arr[i], arr[i++]) >= 0 != isGreater)
                    return false;
            }
            return true;
        }

       private static int Search(T[] arr, T item, Comparison<T> comparer = null)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (comparer == null)
                comparer = Comparer<T>.Default.Compare;
            if (IsSorted(arr, comparer) == false)
                throw new ArgumentException();


            int low = 0, high = arr.Length;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (comparer(item, arr[mid]) == 0)
                    return mid;

                if (comparer(item, arr[mid]) >= 0)
                    low = mid + 1;
                else
                    high = mid;
            }
            return -1;
        }
#endregion
    }
}
