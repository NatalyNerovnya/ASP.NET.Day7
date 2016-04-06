using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;
using NUnit.Framework;

namespace Figures.NUnitTests
{
    class CircleTests
    {
        #region Constructor test
        public IEnumerable<TestCaseData> ConstructorTestCaseDatas
        {
            get
            {
                yield return new TestCaseData(4).Returns(new Circle(4));
                yield return new TestCaseData(-4).Throws(typeof(ArgumentException));
                yield return new TestCaseData(double.NaN).Throws(typeof(ArgumentException));
            }
        }

        [Test, TestCaseSource(nameof(ConstructorTestCaseDatas))]
        public Circle ConstructorTest(double r)
        {
            return new Circle(r);
        }
        #endregion

        #region Area tests

        public IEnumerable<TestCaseData> AreaCaseDatas
        {
            get
            {
                yield return new TestCaseData(new Circle(2)).Returns(Math.PI*4);
            }
        }

        [Test, TestCaseSource(nameof(AreaCaseDatas))]
        public double AreaTests(Circle circ)
        {
            return circ.Area();
        }
        #endregion

        #region Perimetr tests

        public IEnumerable<TestCaseData> PerimetrCaseDatas
        {
            get
            {
                yield return new TestCaseData(new Circle(2)).Returns(Math.PI * 4);
            }
        }

        [Test, TestCaseSource(nameof(PerimetrCaseDatas))]
        public double PerimetrTests(Circle circ)
        {
            return circ.Perimeter();
        }
        #endregion
    }
}
