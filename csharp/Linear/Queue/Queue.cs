using System;
using System.Collections.Generic;
using System.Text;

namespace Linear.Queue
{


    class Queue<T> : IQueue<T>
    {
        private List<T> _list;
        public Queue()
        {
            this._list = new List<T>();
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentOutOfRangeException();
            }
            var p = this._list[0];
            this._list.RemoveAt(0);
            return p;
        }
        public void Enqueue(T e)
        {
            this._list.Add(e);
        }
        public T Peek()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentOutOfRangeException();
            }
            return this._list[0];
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
            return this._list.Count == 0;
        }
    }
}
