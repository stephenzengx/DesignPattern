using System;
using System.Collections.Generic;
using System.Text;

namespace A3_Prototype.PrototypeManage
{
    public interface OfficeDocument : ICloneable
    {
        new OfficeDocument Clone(); // 隐藏ICloneable的Clone接口方法定义
        void Display();
    }
}
