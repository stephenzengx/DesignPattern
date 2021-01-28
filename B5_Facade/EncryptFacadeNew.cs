using System;
using System.Collections.Generic;
using System.Text;

namespace B5_Facade
{
    /// <summary>
    /// 加密外观类1
    /// </summary>
    public class EncryptFacadeNew :AbstractEncryptFacade
    {
        private FileReader reader;
        private CipherMachineNew cipher;
        private FileWriter writer;

        public EncryptFacadeNew()
        {
            reader = new FileReader();
            cipher = new CipherMachineNew();
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
