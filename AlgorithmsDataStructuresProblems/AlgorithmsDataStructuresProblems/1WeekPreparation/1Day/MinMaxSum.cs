using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems._1WeekPreparation._1Day
{
    internal class MinMaxSum: IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei MinMaxSum");
            miniMaxSum(new List<int> { 1,3,5,7,9 });
        }


        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            int n = arr.Count;
            long min = 0;
            long max = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    min += arr[i];
                    continue;
                }
                    
                if (i == n - 1)
                {
                    max += arr[i];
                    continue;
                }

                min += arr[i];
                max += arr[i];
            }

            Console.WriteLine($"{min} {max}");
        }

    }
}
