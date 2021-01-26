using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.AbstractFactory
{
    public interface ISkinFactory
    {
        IButton CreateButton();
        ITextField CreateTextField();
        IComboBox CreateComboBox();
    }
}
