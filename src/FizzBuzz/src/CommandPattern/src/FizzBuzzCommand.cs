using System;

namespace CommandExample {

	public class FizzBuzzCommand : ICommand {

		private int _number;
		public FizzBuzzCommand(int number) => _number = number;

		public void Execute() {
			if ((_number % 3 == 0) && (_number % 5 == 0)) {
				Console.WriteLine($"FizzBuzz->\t{_number}");
				return;
			}

			if (_number % 3 == 0)
				Console.WriteLine($"Fizz\t->\t{_number}");
			else if (_number % 5 == 0)
				Console.WriteLine($"Buzz\t->\t{_number}");
		}

	}

}