using System;
using System.Collections.Generic;
using System.Text;

namespace B5_Facade
{
    /// <summary>
    /// 抽象外观类
    /// </summary>
    public abstract class AbstractEncryptFacade
    {
        public abstract void FileEncrypt(string fileNameSrc, string fileNameDes);
    }
}
