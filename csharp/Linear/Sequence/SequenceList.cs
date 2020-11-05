using System.Collections.Generic;

namespace Linear.Sequence
{
    public class SequenceList<T> : ILinearList<T>
    {
        /// <summary>
        /// 线性表
        /// </summary>
        private List<T> _list;

        /// <summary>
        /// 初始化列表
        /// </summary>
        public void InitList()
        {
            this._list = new List<T>();
        }

        /// <summary>
        /// 销毁列表
        /// </summary>
        public void DestroyList()
        {
            this._list = null;
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public void ClearList()
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
        /// 获取长度
        /// </summary>
        /// <returns>长度</returns>
        public int GetLength()
        {
            return this._list.Count;
        }

        /// <summary>
        /// 访问元素
        /// </summary>
        /// <param name="index">元素索引</param>
        /// <returns>元素值</returns>
        public T GetElement(int index)
        {
            return this._list[index];
        }

        /// <summary>
        /// 查找元素索引
        /// </summary>
        /// <param name="e">元素值</param>
        /// <returns>元素索引</returns>
        public int FindElement(T e)
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

        public void Append(T e)
        {
            this._list.Add(e);
        }

        public void Remove(T e)
        {
            this._list.Remove(e);
        }
    }
}