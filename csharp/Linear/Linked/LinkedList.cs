using System;
using System.Collections.Generic;

namespace Linear.Linked
{
    public class LinkedList<T> : ILinearList<T>
    {
        private INode<T> _head;
        private INode<T> _currentNode;

        /// <summary>
        /// 长度
        /// </summary>
        public virtual int Length { get; protected set; }

        public virtual T this[int i]
        {
            get
            {
                this.VerifyIndex(i);
                return this.Traverse(i).Node2.Value;
            }
            set
            {
                this.VerifyIndex(i);
                this.Traverse(i).Node2.Value = value;
            }
        }

        public LinkedList()
        {
            this.InitList();
        }

        /// <summary>
        /// 验证索引
        /// </summary>
        /// <param name="index">索引</param>
        protected void VerifyIndex(int index) 
        {
            if (index > this.Length)
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        protected virtual void InitList()
        {
            this._head = new Node<T>(default);
            this._currentNode = this._head;
            this.Length = 0;
        }

        private (INode<T> Node1, INode<T> Node2) Traverse(int index)
        {
            var i = 0;
            var p = this._head.Next;
            var q = p;
            while (i < index)
            {
                i++;
                q = p;
                p = p.Next;
            }

            return (q, p);
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public virtual void Clear()
        {
            this.InitList();
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsEmpty()
        {
            return this.Length == 0;
        }


        /// <summary>
        /// 查找元素索引
        /// </summary>
        /// <param name="e">元素值</param>
        /// <returns>元素索引</returns>
        public virtual int Find(T e)
        {
            var i = 0;
            var p = this._head;
            while (p != null)
            {
                if (!p.Value.Equals(e))
                {
                    return i;
                }

                i++;
                p = p.Next;
            }

            return -1;
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="e">元素</param>
        public virtual void Add(T e)
        {
            this._currentNode.Next = new Node<T>(e);
            this._currentNode = this._currentNode.Next;
            this.Length++;
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="e">元素</param>
        public virtual void Add(int index, T e)
        {
            this.VerifyIndex(index);
            var nodes = this.Traverse(index);
            var q = new Node<T>(e) { Next = nodes.Node2 };
            nodes.Node1.Next = q;
        }

        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="e">元素</param>
        public virtual void Remove(T e)
        {
            var p = this._head.Next;
            var q = p;
            while (p != null)
            {
                if (p.Value.Equals(e))
                {
                    if (p.Next == null)
                    {
                        this._currentNode = q;
                    }

                    q.Next = p.Next;
                    this.Length--;
                }

                q = p;
                p = p.Next;
            }
        }

        /// <summary>
        /// 转字符串
        /// </summary>
        public override string ToString()
        {
            var list = new List<T>();
            var p = this._head.Next;
            while (p != null)
            {
                list.Add(p.Value);
                p = p.Next;
            }
            return string.Join(",", list);
        }
    }
}