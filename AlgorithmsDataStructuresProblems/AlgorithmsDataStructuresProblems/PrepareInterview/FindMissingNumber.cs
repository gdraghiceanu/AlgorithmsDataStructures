using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.PrepareInterview
{
    internal class FindMissingNumber : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei FindMissingNumber");

            var res = FindMissingNumberFunction(new int[] { 3, 0, 1 });
            Console.WriteLine(res);
        }

        public static int FindMissingNumberFunction(int[] arr)
        {
            var myDic = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (myDic.ContainsKey(i))
                {
                    myDic[i]++;
                }
                else
                {
                    myDic
                }
            }
        }
    }
}
