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

            string[] answers = rows[0].Split(',');
            Answers = new List<string>(answers);

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
            StringBuilder sb = new StringBuilder();
            sb.Append(word + ": ");
            sb.Append(string.Join(',', FindWordCoordinates(word)));

            return sb.ToString();
        }

        public string AnswerLocations()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (string answer in Answers)
            {
                sb.AppendLine(WordLocationsString(answer));
            }

            return sb.ToString();
        }

        public string GridStringForCLI()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < GridSize; row++)
            {
                for (int column = 0; column < GridSize; column++)
                {
                    sb.Append(GridArray[row, column] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public List<Coordinate> FindWordCoordinates(string word)
        {
            List<Coordinate> wordCoordinates = new List<Coordinate>();
            for (int row = 0; row < GridSize; row++)
            {
                for (int column = 0; column < GridSize; column++)
                {
                    Coordinate origin = new Coordinate(row, column);
                    foreach(Orientation orientation in OrientationOrder)
                    {                        
                        if(WordExistsAtCoordinateOrientation(word, origin, orientation))
                        {
                            return GetCoordinatesFromOriginOrientationAndLength(origin, orientation, word.Length);
                        }
                    }
                }
            }
            return wordCoordinates;
        }

        public List<Coordinate> GetCoordinatesFromOriginOrientationAndLength(Coordinate origin, Orientation orientation, int length)
        {
            List<Coordinate> coordinates = new List<Coordinate>();
            for (int letterPosition = 0; letterPosition < length; letterPosition++)
            {
                Coordinate coordinate = new Coordinate(
                    origin.Row + (letterPosition * GetRowIncrementFromOrientation(orientation)),
                    origin.Column + (letterPosition * GetColumnIncrementFromOrientation(orientation)));
                coordinates.Add(coordinate);
            }
            return coordinates;
        }

        public bool WordExistsAtCoordinateOrientation(string word, Coordinate coordinate, Orientation orientation)
        {
            for (int letterPosition = 0; letterPosition < word.Length; letterPosition++)
            {
                Coordinate charCoordinate = new Coordinate(
                    coordinate.Row + (letterPosition * GetRowIncrementFromOrientation(orientation)),
                    coordinate.Column + (letterPosition * GetColumnIncrementFromOrientation(orientation)));
                if (!LetterExistsAtCoordinate(word[letterPosition], charCoordinate))
                {
                    return false;
                }
            }
            return true;
        }

        public bool LetterExistsAtCoordinate(char letter, Coordinate coordinate)
        {
            if (CoordinateIsOutOfBounds(coordinate))
            {
                return false;
            }
            else
            {
                return (GridArray[coordinate.Row, coordinate.Column] == letter.ToString());
            }            
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
