using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.Warmup
{
    internal class GradingStudents : IProblem
    {
        public void Solve()
        {
            Console.WriteLine($"Rezolvarea problemei {nameof(GradingStudents)}");
            var grades = new List<int> { 73, 67, 38, 33 };
            var roundGrades = gradingStudents(grades);
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine($"Original grade: {grades[i]}-{roundGrades[i]}");
            }            
        }

        public List<int> gradingStudents(List<int> grades)
        {
            var result = new List<int>();

            foreach (var gradeOriginal in grades)
            {
                var gradeRounded = GetGradeRounded(gradeOriginal);

                if (Math.Abs(gradeRounded - gradeOriginal) < 3 && gradeOriginal >= 38)
                {
                    result.Add(gradeRounded);
                }
                else if (Math.Abs(gradeRounded - gradeOriginal) >= 3 && gradeOriginal >= 38)
                {
                    result.Add(gradeOriginal);
                }
                else if (gradeOriginal < 38)
                {
                    result.Add(gradeOriginal);
                }
                else
                {
                    result.Add(gradeOriginal);
                }
            }

            return result;
        }

        private int GetGradeRounded(int gradeOriginal)
        {
            int gradeRounded;

            if (gradeOriginal % 5 == 0)
                gradeRounded = gradeOriginal;
            else
                gradeRounded = gradeOriginal + (5 - gradeOriginal % 5);

            return gradeRounded;
        }
    }
}
