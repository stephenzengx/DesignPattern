using System;
using System.Collections.Generic;
using System.Text;

namespace B2_Bridge
{
    /// <summary>
    /// 抽象操作系统实现类：实现类接口
    /// </summary>
    public interface ImageImplementor
    {
        // 显示像素矩阵
        void DoPaint(Matrix m);
    }

    /// <summary>
    /// 矩阵(辅助)类
    /// </summary>
    public class Matrix 
    {
        // 此处代码省略
    }
}
