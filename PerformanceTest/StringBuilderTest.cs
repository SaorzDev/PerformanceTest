using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    class StringBuilderTest : TestProgramBase
    {
        StringBuilder sb = new StringBuilder();

        private char[] testCharSet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n' };

        public StringBuilderTest()
        {
            base.testName = "StringBuilderTest";
        }

        protected override void Execute()
        {
            var str = sb.Append(testCharSet).ToString();
            sb.Clear();
        }
    }
}
