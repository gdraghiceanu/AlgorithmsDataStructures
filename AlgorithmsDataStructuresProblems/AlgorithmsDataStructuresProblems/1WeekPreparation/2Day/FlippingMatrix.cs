using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems._1WeekPreparation._2Day
{
    //Exam problem Day2
    internal class FlippingMatrix : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei FlippingMatrix");

            int[][] matrix1 = new int[][]
            {
                new int[] { 112, 42, 83, 119 },
                new int[] { 56, 125, 56, 49 },
                new int[] { 15, 78, 101, 43 },
                new int[] { 62, 98, 114, 108 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };
            var res = flippingMatrix(matrix1);

            Console.WriteLine(res);
        }        

        public static int flippingMatrix(int[][] matrix)
        {
            int n = matrix.Length / 2; // Dimensiunea submatricei n x n
            int maxSum = 0;

            // Iterăm doar prin submatricea n x n din colțul stânga-sus
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Calculăm cele patru opțiuni posibile pentru fiecare poziție
                    int topLeft = matrix[i][j];
                    int topRight = matrix[i][2 * n - j - 1];
                    int bottomLeft = matrix[2 * n - i - 1][j];
                    int bottomRight = matrix[2 * n - i - 1][2 * n - j - 1];

                    // Alegem maximul dintre cele patru opțiuni
                    maxSum += Math.Max(Math.Max(topLeft, topRight), Math.Max(bottomLeft, bottomRight));
                }
            }

            return maxSum;
        }

    }
}
