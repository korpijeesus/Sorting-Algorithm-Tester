using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algorithm_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingTestData testData = new SortingTestData();
            testData.InitRandom(10, 10);
            testData.testOutput();

            Console.Read();
        }
    }
}
