using System;
using System.Collections.Generic;
using System.Text;

namespace A3_Prototype.PrototypeManage
{
    public class FAR : OfficeDocument
    {
        public OfficeDocument Clone()
        {
            return new FAR();
        }

        public void Display()
        {
            Console.WriteLine("<<可行性分析报告>>");
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }

    public class SRS : OfficeDocument
    {
        public OfficeDocument Clone()
        {
            return new SRS();
        }

        public void Display()
        {
            Console.WriteLine("<<软件需求规格说明书>>");
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
