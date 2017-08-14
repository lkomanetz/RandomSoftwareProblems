using System;

namespace VisitorPatternExample {

	public interface IAcceptableObject {

		int Number { get; }
		void Accept(IVisitor visitor);

	}

}