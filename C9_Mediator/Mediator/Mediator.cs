using System;
using System.Collections.Generic;
using System.Text;

namespace C9_Mediator
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract class Mediator
    {
        public abstract void ComponenetChanged(Component c);
    }
}
