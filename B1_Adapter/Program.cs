using System;

namespace B1_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立新的类 实现原来的接口，包在一个adapter里面，adapter帮我们调用
            IScoreOperation operation = (IScoreOperation)AppConfigHelper.GetAdpterInstance();
            if (operation == null)
                return;

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            result = operation.Sort(scores);
            Console.WriteLine("测试成绩排序结果：");
            foreach (int s in result)
            {
                Console.Write("{0},", s.ToString());
            }
            Console.WriteLine();

            score = operation.Search(scores, 90);
            if (score == -1)
            {
                Console.WriteLine("抱歉，这个真没找到~~~");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在90分选手~~~");
            }
        }
    }
}
