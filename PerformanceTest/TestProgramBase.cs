using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    abstract class TestProgramBase : ITestProgram
    {
        protected string testName = string.Empty;
        protected Stopwatch sw = new Stopwatch();
        
        public double Run()
        {
            return Run(5, 10000);
        }

        public double Run(int numberOfAverage)
        {
            return Run(numberOfAverage, 10000);
        }

        public double Run(int numberOfAverage, int numOfExecute)
        {
            Console.WriteLine($"###############################################################\n");

            Console.WriteLine($"{testName} 平均算出計算回数: {numberOfAverage}回, 1回当たりの実行回数: {numOfExecute}回");
            double averageExecuteTime = default(Double);
            for (int i = 1; i <= numberOfAverage; i++)
            {
                double executeTime = default(Double);
                for (int j = 0; j < numOfExecute; j++)
                {
                    executeTime += ExecuteTestProgram();
                }
                Console.WriteLine($"{i}回目: {executeTime}s");

                averageExecuteTime += executeTime;
            }

            averageExecuteTime = averageExecuteTime / numberOfAverage;

            Console.WriteLine($"平均実行時間: {averageExecuteTime}s");
            Console.WriteLine($"###############################################################\n");

            return averageExecuteTime;
        }

        private double ExecuteTestProgram()
        {
            this.sw.Restart();

            Execute();

            this.sw.Stop();

            return this.sw.Elapsed.TotalSeconds;
        }

        protected abstract void Execute();
    }
}
