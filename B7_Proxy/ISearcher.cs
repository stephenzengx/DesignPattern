using System;
using System.Collections.Generic;
using System.Text;

namespace B7_Proxy
{
    public interface ISearcher
    {
        string DoSearch(string userID, string keyword);
    }
}
