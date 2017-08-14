using System;
using System.Collections.Generic;

namespace CommandExample {

    class Program {

        static void Main(string[] args) {
            CommandInvoker invoker = new CommandInvoker();
            IList<ICommand> commands = new List<ICommand>();

            for (int i = 1; i <= 100; ++i) 
                commands.Add(new FizzBuzzCommand(i));

            invoker.Invoke(commands);
        }

    }

}
