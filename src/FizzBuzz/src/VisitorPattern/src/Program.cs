using System;

namespace VisitorPatternExample {

    class Program {
        
        static void Main(string[] args) {
            /*
             * Here is the visitor pattern. The GeneratedNumber type is an "IAcceptableObject" that
             * accepts a visitor.  The visitor is what does something with the object.  When the object
             * accepts a visitor, it calls the Visit() method to do whatever you want to do on that object.
             */
            for (int i = 1; i <= 100; ++i) {
                var num = new GeneratedNumber(i);
                num.Accept(new FizzBuzzVisitor());
            }
        }

    }

}