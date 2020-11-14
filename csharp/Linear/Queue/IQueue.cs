using System;
using System.Collections.Generic;
using System.Text;

namespace Linear.Queue
{
    interface IQueue<T>
    {
        T Dequeue();
        void Enqueue(T e);
        T Peek();
        T[] ToArray();
        string ToString();
        void Clear();
    }
}
