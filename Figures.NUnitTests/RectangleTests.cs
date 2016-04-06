using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Figures;
using NUnit.Framework;

namespace Figures.NUnitTests
{
    public class RectangleTests
    {
        #region Constructor tests
        public IEnumerable<TestCaseData> ConstructorTestData
        {
            get
            {
                yield return new TestCaseData(10, 3).Returns(new Rectangle(10, 3));
                yield return new TestCaseData(0, 3).Throws(typeof(ArgumentException));
                yield return new TestCaseData(12, -4).Throws(typeof(ArgumentException));
                yield return new TestCaseData(double.NaN, 2).Throws(typeof(ArgumentException));
                yield return new TestCaseData(1, double.PositiveInfinity).Throws(typeof(ArgumentException));
                yield return new TestCaseData(double.NegativeInfinity, 3).Throws(typeof(ArgumentException));

            }
        }

        [Test, TestCaseSource(nameof(ConstructorTestData))]
        public Rectangle Rectangle_Constructors_Tests(double a, double b)
        {
            return new Rectangle(a, b);
        }
        #endregion

        #region Area tests

        public IEnumerable<TestCaseData> AreaTestData
        {
            get
            {
                yield return new TestCaseData(new Rectangle(2, 6)).Returns(12);
                yield return new TestCaseData(new Rectangle(1, 13)).Returns(13);
            }
        }
        [Test, TestCaseSource(nameof(AreaTestData))]
        public double TestArea(Rectangle rec)
        {
            return rec.Area();
        }
        #endregion

        #region Perimetr tests
        public IEnumerable<TestCaseData> PerimetrTestData
        {
            get
            {
                yield return new TestCaseData(new Rectangle(2, 6)).Returns(16);
                yield return new TestCaseData(new Rectangle(1, 13)).Returns(28);
            }
        }
        [Test, TestCaseSource(nameof(PerimetrTestData))]
        public double TestPerimetr(Rectangle rec)
        {
            return rec.Perimeter();
        }
        #endregion

        #region Diagonal tests

        public IEnumerable<TestCaseData> DiagonalTestData
        {
            get
            {
                yield return new TestCaseData(new Rectangle(2,4)).Returns(Math.Pow(20,0.5));
                yield return new TestCaseData(new Rectangle(3, 6)).Returns(Math.Pow(45, 0.5));
            }
        }

        [Test, TestCaseSource(nameof(DiagonalTestData))]
        public double GetDiagonalTests(Rectangle rec)
        {
            return rec.GetDiagonal();
        }
#endregion
    }
}
