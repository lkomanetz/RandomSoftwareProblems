using System;
using System.Collections.Generic;

namespace SingletonExample {

    class Program {

        /*
         * So there are two different design patterns here but I'm mostly concerned with the CommandInvoker
         * class.  In the command design pattern you could create multiple instances of CommandInvoker.  However,
         * in this scenario CommandInvoker is a singleton class and therefore you can only have one instance
         * of the class at any given time.
         *
         * You might be wondering why I'm not using a lock to make sure the singleton is thread safe (something
         * that a lot of people don't think about).  I'm not using a lock because I don't have to.  I use the
         * explicit static constructor so the compiler doesn't mark the type with 'beforefieldinit'.
         */
        static void Main(string[] args) {
            IList<ICommand> commands = new List<ICommand>();
            for (int i = 1; i <= 100; ++i)
                commands.Add(new FizzBuzzCommand(i));

            CommandInvoker.Instance.Invoke(commands);
        }

    }

}
