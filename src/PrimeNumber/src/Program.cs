using System;

namespace PrimeNumberExample {

    class Program {

        static void Main(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine($"Expected 1 argument...got {args.Length} arguments");
                return;
            }

            int numberToCheck;
            if (!Int32.TryParse(args[0], out numberToCheck)) {
                Console.WriteLine($"Unable to parse {args[0]}");
                return;
            }

            string msg = (IsPrime(numberToCheck)) ? $"{numberToCheck} is prime." : $"{numberToCheck} is not prime.";
            Console.WriteLine(msg);
        }

        static bool IsPrime(int num) {
            for (int i = num - 1; i > 1; --i) {
                if (num % i == 0) {
                    return false;
                }
            }

            return true;
        }

    }

}