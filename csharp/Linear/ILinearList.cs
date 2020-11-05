using System;

namespace Linear
{
    public interface ILinearList<T>
    {
        /// <summary>
        /// 初始化列表
        /// </summary>
        void InitList();
        
        /// <summary>
        /// 销毁列表
        /// </summary>
        void DestroyList();
        
        /// <summary>
        /// 清空列表
        /// </summary>
        void ClearList();
        
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns>true/false</returns>
        bool IsEmpty();
        
        /// <summary>
        /// 获取长度
        /// </summary>
        /// <returns>长度</returns>
        int GetLength();
        
        /// <summary>
        /// 访问元素
        /// </summary>
        /// <param name="index">元素索引</param>
        /// <returns>元素值</returns>
        T GetElement(int index);
        
        /// <summary>
        /// 查找元素索引
        /// </summary>
        /// <param name="e">元素值</param>
        /// <returns>元素索引</returns>
        int FindElement(T e);
    }
}