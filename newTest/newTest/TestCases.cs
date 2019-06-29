using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTest
{
    [TestFixture]
    class TestCases
    {
        [TestCase]
        public void CheckMath()
        {
            Math math = new Math();
            Assert.AreEqual(3, math.Add(1, 2));
        }

    }
}
