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
            var res = 0;
            foreach (int i in arr)
            {
                if (myDic.ContainsKey(i))
                {
                    myDic[i]++;
                }
                else
                {
                    myDic[i] = 1;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!myDic.ContainsKey(i))
                {
                    res = i;
                    break;
                }
            }

            return res;
        }
    }
}
