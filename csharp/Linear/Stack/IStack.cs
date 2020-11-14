using System;
using System.Collections.Generic;
using System.Text;

namespace Linear.Stack
{
    interface IStack<T>
    {
        int Count { get; }
        T Pop();

        void Push(T e);

        T Peek();

        T[] ToArray();

        string ToString();

        void Clear();

        bool IsEmpty();
    }
}
