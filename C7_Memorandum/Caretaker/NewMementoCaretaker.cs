using System;
using System.Collections.Generic;
using System.Text;

namespace C7_Memorandum
{
    /// <summary>
    /// 负责人：MementoCaretaker
    /// </summary>
    public class NewMementoCaretaker
    {
        private IList<ChessmanMemento> mementoList = new List<ChessmanMemento>();

        public ChessmanMemento GetMemento(int i)
        {
            return mementoList[i];
        }

        public void SetMemento(ChessmanMemento memento)
        {
            mementoList.Add(memento);
        }
    }
}
