using System;
using System.Collections.Generic;
using System.Text;

namespace C6_Command
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
    }
}
