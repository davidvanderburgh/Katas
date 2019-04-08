using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchKata
{
    public class WordSearch
    {
        public string GridString { get; private set; }
        public char[,] GridArray { get; private set; }

        public WordSearch(string gridString)
        {
            GridString = gridString;
        }




        public string GetAnswerString()
        {
            return "";
        }

    }
}
