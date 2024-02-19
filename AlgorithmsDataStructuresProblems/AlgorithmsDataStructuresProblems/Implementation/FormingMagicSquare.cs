using AlgorithmsDataStructuresProblems.Interfaces;
using AlgorithmsDataStructuresProblems.Warmup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.Implementation
{
    internal class FormingMagicSquare : IProblem
    {
        private const int CTSUM = 15;
        public static int formingMagicSquare(List<List<int>> s)
        {
            int[] sumCol = new int[s.Count];
            int[] sumRow = new int[s[0].Count];
            for (int r = 0; r < s.Count; r++)
            {
                for (int c = 0; c < s[r].Count; c++)
                {
                    sumRow[r] += s[r][c];
                    sumCol[c] += s[r][c];
                }
            }

            var costC = 0;
            var costR = 0;
            for (int i = 0; i < sumCol.Length; i ++)
            {
                costC += Math.Abs(CTSUM - sumCol[i]);
                costR += Math.Abs(CTSUM - sumRow[i]);
            }

            var result = Math.Max(costC,costR);
            return result;
        }

        public void Solve()
        {
            Console.WriteLine($"Rezolvarea problemei {nameof(FormingMagicSquare)}");
            var square = new List<List<int>>();
            var list1 = new List<int>() { 4,5,8};
            var list2 = new List<int>() { 2,4,1 };
            var list3 = new List<int>() { 1,9,7 };
            square.Add(list1);
            square.Add(list2);
            square.Add(list3);
            var res = formingMagicSquare(square);
            Console.WriteLine(res);
        }
    }
}
