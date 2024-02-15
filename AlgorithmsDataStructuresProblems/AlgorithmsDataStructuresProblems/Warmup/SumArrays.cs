using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.Warmup
{
    public class SumArrays : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei SumArrays");
            var res = simpleArraySum(new List<int> { 1, 2, 3 });

            Console.WriteLine(res);
        }

        public int simpleArraySum(List<int> ar)
        {
            var sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;
        }
    }
}
