using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchKata
{
    public class WordSearch
    {
        public string GridString { get; private set; }
        public string[,] GridArray { get; private set; }
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

            //generate string[,]
            GridSize = rows[1].Split(',').Length;
            GridArray = new string[GridSize, GridSize];

            for (int inputGridRow = 1; inputGridRow <= GridSize; inputGridRow++)
            {
                string[] inputGridCharacters = rows[inputGridRow].Split(',');
                for (int inputGridColumn = 0; inputGridColumn < GridSize; inputGridColumn++)
                {
                    GridArray[inputGridRow - 1, inputGridColumn] = inputGridCharacters[inputGridColumn];
                }
            }
        }




        public string GetAnswerString()
        {
            return "";
        }

    }
}
