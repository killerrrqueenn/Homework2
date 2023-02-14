using System;

namespace workshop2__1 {
    class Program {
        static void Main(string[] args) {
            const double PI = 3.1415926535; 
          double radius = 5.0; 

          double area = PI * radius * radius;
          double length = 2 * PI * radius;

          Console.WriteLine("Ares is: {0}, Length: {1}", area, length);

        }
    }
}