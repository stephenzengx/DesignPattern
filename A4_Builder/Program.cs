using B1_Adapter.GameRoleDemo;
using System;

namespace B1_Adapter
{
    /*
        1- 抽象工厂模式返回一系列相关产品; 建造者模式返回一个完整的复杂产品，
        2- 抽象工厂模式(汽车配件生产厂), 生成不同类型的汽车配件；建造者模式（汽车组装厂），将配件组装成一辆完整的汽车。
        3- 抽象工厂模式偏向于生产(对于系列产品生产的先后顺序没有要求)
           而建造者模式偏向于组装(对于配件的组装顺序有要求)
     */
    class Program
    {
        //Product（产品角色）
        //Builder（抽象建造者, ConcreteBuilder（具体建造者）
        //Director（指挥者）
        static void Main(string[] args)
        {
            ActorBuilder builder = (ActorBuilder)AppConfigHelper.GetBuilderInstance();
            //指挥者调用建造者方法..
            Actor actor = ActorController.Construct(builder);//这里actorcontroller 可以搞成单例

            Console.WriteLine("角色类型：{0}", actor.Type);
            Console.WriteLine("角色性别：{0}", actor.Sex);
            Console.WriteLine("角色面容：{0}", actor.Face);
            Console.WriteLine("角色服装：{0}", actor.Costume);
            Console.WriteLine("角色发型：{0}", actor.HairStyle);
        }
    }
}
