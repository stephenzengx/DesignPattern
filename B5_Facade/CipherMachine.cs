using System;
using System.Collections.Generic;
using System.Text;

namespace B5_Facade
{
    /// <summary>
    /// 数据加密类
    /// </summary>
    public class CipherMachine
    {
        public string Encrypt(string plainText)
        {
            Console.WriteLine("数据加密，将明文转换为密文：");
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < plainText.Length; i++)
            {
                string ch = Convert.ToString(plainText[i] % 7);
                result.Append(ch);
            }

            string encryptedResult = result.ToString();
            Console.WriteLine(encryptedResult);
            return encryptedResult;
        }
    }
}
