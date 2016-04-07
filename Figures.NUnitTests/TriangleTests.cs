using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;
using NUnit.Framework;

namespace Figures.NUnitTests
{
    class TriangleTests
    {
        #region Constructors

        public IEnumerable<TestCaseData> ConstructorCaseData
        {
            get
            {
                yield return new TestCaseData(3, 4, 5).Returns(new Triangle(3, 4, 5));
                yield return new TestCaseData(3, 4, 5).Throws(typeof(ArgumentException));
                yield return new TestCaseData(2,3,5).Throws(typeof(ArgumentException));
            }
        }

        [Test, TestCaseSource(nameof(ConstructorCaseData))]
        public Triangle ConstructorTest(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
        #endregion

        #region Area tests

        public IEnumerable<TestCaseData> AreaCaseData
        {
            get
            {
                yield return new TestCaseData(new Triangle(3, 4, 5)).Returns((double)6);
            }
        }

        [Test, TestCaseSource(nameof(AreaCaseData))]
        public double AreaTest(Triangle tr)
        {
            return tr.Area();
        }
        #endregion

        #region Perimetr tests

        public IEnumerable<TestCaseData> PerimetrCaseData
        {
            get
            {
                yield return new TestCaseData(new Triangle(3, 4, 5)).Returns(12);
            }
        }

        [Test, TestCaseSource(nameof(AreaCaseData))]
        public double PerimetrTest(Triangle tr)
        {
            return tr.Perimeter();
        }
        #endregion

        #region Kind of triangle tests

        public IEnumerable<TestCaseData> IsIsoscelesCaseData
        {
            get
            {
                yield return new TestCaseData(new Triangle(3, 4, 5)).Returns(false);
                yield return new TestCaseData(new Triangle(2,2,3)).Returns(true);
                yield return new TestCaseData(new Triangle(1,1,1)).Returns(false);
            }
        }

        public IEnumerable<TestCaseData> IsRightCaseData
        {
            get
            {
                yield return new TestCaseData(new Triangle(3, 4, 5)).Returns(true);
                yield return new TestCaseData(new Triangle(2, 2, 3)).Returns(false);
                yield return new TestCaseData(new Triangle(1, 1, 1)).Returns(false);
            }
        }

        public IEnumerable<TestCaseData> IsEquilateralCaseDatas
        {
            get
            {
                yield return new TestCaseData(new Triangle(3, 4, 5)).Returns(false);
                yield return new TestCaseData(new Triangle(2, 2, 3)).Returns(false);
                yield return new TestCaseData(new Triangle(1, 1, 1)).Returns(true);
            }
        }

        public IEnumerable<TestCaseData> IsSimilarCaseDatas
        {
            get
            {
                yield return new TestCaseData(new Triangle(3, 4, 5), new Triangle(6, 8, 10)).Returns(true);
                yield return new TestCaseData(new Triangle(2, 2, 3), new Triangle(3, 4, 5)).Returns(false);
                yield return new TestCaseData(new Triangle(1, 1, 1), null).Throws(typeof(ArgumentNullException));
            }
        }

        [Test, TestCaseSource(nameof(IsIsoscelesCaseData))]
        public bool IsIsoscelesTest(Triangle tr)
        {
            return tr.IsIsosceles();
        }
        
        [Test, TestCaseSource(nameof(IsRightCaseData))]
        public bool IsRightTest(Triangle tr)
        {
            return tr.IsRight();
        }

        [Test, TestCaseSource(nameof(IsEquilateralCaseDatas))]
        public bool IsEquilateralTest(Triangle tr)
        {
            return tr.IsEquilateral();
        }

        [Test, TestCaseSource(nameof(IsSimilarCaseDatas))]
        public bool IsSimilarTest(Triangle tr, Triangle other)
        {
            return tr.IsSimilar(other);
        }
        #endregion
    }
}
