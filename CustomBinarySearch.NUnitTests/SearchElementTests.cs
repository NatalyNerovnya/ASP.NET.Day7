using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomBinarySearch;

namespace CustomBinarySearch.NUnitTests
{
    [TestFixture]
    public class SearchElementTests
    {
        #region Fields
        private Comparison<int> comparerInt = Comparer<int>.Default.Compare;
        private string[] arrString = new string[] { "bike", "flower", "freedom", "sun", "sweats"};
        #endregion

        #region Tests with integer
        public IEnumerable<TestCaseData> BinarySearchIntCaseDatas
        {
            get
            {
                yield return new TestCaseData(new int[] { 2, 5, 7, 9, 12, 43 }, 2).Returns(0);
                yield return new TestCaseData(new int[] { 2, 5, 7, 9, 12, 43 }, 43).Returns(5);
                yield return new TestCaseData(new int[] { 2, 5, 7, 9, 12, 43 }, 7).Returns(2);
                yield return new TestCaseData(new int[] { 2, 5, 7, 9, 12, 43 }, 13).Returns(-1);
                yield return new TestCaseData(null, 43).Throws(typeof(ArgumentNullException));
            }
        }

        [Test, TestCaseSource(nameof(BinarySearchIntCaseDatas))]
        public int BinarySearchTests(int[] arr, int item)
        {
            return SearchElement<int>.BinarySearch(arr,item, comparerInt);
        }
        #endregion

#region Tests with string
        public IEnumerable<TestCaseData> BinarySearchStringCaseDatas
        {
            get
            {
                yield return new TestCaseData(arrString, "bike").Returns(0);
                yield return new TestCaseData(arrString, "sweats").Returns(4);
                yield return new TestCaseData(arrString, "freedom").Returns(2);
                yield return new TestCaseData(arrString, "home task").Returns(-1);
                yield return new TestCaseData(new string[] { "freedom" }, "freedom").Returns(0);
                yield return new TestCaseData(new string[] { "freedom" }, "university").Returns(-1);
                yield return new TestCaseData(null, "freedom").Throws(typeof(ArgumentNullException));
                yield return new TestCaseData(new string[] { }, "energy").Throws(typeof(ArgumentException));


            }
        }

        [Test, TestCaseSource(nameof(BinarySearchStringCaseDatas))]
        public int BinarySearchStringTests(string[] arr, string item)
        {
            return SearchElement<string>.BinarySearch(arr, item);
        }
#endregion
    }
}
