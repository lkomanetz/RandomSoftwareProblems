using System;

namespace SimpleSolution {

    class Program {

        static void Main(string[] args) {
            for (int i = 1; i <= 100; ++i) {
                string msg = String.Empty;
                if (i % 3 == 0)
                    msg += "Fizz";

                if (i % 5 == 0)
                    msg += "Buzz";

                if (!String.IsNullOrEmpty(msg))
                    Console.WriteLine(msg);
                else
                    Console.WriteLine(i);
            }
        }

    }

}