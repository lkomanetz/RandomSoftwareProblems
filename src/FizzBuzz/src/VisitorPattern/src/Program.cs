using System;

namespace src {

    class Program {
        
        static void Main(string[] args) {
            /*
             * Here is the visitor pattern.  The FizzBuzzCreator type is "accepting" three different
             * "vistitors" and the visitors do something at certain points of an iteration.  I'm simplifying
             * the pattern by using Action<int> instead of creating visitor classes that implement an interface
             * and a whole other mess of things.
             */
            FizzBuzzCreator creator = new FizzBuzzCreator(
                (number) => Console.WriteLine($"Fizz\t->\t{number}"),
                (number) => Console.WriteLine($"Buzz\t->\t{number}"),
                (number) => Console.WriteLine($"FizzBuzz->\t{number}"),
                1,
                100
            );
            creator.Create();
        }

    }

    internal class FizzBuzzCreator {

        private Action<int> _onDivisibleByThree;
        private Action<int> _onDivisibleByFive;
        private Action<int> _onDivisibleByBoth;
        private int _upperBounds;
        private int _lowerBounds;

        public FizzBuzzCreator(
            Action<int> onDivisibleByThree,
            Action<int> onDivisibleByFive,
            Action<int> onDivisibleByBoth,
            int lowerBounds,
            int upperBounds
        ) {
            _onDivisibleByBoth = onDivisibleByBoth;
            _onDivisibleByThree = onDivisibleByThree;
            _onDivisibleByFive = onDivisibleByFive;
            _upperBounds = upperBounds;
            _lowerBounds = lowerBounds;
        }

        public void Create() {
            for (int i = _lowerBounds; i <= _upperBounds; ++i) {
                if (i % 3 == 0 && i % 5 == 0) {
                    _onDivisibleByBoth(i);
                    continue;
                }

                if (i % 3 == 0) {
                    _onDivisibleByThree(i);
                    continue;
                }

                if (i % 5 == 0) {
                    _onDivisibleByFive(i);
                    continue;
                }
            }
        }

    }

}