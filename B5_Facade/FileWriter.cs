using System;
using System.Collections.Generic;
using System.Text;

namespace B5_Facade
{
    /// <summary>
    /// 文件保存类
    /// </summary>
    public class FileWriter
    {
        public void Write(string encryptedStr, string fileNameDes)
        {
            Console.WriteLine("保存密文，写入文件：");
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(encryptedStr);
            using (System.IO.FileStream fsWrite = new System.IO.FileStream(fileNameDes, System.IO.FileMode.Append))
            {
                fsWrite.Write(myByte, 0, myByte.Length);
            };

            Console.WriteLine("写入文件成功：100%");
        }
    }
}
