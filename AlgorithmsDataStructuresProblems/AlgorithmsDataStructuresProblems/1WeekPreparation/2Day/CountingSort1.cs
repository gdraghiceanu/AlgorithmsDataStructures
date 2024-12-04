using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems._1WeekPreparation._2Day
{
    internal class CountingSort1 : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei SumArrays");
            var res = countingSort(new List<int> { 1, 1, 3, 2, 2, 1 });

            foreach (int i in res)
            {
                Console.Write(i + " ");
            }           
        }

        public static List<int> countingSort(List<int> arr)
        {            
            var myArray = new int[100];

            foreach (int i in arr)
            {
                myArray[i] ++;
            }

            return myArray.ToList<int>();
        }
    }
}
