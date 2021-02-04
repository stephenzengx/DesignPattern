using System;
using System.Collections.Generic;
using System.Text;

namespace C91_Interpreter.Expression
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class AbstractNode
    {
        public abstract string Interpret();
    }
}
