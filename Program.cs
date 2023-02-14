using System;

namespace workshop2__1 {
    class Program {
        static void Main(string[] args) {
            bool result1 = !(7 >= 2)&& (4 == 2) || (4 < 2);
        bool result2 = (3 > 3) || ((5 > 2) && (4 < 1));

        Console.WriteLine("Result 1 is: {0}", result1);
        Console.WriteLine("Result 2 is: {0}", result2);

        }
    }
}