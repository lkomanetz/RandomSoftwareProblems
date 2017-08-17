using System;

namespace src {

    class Program {

        static void Main(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine($"Expected 1 argument.  {args.Length} arguments provided");
                return;
            }

            int endNumber = Int32.Parse(args[0]);
            for (int i = 0; i < endNumber; ++i) {
                Console.WriteLine(Fibonacci(i));
            }
        }

        static int Fibonacci(int num) {
            if (num == 0 || num == 1) {
                return num;
            }

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

    }

}