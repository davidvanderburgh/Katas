using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchKata
{
    public class WordSearch
    {
        public string GridString { get; private set; }
        public char[,] GridArray { get; private set; }
        public int GridSize { get; private set; }
        public List<string> Answers { get; private set; }

        public WordSearch(string gridString)
        {
            GridString = gridString;
            InitializeGrid();
        }

        public void InitializeGrid()
        {
            string[] rows = GridString.Split("\n");

            //fill in answers
            string[] answers = rows[0].Split(',');
            Answers = new List<string>(answers);

            //generate char[,]
        }




        public string GetAnswerString()
        {
            return "";
        }

    }
}
