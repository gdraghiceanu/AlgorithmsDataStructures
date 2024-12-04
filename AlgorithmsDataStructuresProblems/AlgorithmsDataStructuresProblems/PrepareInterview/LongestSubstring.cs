using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.PrepareInterview
{
    internal class LongestSubstring : IProblem
    {
        public void Solve()
        {
            string input = "abcabcbb";
            int result = LengthOfLongestSubstring(input);
            Console.WriteLine(result); // Output: 3
        }

        public static int LengthOfLongestSubstring(string s)
        {
            var charIndexMap = new Dictionary<char, int>();
            int maxLength = 0;
            int start = 0;

            for(int end = 0; end < s.Length; end ++)
            {
                char currentChar = s[end];

                if(charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start)
                {
                    start = charIndexMap[currentChar] + 1;
                }

                charIndexMap[currentChar] = end;

                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }
    }
}
