using System;
using System.Collections.Generic;
using System.Text;

namespace B2_Bridge
{
    public abstract class AbsImage
    {
        protected ImageImplementor imageImpl;

        public void SetImageImplementor(ImageImplementor imageImpl)
        {
            this.imageImpl = imageImpl;
        }

        public abstract void ParseFile(string fileName);
    }
}
