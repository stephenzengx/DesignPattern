using System;
using System.Collections.Generic;
using System.Text;

namespace B6_Flyweight
{ 
    /// <summary>
    /// 抽奖享元类
    /// </summary>
    public abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coord)
        {
            Console.WriteLine("棋子颜色：{0}，棋子位置：{1}", GetColor(), coord.X + "," + coord.Y);
        }
    }
}
