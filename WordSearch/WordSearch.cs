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
        public enum Orientation
        {
            North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest
        };
        private List<Orientation> OrientationOrder = new List<Orientation>()
        {
            Orientation.North,
            Orientation.NorthEast,
            Orientation.East,
            Orientation.SouthEast,
            Orientation.South,
            Orientation.SouthWest,
            Orientation.West,
            Orientation.NorthWest
        };

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

        public string WordLocationsString(string word)
        {
            return "";
        }

        public List<Coordinate> FindWordCoordinates(string word)
        {
            List<Coordinate> wordCoordinates = new List<Coordinate>();

            //starting at every cell
            //  look cell by cell in every direction to see if the word is there
            //  if so
            //      mark the coordinates
            //  otherwise
            //      try the next cell in every direction

            for (int row = 0; row < GridSize; row++)
            {
                for (int column = 0; column < GridSize; column++)
                {
                    foreach(Orientation orientation in OrientationOrder)
                    {

                    }
                }
            }

            return wordCoordinates;
        }

        public bool WordExistsAtCoordinateOrientation(string word, Coordinate coordinate, Orientation orientation)
        {
            for (int letterPosition = 0; letterPosition < word.Length; letterPosition++)
            {

            }

            return false;
        }

        public bool LetterExistsAtCoordinate(char letter, Coordinate coordinate)
        {

            return false;
        }

        public string AnswerLocations()
        {
            return "";
        }

        public bool CoordinateIsOutOfBounds(Coordinate coordinate)
        {
            return (coordinate.Row >= GridSize || 
                coordinate.Row < 0 || 
                coordinate.Column >= GridSize || 
                coordinate.Column < 0);
        }

        private int GetColumnIncrementFromOrientation(Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.North:
                    return 0;
                case Orientation.NorthEast:
                    return 1;
                case Orientation.East:
                    return 1;
                case Orientation.SouthEast:
                    return 1;
                case Orientation.South:
                    return 0;
                case Orientation.SouthWest:
                    return -1;
                case Orientation.West:
                    return -1;
                case Orientation.NorthWest:
                    return -1;
                default:
                    return 0;
            }
        }

        private int GetRowIncrementFromOrientation(Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.North:
                    return -1;
                case Orientation.NorthEast:
                    return -1;
                case Orientation.East:
                    return 0;
                case Orientation.SouthEast:
                    return 1;
                case Orientation.South:
                    return 1;
                case Orientation.SouthWest:
                    return 1;
                case Orientation.West:
                    return 0;
                case Orientation.NorthWest:
                    return -1;
                default:
                    return 0;
            }
        }
    }
}
