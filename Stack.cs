using System;
using System.Collections.Generic;
using System.Text;

namespace Project_04_NumericalIntegration
{
    class Stack<T>
    {
        public StackNode<T> First { get; set; } //at the bottom
        public StackNode<T> Last { get; set; } //at the top
        public int Count { get; set; }

        public Stack()
        {
            Count = 0;
        }

        public void Push(T data)
        {

            if (Count == 0)
            {
                First = new StackNode<T>(data, null);
                Last = new StackNode<T>(data, First);
            }
            else
            {
                Last = new StackNode<T>(data, Last);
            }
            Count++;
        }

        public void Pop()
        {
            Last = Last.Previous;
            Count--;
        }

        public T Peek()
        {
            return Last.Data;
        }

        public bool isEmpty()
        {
            return Count == 0;
        }

        public void Clear()
        {
            First = null;
            Last = null;
        }
    }
}
