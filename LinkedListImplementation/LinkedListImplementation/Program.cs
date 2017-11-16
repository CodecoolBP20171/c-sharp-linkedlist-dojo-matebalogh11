using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myList = new MyLinkedList<int>();
            myList.Append(15);
            myList.Prepend(33);
            myList.Append(123);
            myList.Append(5);
            myList.Append(19);
            myList.Prepend(876);
            myList.Remove(5);
            Console.WriteLine(myList.ToString());
            Console.ReadKey();
        }
    }
}
