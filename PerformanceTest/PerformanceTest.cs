using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    class PerformanceTest
    {
        int numberOfAverage = 15;
        int numOfExecute = 1000000;

        public void Run()
        {
            ITestProgram unBoxingTest = new UnBoxingTest();
            ITestProgram boxingTest = new BoxingTest();
            ITestProgram stringBuilderTest = new StringBuilderTest();
            ITestProgram stringAddTest = new StringAddTest();

            Console.WriteLine($"{boxingTest.Run(numberOfAverage, numOfExecute) / unBoxingTest.Run(numberOfAverage, numOfExecute)}倍");
            Console.WriteLine("\n");
            Console.WriteLine($"{stringAddTest.Run(numberOfAverage, numOfExecute) / stringBuilderTest.Run(numberOfAverage, numOfExecute)}倍");
            Console.WriteLine("\n");

        }
    }
}
