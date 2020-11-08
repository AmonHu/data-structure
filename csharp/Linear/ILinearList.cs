using System;

namespace Linear
{
    public interface ILinearList<T>
    {
        T this[int i] { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        int Length { get; }

        /// <summary>
        /// 清空列表
        /// </summary>
        void Clear();

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns>true/false</returns>
        bool IsEmpty();

        /// <summary>
        /// 查找元素索引
        /// </summary>
        /// <param name="e">元素值</param>
        /// <returns>元素索引</returns>
        int Find(T e);

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="e">元素</param>
        void Add(T e);

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="e">元素</param>
        void Add(int index, T e);

        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="e">元素</param>
        void Remove(T e);

        /// <summary>
        /// 转字符串
        /// </summary>
        string ToString();

    }
}