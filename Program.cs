using System;

namespace workshop2__1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Input name: ");
       string name = Console.ReadLine();

       Console.Write("Input surname: ");
       string surname = Console.ReadLine();

       Console.Write("Input Nickname: ");
       string nickName = Console.ReadLine();

       Console.WriteLine("Hello my name is {0} {1}. Call me {2}", name, surname, nickName);

        }
    }
}