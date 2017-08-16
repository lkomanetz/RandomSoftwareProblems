using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnagramExample {

    class Program {

        static void Main(string[] args) {
            if (args.Length != 2) {
                Console.WriteLine($"I want two arguments, not {args.Length} arguments");
                return;
            }

            /*
             * This is just a multicast delegate.  This allows me to define the formatter as doing
             * multiple things in one area.  Except this has a little bit of a downside (which you'll
             * see in a comment farther down the code).
             */
            Func<string, string> formatter = (s) => Regex.Replace(s, @"\W+", String.Empty);
            formatter += (s) => s.ToLower();

            Program p = new Program();
            bool isAnagram = p.IsAnagram(
                args[0],
                args[1],
                formatter
            );

            string msg = (isAnagram) ? "It's an anagram!" : "It's not an anagram :-(";
            Console.WriteLine(msg);
        }

        internal bool IsAnagram(string a, string b, Func<string, string> formatter) {
            /*
             * Multicast delegates are mostly known for their use in events.  Events don't return anything.
             * Since my delegate returns a string I have to iterate through the invocation list in order
             * to capture each return value.  This really isn't the cleanest because IsAnagram basically
             * needed to know that it had to approach the delegate in this manner.  
             * If this was production code I'd come up with a cleaner solution so this method didn't need
             * any knowledge of how it's expecting formatter to be a multicast delegate.
             */
            foreach (Func<string, string> function in formatter.GetInvocationList()) {
                a = function(a);
                b = function(b);
            }

            if (a.Length != b.Length) {
                Console.WriteLine("Length isn't the same");
                return false;
            }

            /*
             * This is the LINQ solution.  Why go with this solution versus using a dictionary and making
             * sure char arrays are only iterated through once to do the checks?  Because I'm not putting
             * an arbitrary constraint on this solution.  Iterating through the one string to create a 
             * dictionary and iterating through the second to check if the key exists in the dictionary is
             * an option.  This code is quite a bit simpler, in my opinion it's more readable, and it doesn't
             * prematurely try to optimize code that may not need to be optimized.
             */
            return a.ToCharArray().Except(b).Count() == 0;
        }

    }

}
