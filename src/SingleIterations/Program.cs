using System;

namespace SingleIterations {

    class Program {

        static void Main(string[] args) {
            var duplicateNumbers = new DuplicateNumbers(1, 20);
            var result = duplicateNumbers.Run();

            foreach (var item in result) 
                Console.WriteLine($"{item.Key} is duplicated {item.Value} times.");
        }

    }

}