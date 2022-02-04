using System;
using System.Collections.Generic;
using System.Text;

namespace Project_04_NumericalIntegration
{
    class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode<T> Previous { get; set; }
        public StackNode(T data, StackNode<T> previous)
        {
            Data = data;
            Previous = previous;
        }
    }
}
