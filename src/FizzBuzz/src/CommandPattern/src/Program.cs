using System;
using System.Collections.Generic;

namespace CommandExample {

    class Program {

        static void Main(string[] args) {
            /*
             * Here is the command pattern.  The idea is pretty simple but the implementation can become
             * a little intensive.  The idea is you have something that invokes commands, and commands
             * themselves.  The commands are free to take in whatever is necessary as a parameter but 
             * every command must implement an interface.  This decouples the entity that will invoke
             * commands and the commands themselves.
             *
             * The command will store the logic of what needs to be done.  In this case determing what to
             * print on the console window for whatever number gets passed in.  Whatever invokes these commands
             * doesn't need to care what command it gets passed since every command implements the same
             * interface.
             */
            CommandInvoker invoker = new CommandInvoker();
            IList<ICommand> commands = new List<ICommand>();

            for (int i = 1; i <= 100; ++i) 
                commands.Add(new FizzBuzzCommand(i));

            invoker.Invoke(commands);
        }

    }

}