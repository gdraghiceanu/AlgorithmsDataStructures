using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems._1WeekPreparation._1Day
{
    internal class PlusMinus : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei PlusMinus");
            PlusMinusMethod(new List<int> { -4, 3, -9, 0, 4, 1 });            
        }

        public void PlusMinusMethod(List<int> arr)
        {
            int n = arr.Count;
            int[] resArr = new int[3];

            foreach(int a in arr)
            {
                if (a > 0)
                {
                    resArr[0]++;
                }
                else if(a < 0)
                {
                    resArr[1]++;
                }
                else
                {
                    resArr[2]++;
                }
            }

            foreach (int ra in resArr)
            {
                var raport = (double)ra / arr.Count;

                var rotunjit = Math.Round(raport, 6);

                Console.WriteLine($"{rotunjit:F6}");
            }
        }
    }
}
