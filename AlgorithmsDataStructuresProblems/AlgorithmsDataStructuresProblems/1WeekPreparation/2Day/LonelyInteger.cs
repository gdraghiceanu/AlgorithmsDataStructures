using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems._1WeekPreparation._2Day
{
    internal class LonelyInteger : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei LonelyInteger");
            var res = lonelyinteger(new List<int> { 1, 2, 3, 4, 3, 2, 1 });

            Console.WriteLine(res);
        }


        static int lonelyinteger(List<int> a)
        {
            int result = 0;

            // Aplicăm XOR pe toate elementele
            foreach (int num in a)
            {
                result ^= num;
            }

            return result;
        }

        public static int lonelyintegerMe(List<int> arr)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary[item] = 1;
                }
            }

            foreach (var item in dictionary)
            {
                if(item.Value == 1)
                    return item.Key;
            }

            return -1;
        }



        
    }
}
