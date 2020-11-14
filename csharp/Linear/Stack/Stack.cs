using System;
using System.Collections.Generic;
using System.Text;

namespace Linear.Stack
{
    public class Stack<T> : IStack<T>
    {
        private List<T> _list;
        public int Count { get { return this._list.Count; } }

        public Stack()
        {
            this._list = new List<T>();
        }

        public T Pop()
        {
            if (this.IsEmpty()) 
            {
                throw new ArgumentOutOfRangeException();
            }
            var peek = this.Peek();
            this._list.RemoveAt(this.Count - 1);
            return peek;
        }

        public void Push(T e)
        {
            this._list.Add(e);
        }

        public T Peek()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentOutOfRangeException();
            }
            return this._list[this.Count - 1];
        }

        public T[] ToArray()
        {
            return this._list.ToArray();
        }

        public override string ToString()
        {
            return string.Join(",", this._list);
        }

        public void Clear()
        {
            this._list.Clear();
        }

        public bool IsEmpty()
        {
            return this.Count == 0;
        }
    }
}
