using System;

namespace PalindromeExample {

    class Program {

        static void Main(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine($"Expected 1 argument...received {args.Length} arguments");
                return;
            }

            PalindromeChecker checker = new PalindromeChecker();
            bool isPalindrome = checker.Check(args[0]);

            string msg = (isPalindrome) ? $"'{args[0]}' is a palindrome" : $"'{args[0]}' is not a palindrome";
            Console.WriteLine(msg);
        }

    }

}