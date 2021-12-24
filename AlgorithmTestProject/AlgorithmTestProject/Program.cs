

using System;
using System.Collections.Generic;

namespace AlgorithmTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 16];
            arr[4, 6] = 1;
            arr[5, 3] = 1;
            arr[7, 6] = 1;
            arr[9, 3] = 1;
            arr[3, 9] = 1;
            arr[3, 3] = 1;
            var frogTask = new FrogAlgorithm();
            var countOfClimb = frogTask.findShortestWay((1,9),(7,13),arr);
            if(countOfClimb==1000)
            {
                Console.WriteLine("Cannot be found");
            }
            else
            {
                Console.WriteLine($"Count of climb: {countOfClimb}");
                Console.WriteLine($"The way is: {countOfClimb * 3}");
            }

        }
               
    }
}
