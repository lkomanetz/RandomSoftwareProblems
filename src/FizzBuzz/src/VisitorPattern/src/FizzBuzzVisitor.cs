using System;

namespace VisitorPatternExample {
	
	public class FizzBuzzVisitor : IVisitor {

		public void Visit(IAcceptableObject obj) {
			if ((obj.Number % 3 == 0) && (obj.Number % 5 == 0)) {
				Console.WriteLine($"FizzBuzz->\t{obj.Number}");
				return;
			}

			if (obj.Number % 3 == 0) 
				Console.WriteLine($"Fizz\t->\t{obj.Number}");
			else if (obj.Number % 5 == 0) 
				Console.WriteLine($"Buzz\t->\t{obj.Number}");

		}

	}

}