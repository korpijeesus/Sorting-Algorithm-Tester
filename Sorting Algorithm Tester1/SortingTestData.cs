using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algorithm_Tester
{
    class SortingTestData
    {
        private int[] testData;                 //Integer array for testing data
        private int N;                          //Size of the testing data table
        private int maxNumber;                  //Inclusive upper bound for test data integers
        private Random rndGen = new Random();  //Random number generator

        public 

        /// <summary>
        /// Init the testData array to random numbers in a random order
        /// </summary>
        /// <param name="maxNumber">Inclusive upper bound for values of integers to be included</param>
        /// <param name="N">Size of the array</param>
        public void InitRandom(int maxNumber, int N)
        {
            this.N = N;
            this.maxNumber = maxNumber;

            testData = new int[N];
            for (int i = 0; i < N; i++)
                testData[i] = rndGen.Next(0, maxNumber+1);
        }

        /// <summary>
        /// Init the testData array to random numbers in an ascending order
        /// </summary>
        /// <param name="maxNumber">Inclusive upper bound for values of integers to be included</param>
        /// <param name="N">Size of the array</param>
        public void initAscending(int maxNumber, int N)
        {
            this.N = N;
            this.maxNumber = maxNumber;
        }

        /// <summary>
        /// Init the testData array to random numbers in a descending order
        /// </summary>
        /// <param name="maxNumber">Inclusive upper bound for values of integers to be included</param>
        /// <param name="N">Size of the array</param>
        public void initDescending(int maxNumber, int N)
        {
            this.N = N;
            this.maxNumber = maxNumber;
        }

        public void testOutput()
        {
            foreach (int x in testData)
                Console.WriteLine(x);
        }
    }
}
