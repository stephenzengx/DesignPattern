﻿using System;

namespace B5_Facade
{
    class Program
    {
        public static void Main(string[] args)
        {
            //装饰者模式: 生成1个壳包着其他的类，使类与类之间的调用关联 隐藏起来。

            //EncryptFacade facade = new EncryptFacade();
            //facade.FileEncrypt("Facade/src.txt", "Facade/des.txt");

            AbstractEncryptFacade newFacade = AppConfigHelper.GetFacadeInstance() as AbstractEncryptFacade;
            if (newFacade != null)
            {
                newFacade.FileEncrypt("Facade/src.txt", "Facade/des.txt");
            }

            Console.ReadKey();
        }

        public static void InitializeVersion()
        {
            //FileReader reader = new FileReader();             // 文件读取类
            //CipherMachine cipher = new CipherMachine();       // 数据加密类
            //FileWriter writer = new FileWriter();             // 文件保存类

            //reader = new FileReader();
            //cipher = new CipherMachine();
            //writer = new FileWriter();

            //string plainStr = reader.Read("Facade/src.txt");  // 读取源文件
            //string encryptStr = cipher.Encrypt(plainStr);     // 加密
            //writer.Write(encryptStr, "Facade/des.txt");       // 将加密结果写入新文件
        }
    }
}
