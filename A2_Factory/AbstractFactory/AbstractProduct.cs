using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Factory.AbstractFactory
{
    public interface IButton
    {
        void Display();
    }

    public interface ITextField
    {
        void Display();
    }

    public interface IComboBox
    {
        void Display();
    }
}
