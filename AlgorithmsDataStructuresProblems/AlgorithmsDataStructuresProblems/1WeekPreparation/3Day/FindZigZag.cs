using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems._1WeekPreparation._3Day
{
    internal class FindZigZag : IProblem
    {
        public void Solve()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int t = 0; t < testCases; t++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                FindZigZagSequence(arr, n);
            }
        }

        static void FindZigZagSequence(int[] arr, int n)
        {
            // Sortăm array-ul pentru a obține cea mai mică permutare lexicografică
            Array.Sort(arr);

            // Identificăm mijlocul
            int mid = (n - 1) / 2;

            // Facem swap între mijloc și ultimul element
            Swap(arr, mid, n - 1);

            // Reversăm partea dreaptă (ordonăm descrescător partea dreaptă)
            for (int i = mid + 1, j = n - 1; i < j; i++, j--)
            {
                Swap(arr, i, j);
            }

            // Afișăm secvența zig-zag finală
            Console.WriteLine(string.Join(" ", arr));
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
