using AlgorithmsDataStructuresProblems._1WeekPreparation._1Day;
using AlgorithmsDataStructuresProblems._1WeekPreparation._2Day;
using AlgorithmsDataStructuresProblems._1WeekPreparation._3Day;
using AlgorithmsDataStructuresProblems.Implementation;
using AlgorithmsDataStructuresProblems.Interfaces;
using AlgorithmsDataStructuresProblems.PrepareInterview;
using AlgorithmsDataStructuresProblems.Warmup;
using static System.Net.Mime.MediaTypeNames;

namespace AlgorithmsDataStructuresProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salut");

            var problems = new Dictionary<int, IProblem>()
            {
                { 1, new SumArrays() },
                { 2, new GradingStudents() },
                { 3, new NumberLineJumps() },
                { 4, new FormingMagicSquare() },
                { 5, new ClimbingTheLeaderboard() },
                { 6, new PlusMinus() },
                { 7, new MinMaxSum() },
                { 8, new FizzBuzz() },
                { 9, new LonelyInteger() },
                { 10, new DiagonalDifference() },
                { 11, new CountingSort1() },
                { 12, new FlippingMatrix() },
                { 13, new FindZigZag() },
                { 14, new LongestSubstring() },
                { 15, new FindMissingNumber() },
                { 16, new ValidParentheses() },
            };

            Console.WriteLine("Selectează numărul problemei de rezolvat:");
            foreach (var pb in problems)
            {
                var nume = pb.Value.ToString();
                var numeFinal = nume.Substring(nume.LastIndexOf(".") + 1);
                Console.WriteLine($"Problema {pb.Key} - {numeFinal}");
            }

            if (int.TryParse(Console.ReadLine(), out int problemNumber) && problems.ContainsKey(problemNumber))
            {
                problems[problemNumber].Solve();
            }
            else
            {
                Console.WriteLine("Problemă invalidă sau număr greșit.");
            }
        }
    }
}
