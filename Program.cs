using System;

namespace workshop2__1 {
    class Program {
        static void Main(string[] args) {
             double number1 = 8.25;
          double number2 = 1.23;

          double summary = number1 + number2;
          double different = number1 - number2;
          double multiply = number1 * number2;
          double divide = number1 / number2;

          Console.WriteLine("Number 1 is: {0}", number1);
          Console.WriteLine("Number 2 is: {0}", number2);
          Console.WriteLine("Summary == {0} + {1} = {2}", number1, number2, summary);
          Console.WriteLine("Different == {0} - {1} = {2}", number1, number2, different);
          Console.WriteLine("Multiply == {0} x {1} = {2}", number1, number2, multiply);
          Console.WriteLine("Divide == {0} / {1} = {2}", number1, number2, divide);

        }
    }
}