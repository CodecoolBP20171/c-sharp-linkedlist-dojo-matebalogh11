using System;
using System.Collections.Generic;

namespace LinkedListImplementation
{
    public class MyNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public MyNode<T> Previous { get; set; }
        public MyNode<T> Next { get; set; }
        public MyLinkedList<T> CurrentList { get; set; }

        public MyNode(T Value)
        {
            this.Value = Value;
        }

        public void Kill()
        {
            Previous = Next = null;
            CurrentList = null;
        }
    }
}
