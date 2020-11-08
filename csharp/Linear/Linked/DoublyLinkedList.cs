using System;
using System.Collections.Generic;
using System.Text;

namespace Linear.Linked
{
    /// <summary>
    /// 双向链表
    /// </summary>
    public class DoublyLinkedList<T> : LinkedList<T>
    {
        private IDoublyNode<T> _head;
        private IDoublyNode<T> _currentNode;


        public override T this[int i]
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

        public DoublyLinkedList()
        {
            this.InitList();
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        protected override void InitList()
        {
            this._head = new DoublyNode<T>(default);
            this._currentNode = this._head;
            this.Length = 0;
        }

        private (IDoublyNode<T> Node1, IDoublyNode<T> Node2) Traverse(int index)
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
        public override void Clear()
        {
            this.InitList();
        }


        /// <summary>
        /// 查找元素索引
        /// </summary>
        /// <param name="e">元素值</param>
        /// <returns>元素索引</returns>
        public override int Find(T e)
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
        public override void Add(T e)
        {
            var p = new DoublyNode<T>(e);
            this._currentNode.Next = p;
            p.Previous = this._currentNode;
            this._currentNode = this._currentNode.Next;
            this.Length++;
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="e">元素</param>
        public override void Add(int index, T e)
        {
            this.VerifyIndex(index);
            var nodes = this.Traverse(index);
            var q = new DoublyNode<T>(e, nodes.Node2, nodes.Node1);
            nodes.Node1.Next = q;
            nodes.Node2.Previous = q;
        }

        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="e">元素</param>
        public override void Remove(T e)
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
                    p.Next.Previous = q;
                    q.Next = p.Next;

                    this.Length--;
                }

                q = p;
                p = p.Next;
            }
        }
    }
}
