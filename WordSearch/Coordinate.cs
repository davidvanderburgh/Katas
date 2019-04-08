using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearchKata
{
    public class Coordinate
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override bool Equals(object obj)
        {
            Coordinate otherCoordinate = (Coordinate)obj;
            return ((Row == otherCoordinate.Row) && (Column == otherCoordinate.Column));
        }

        public override string ToString()
        {
            return "(" + Column + ", " + Row + ")";
        }

    }
}
