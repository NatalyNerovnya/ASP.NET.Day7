using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;
using NUnit.Framework;

namespace Figures.NUnitTests
{
    class SquareTests
    {
        #region Constructor tests
        public IEnumerable<TestCaseData> ConstructorTestData
        {
            get
            {
                yield return new TestCaseData(3).Returns(new Square(3));
                yield return new TestCaseData(0).Throws(typeof(ArgumentException));
                yield return new TestCaseData(-4).Throws(typeof(ArgumentException));
                yield return new TestCaseData(double.NaN).Throws(typeof(ArgumentException));
                yield return new TestCaseData(double.PositiveInfinity).Throws(typeof(ArgumentException));
                yield return new TestCaseData(double.NegativeInfinity).Throws(typeof(ArgumentException));

            }
        }

        [Test, TestCaseSource(nameof(ConstructorTestData))]
        public Rectangle Square_Constructors_Tests(double a)
        {
            return new Square(a);
        }
        #endregion

        #region Area tests

        public IEnumerable<TestCaseData> AreaTestData
        {
            get
            {
                yield return new TestCaseData(new Square(2)).Returns(4);
                yield return new TestCaseData(new Square(1)).Returns(1);
            }
        }
        [Test, TestCaseSource(nameof(AreaTestData))]
        public double TestArea(Square sq)
        {
            return sq.Area();
        }
        #endregion

        #region Perimetr tests
        public IEnumerable<TestCaseData> PerimetrTestData
        {
            get
            {
                yield return new TestCaseData(new Square(2)).Returns(8);
                yield return new TestCaseData(new Square(6)).Returns(24);
            }
        }
        [Test, TestCaseSource(nameof(PerimetrTestData))]
        public double TestPerimetr(Square sq)
        {
            return sq.Perimeter();
        }
        #endregion

        #region Diagonal tests

        public IEnumerable<TestCaseData> DiagonalTestData
        {
            get
            {
                yield return new TestCaseData(new Square(4)).Returns(Math.Pow(32, 0.5));
                yield return new TestCaseData(new Square(3)).Returns(Math.Pow(18, 0.5));
            }
        }

        [Test, TestCaseSource(nameof(DiagonalTestData))]
        public double GetDiagonalTests(Square sq)
        {
            return sq.GetDiagonal();
        }
        #endregion
    }
}
