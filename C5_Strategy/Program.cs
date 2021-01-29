using System;

namespace C5_Strategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            //多算法切换,多方案切换, 冗长的if-else;
            MovieTicket mt = new MovieTicket {
                _price = 60
            };

            Console.WriteLine("原始票价：{0}", mt._price);
            Console.WriteLine("----------------------------------------");
            mt.Discount = new VIPDiscount();           
            Console.WriteLine("折后票价：{0}", mt.Price);

            Console.ReadKey();
        }
    }
}
