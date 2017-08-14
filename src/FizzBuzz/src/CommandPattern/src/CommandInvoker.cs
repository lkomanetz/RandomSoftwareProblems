using System;

namespace CommandExample {

	public class CommandInvoker {

		public CommandInvoker() {}

		public void Invoke(ICommand command) => command.Execute();

	}

}