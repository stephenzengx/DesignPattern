using A3_Prototype.ConcretePrototype;
using A3_Prototype.PrototypeManage;
using System;

namespace A3_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //深度复制
            //WeeklyLog log = new WeeklyLog();
            //log.attachmentList.Add(new Attachment() { Name = "工作总结20170426-20170501_Victor.xlsx" });
            //WeeklyLog log2 = log.Clone() as WeeklyLog;
            //Console.WriteLine("周报是否相同：{0}", object.ReferenceEquals(log, log2));
            //Console.WriteLine("附件是否相同：{0}", object.ReferenceEquals(log.attachmentList[0], log2.attachmentList[0]));

            PrototypeManager pm = PrototypeManager.GetInstance();
            pm.GetDocumentByKey("FAR").Display();
            pm.GetDocumentByKey("SRS").Display();


        }
    }
}
