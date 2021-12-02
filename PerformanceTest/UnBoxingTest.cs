using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    class UnBoxingTest : TestProgramBase
    {
        private int testNum = default(int);

        public UnBoxingTest()
        {
            base.testName = "UnBoxingTest";
        }

        protected override void Execute()
        {
            var str = $"testNumは{testNum.ToString()}";
        }
    }
}
