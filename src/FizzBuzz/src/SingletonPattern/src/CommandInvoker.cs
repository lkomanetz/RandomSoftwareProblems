using System;
using System.Collections.Generic;

namespace SingletonExample {

	public class CommandInvoker {

		private static CommandInvoker _instance = new CommandInvoker();

		static CommandInvoker() {}

		public static CommandInvoker Instance => _instance;

		public void Invoke(ICommand command) => command.Execute();

		public void Invoke(IList<ICommand> commands) {
			foreach (ICommand cmd in commands)
				cmd.Execute();
		}

	}

}