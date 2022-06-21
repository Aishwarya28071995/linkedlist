using System;

namespace ConsoleApp2
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(20);
            linkedList.Add(56);

            linkedList.Display();
        }
    }
}
