using System;
using System.Collections.Generic;
using System.Text;

namespace A3_Prototype.PrototypeManage
{
    public class PrototypeManager
    {
        public Dictionary<string, OfficeDocument> dicOD = new Dictionary<string, OfficeDocument>();

        class Nested {
            static Nested(){
            }
            internal static PrototypeManager instance = new PrototypeManager();
        }

        public static PrototypeManager GetInstance()
        {
            return Nested.instance;
        }

        private PrototypeManager()
        {
            dicOD.Add("FAR",new FAR());
            dicOD.Add("SRS", new SRS());
        }

        public void AddDoucument(string key, OfficeDocument doc) 
        {
            dicOD.Add(key,doc);
        }

        public OfficeDocument GetDocumentByKey(string key)
        {
            key = key.ToUpper();
            if (!dicOD.ContainsKey(key))
                return null;

            return dicOD[key];
        }
    }
}
