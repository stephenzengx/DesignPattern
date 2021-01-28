﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B6_Flyweight
{
    // 具体享元类A
    public class BlackIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "黑色";
        }
    }

    // 具体享元类B
    public class WhiteIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "白色";
        }
    }
}
