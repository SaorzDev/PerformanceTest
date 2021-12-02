using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    class BoxingTest : TestProgramBase
    {
        private int testNum = default(int);

        public BoxingTest()
        {
            base.testName = "BoxingTest";
        }

        protected override void Execute()
        {
            var str = $"testNumは{testNum}";
        }
    }
}
