using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.Warmup
{
    public class NumberLineJumps : IProblem
    {

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var k1List = new List<int>();
            var k2List = new List<int>();

            if (x1 + v1 < x2 + v2 &&  v1 <=  v2)
                return "NO";

            for (int i = 0; i <= 10000; i++)
            {
                if(i == 0)
                {
                    k1List.Add(x1 + v1);
                    k2List.Add(x2 + v2);
                }
                else
                {
                    k1List.Add(k1List[i - 1] + v1);
                    k2List.Add(k2List[i - 1] + v2);
                }

                if (k1List[i] == k2List[i])
                    return "YES";
            }

            return "NO";
        }

        public void Solve()
        {
            Console.WriteLine($"Rezolvarea problemei {nameof(GradingStudents)}");
            Console.WriteLine($"Raspuns: {kangaroo(14, 4, 98, 2)}");
        }
    }
}
