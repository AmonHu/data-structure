namespace Linear.Linked
{


    public class LinkedList<T> : ILinearList<T>
    {
        private INode<T> _head;
        private int _length;
        private INode<T> _currentNode;

        /// <summary>
        /// 初始化列表
        /// </summary>
        public void InitList()
        {
            this._head = default;
            this._currentNode = this._head;
            this._length = 0;
        }

        /// <summary>
        /// 销毁列表
        /// </summary>
        public void DestroyList()
        {
            this._head = null;
            this._currentNode = this._head;
            this._length = 0;
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public void ClearList()
        {
            this.InitList();
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsEmpty()
        {
            return this._length == 0;
        }

        /// <summary>
        /// 获取长度
        /// </summary>
        /// <returns>长度</returns>
        public int GetLength()
        {
            return _length;
        }

        /// <summary>
        /// 访问元素
        /// </summary>
        /// <param name="index">元素索引</param>
        /// <returns>元素值</returns>
        public T GetElement(int index)
        {
            var i = 0;
            var p = this._head;
            while (i < index)
            {
                i++;
                p = p.Next;
            }

            return p.Value;
        }

        /// <summary>
        /// 查找元素索引
        /// </summary>
        /// <param name="e">元素值</param>
        /// <returns>元素索引</returns>
        public int FindElement(T e)
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

        public void Append(T e)
        {
            this._currentNode.Next = new Node<T>(e);
            this._length++;
        }

        public void Remove(T e)
        {
            var p = this._head;
            var q = p;
            while (p != null)
            {
                if (!p.Value.Equals(e))
                {
                    q.Next = p.Next;
                    this._length--;
                }

                q = p;
                p = p.Next;
            }
        }
    }
}