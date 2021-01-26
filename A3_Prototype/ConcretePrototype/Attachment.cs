﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A3_Prototype.ConcretePrototype
{
    [Serializable]
    public class Attachment
    {
        public string Name { get; set; }

        public void Download()
        {
            Console.WriteLine("下载附件，文件名为：{0}", this.Name);
        }
    }
}
