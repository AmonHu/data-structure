namespace Linear
{
    public class Node<T> : INode<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public INode<T> Next { get; set; }
    }

    public class LinkedList<T> : ILinearList<T>
    {
        private INode<T> _head;

        /// <summary>
        /// 初始化列表
        /// </summary>
        public void InitList()
        {
            this._head = default;
        }

        /// <summary>
        /// 销毁列表
        /// </summary>
        public void DestroyList()
        {
            this._head = default;
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public void ClearList()
        {
            this._head = default;
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsEmpty()
        {
            return this._head.Next == null;
        }

        /// <summary>
        /// 获取长度
        /// </summary>
        /// <returns>长度</returns>
        public int GetLength()
        {
            var length = 0;
            var p = this._head;
            while (p.Next != null)
            {
                length++;
                p = p.Next;
            }

            return length;
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
    }
}