using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.PrepareInterview
{
    internal class ValidParentheses : IProblem
    {
        public void Solve()
        {
            Console.WriteLine("Rezolvarea problemei FindMissingNumber");

            var res = validParentheses("({[]})");
            Console.WriteLine(res);
        }

        public static bool validParentheses(string s)
        {     
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict['('] = ')';
            dict['{'] = '}';
            dict['['] = ']';

            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0)
                {
                    if ( dict.ContainsKey(c) )
                    {
                        stack.Push(c);                        
                    }  
                    else
                    {
                        var current = stack.Peek();
                        if (c == dict[current])
                        {                            
                            stack.Pop();
                        }
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }

        //solutie optimaa
        public static bool IsValid(string s)
        {
            // Dicționar pentru a potrivi parantezele
            Dictionary<char, char> brackets = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

            // Stack pentru a urmări parantezele deschise
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                // Dacă este o paranteză închisă
                if (brackets.ContainsKey(c))
                {
                    // Verificăm dacă stack-ul este gol sau dacă ultima paranteză deschisă nu corespunde
                    char top = stack.Count > 0 ? stack.Pop() : '#';

                    if (top != brackets[c])
                    {
                        return false;
                    }
                }
                else
                {
                    // Este o paranteză deschisă, o adăugăm în stack
                    stack.Push(c);
                }
            }

            // La sfârșit, stack-ul trebuie să fie gol
            return stack.Count == 0;
        }
    }
}
