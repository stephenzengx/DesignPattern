using System;
using System.Collections.Generic;
using System.Text;

namespace B5_Facade
{
    /// <summary>
    /// 加密外观类1
    /// </summary>
    public class EncryptFacade : AbstractEncryptFacade
    {
        private FileReader reader;
        private CipherMachine cipher;
        private FileWriter writer;

        public EncryptFacade()
        {
            reader = new FileReader();
            cipher = new CipherMachine();
            writer = new FileWriter();
        }

        public override void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            string plainStr = reader.Read(fileNameSrc);
            string encryptedStr = cipher.Encrypt(plainStr);
            writer.Write(encryptedStr, fileNameDes);
        }
    }
}
