using System;
using System.Collections.Generic;
using System.Text;

namespace C91_Interpreter.Expression
{
    public class DirectionNode : AbstractNode
    {
        private string direction;

        public DirectionNode(string direction)
        {
            this.direction = direction;
        }

        // 方向表达式的解释操作
        public override string Interpret()
        {
            string result = string.Empty;
            switch (direction.ToLower())
            {
                case "up":
                    result = "向上";
                    break;
                case "down":
                    result = "向下";
                    break;
                case "left":
                    result = "向左";
                    break;
                case "right":
                    result = "向右";
                    break;
                default:
                    result = "无效命令";
                    break;
            }

            return result;
        }
    }
}
