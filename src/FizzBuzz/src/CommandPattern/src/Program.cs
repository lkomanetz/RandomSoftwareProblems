using System;

namespace CommandExample {

    class Program {

        static void Main(string[] args) {
            CommandInvoker invoker = new CommandInvoker();

            for (int i = 1; i <= 100; ++i) {
                var cmd = new FizzBuzzCommand(i);
                invoker.Invoke(cmd);
            }
        }

    }

}
