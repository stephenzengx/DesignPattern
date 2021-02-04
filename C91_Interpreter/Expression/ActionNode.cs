﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C91_Interpreter.Expression
{
    /// <summary>
    /// 终结符表达式：动作解释
    /// </summary>
    public class ActionNode : AbstractNode
    {
        private string action;

        public ActionNode(string action)
        {
            this.action = action;
        }

        // 动作（移动方式）表达式的解释操作
        public override string Interpret()
        {
            if (action.Equals("move", StringComparison.OrdinalIgnoreCase))
            {
                return "移动";
            }
            else if (action.Equals("run", StringComparison.OrdinalIgnoreCase))
            {
                return "快速移动";
            }
            else
            {
                return "无效指令";
            }
        }
    }
}
