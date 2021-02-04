﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C91_Interpreter.Expression
{
    /// <summary>
    /// 非终结符表达式：And解释
    /// </summary>
    public class AndNode : AbstractNode
    {
        private AbstractNode left;
        private AbstractNode right;

        public AndNode(AbstractNode left, AbstractNode right)
        {
            this.left = left;
            this.right = right;
        }

        // And表达式解释操作
        public override string Interpret()
        {
            return left.Interpret() + " 再 " + right.Interpret();
        }
    }
}
