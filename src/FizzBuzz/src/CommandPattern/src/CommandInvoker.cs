using System;
using System.Collections.Generic;

namespace CommandExample {

	public class CommandInvoker {

		public CommandInvoker() {}

		public void Invoke(ICommand command) => command.Execute();

		public void Invoke(IList<ICommand> commands) {
			foreach (ICommand command in commands)
				Invoke(command);
		}

	}

}