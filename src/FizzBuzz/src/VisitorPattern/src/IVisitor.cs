using System;

namespace VisitorPatternExample {

	public interface IVisitor {

		void Visit(IAcceptableObject number);

	}

}