using System;
using System.Collections.Generic;

namespace LinkedListImplementation
{
    public class MyLinkedList<T> where T : IComparable
    {
        MyNode<T> FirstNode;
        MyNode<T> LastNode;
        int Count;

        public MyLinkedList()
        {
            Count = 0;
            //FirstNode.CurrentList = LastNode.CurrentList = this;
        }

        public void Append(T value)
        {
            MyNode<T> NewNode = new MyNode<T>(value);
            if (Count == 0) FirstNode = LastNode = NewNode;
            NewNode.CurrentList = this;
            NewNode.Previous = LastNode;
            LastNode.Next = NewNode;
            LastNode = NewNode;
            Count++;
        }

        public void Prepend(T value)
        {
            MyNode<T> NewNode = new MyNode<T>(value);
            if (Count == 0) FirstNode = LastNode = NewNode;
            NewNode.CurrentList = this;
            NewNode.Next = FirstNode;
            FirstNode.Previous = NewNode;
            FirstNode = NewNode;
            Count++;
        }

        public void Remove(T value)
        {
            if (Count > 0)
            {
                MyNode<T> NodeToRemove = new MyNode<T>(value);
                MyNode<T> NodeToCheck = FirstNode;
                while (NodeToCheck != null)
                {
                    if (NodeToRemove.Value.Equals(NodeToCheck.Value))
                    {
                        if (NodeToCheck.Previous != null && NodeToCheck.Next != null)
                        {
                            NodeToCheck.Previous.Next = NodeToCheck.Next.Previous;
                        } else if (NodeToCheck.Previous == null && NodeToCheck.Next != null)
                        {
                            NodeToCheck.Next.Previous = null;
                        } else if (NodeToCheck.Next == null && NodeToCheck.Previous != null)
                        {
                            NodeToCheck.Previous.Next = null;
                        }
                        NodeToCheck.Kill();
                        Count--;
                        break;
                    }
                    NodeToCheck = NodeToCheck.Next;
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            if (Count != 0)
            {
                MyNode<T> CurrentNode = FirstNode;
                while(CurrentNode != null)
                {
                    result += CurrentNode.Value.ToString() + " ";
                    CurrentNode = CurrentNode.Next;
                }
            }
            return result.Trim();
        }
    }
}
