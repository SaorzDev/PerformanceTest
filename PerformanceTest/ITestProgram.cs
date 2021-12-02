using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    interface ITestProgram
    {
        double Run();
        double Run(int numberOfAverage);
        double Run(int numberOfAverage, int numOfExecute);
    }
}
