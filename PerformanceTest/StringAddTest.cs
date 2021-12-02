using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    class StringAddTest : TestProgramBase
    {
        private char[] testCharSet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n' };

        public StringAddTest()
        {
            base.testName = "StringAddTest";
        }

        protected override void Execute()
        {
            string str = string.Empty;

            foreach (var c in testCharSet)
                str += c;
        }
    }
}
