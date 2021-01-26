using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace A3_Prototype.ConcretePrototype
{
    [Serializable]
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public IList<Attachment> attachmentList { get; set; }

        // v2,v3
        public WeeklyLog()
        {
            this.attachmentList = new List<Attachment>();
        }

        public object Clone()
        {
            // v1
            //WeeklyLog obj = new WeeklyLog();
            //obj.Name = this.Name;
            //obj.Date = this.Date;
            //obj.Content = this.Content;
            // v2 -- shallow copy
            //obj.attachmentList = this.attachmentList;
            //return obj;
            // v3 -- deep copy
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);

                ms.Position = 0;
                return bf.Deserialize(ms);
            }
        }
    }
}
