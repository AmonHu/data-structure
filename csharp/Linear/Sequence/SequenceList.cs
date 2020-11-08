using System;
using System.Collections.Generic;

namespace Linear.Sequence
{
    public class SequenceList<T> : ILinearList<T>
    {
        /// <summary>
        /// 线性表
        /// </summary>
        private List<T> _list;

        public T this[int i]
        {
            get { return this._list[i]; }
            set { this._list[i] = value; }
        }

        /// <summary>
        /// 长度
        /// </summary>
        public int Length
        {
            get
            {
                return this._list.Count;
            }
        }

        public SequenceList()
        {
            this._list = new List<T>();
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public void Clear()
        {
            this._list.Clear();
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsEmpty()
        {
            return this._list.Count == 0;
        }



        /// <summary>
        /// 访问元素
        /// </summary>
        /// <param name="index">元素索引</param>
        /// <returns>元素值</returns>
        public T Find(int index)
        {
            return this._list[index];
        }

        /// <summary>
        /// 查找元素索引
        /// </summary>
        /// <param name="e">元素值</param>
        /// <returns>元素索引</returns>
        public int Find(T e)
        {
            for (var i = 0; i < this._list.Count; i++)
            {
                if (this._list[i].Equals(e))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Add(T e)
        {
            this._list.Add(e);
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="e">元素</param>
        public void Add(int index, T e) 
        {
            if (index > this._list.Count)
            {
                throw new IndexOutOfRangeException();
            }

            this._list.Insert(index, e);
        }

        public void Remove(T e)
        {
            this._list.Remove(e);
        }

        public override string ToString()
        {
            return string.Join(",", this._list);
        }
    }
}