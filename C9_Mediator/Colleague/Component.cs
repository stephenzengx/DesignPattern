﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C9_Mediator
{
    /// <summary>
    /// 抽象同事类：抽象组件
    /// </summary>
    public abstract class Component
    {
        protected Mediator mediator;

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        // 转发调用
        public void Changed()
        {
            mediator.ComponenetChanged(this);
        }

        public abstract void Update();
    }
}
