using System;

namespace VisitorPatternExample {

	public class GeneratedNumber : IAcceptableObject {

		private int _generatedNumber;

		public GeneratedNumber(int number) => _generatedNumber = number;

		public int Number => _generatedNumber;

		public void Accept(IVisitor visitor) => visitor.Visit(this);

	}

}