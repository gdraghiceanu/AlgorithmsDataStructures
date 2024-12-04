using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems._1WeekPreparation._2Day
{
    internal class DiagonalDifference : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei DiagonalDifference");

            var l1 = new List<int> { 11,2,4 };
            var l2 = new List<int> { 4, 5, 6 };
            var l3 = new List<int> { 10,8,-12 };

            var res = diagonalDifference(new List<List<int>> { l1,l2,l3 });

            Console.WriteLine(res);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            var n = arr.Count;
            var d1 = 0;
            var d2 = 0;

            for (int i = 0; i < n; i++)
            {
                d1 += arr[i][i];

                var indexd2 = n - i - 1;
                d2 += arr[indexd2][i];
            }

            return Math.Abs(d1-d2);
        }
    }
}
