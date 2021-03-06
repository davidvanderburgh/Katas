using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WordSearchKata
{
    [TestClass]
    public class WordSearchTests
    {
        WordSearch wordSearchStarTrek;
        WordSearch wordSearchStarWars;
        WordSearch wordSearchStarGate;

        [TestInitialize]
        public void Initialize()
        {
            string gridStarTrek = "BONES,KHAN,KIRK,SCOTTY,SPOCK,SULU,UHURA\n" +
                "U,M,K,H,U,L,K,I,N,V,J,O,C,W,E\n" +
                "L,L,S,H,K,Z,Z,W,Z,C,G,J,U,Y,G\n" +
                "H,S,U,P,J,P,R,J,D,H,S,B,X,T,G\n" +
                "B,R,J,S,O,E,Q,E,T,I,K,K,G,L,E\n" +
                "A,Y,O,A,G,C,I,R,D,Q,H,R,T,C,D\n" +
                "S,C,O,T,T,Y,K,Z,R,E,P,P,X,P,F\n" +
                "B,L,Q,S,L,N,E,E,E,V,U,L,F,M,Z\n" +
                "O,K,R,I,K,A,M,M,R,M,F,B,A,P,P\n" +
                "N,U,I,I,Y,H,Q,M,E,M,Q,R,Y,F,S\n" +
                "E,Y,Z,Y,G,K,Q,J,P,C,Q,W,Y,A,K\n" +
                "S,J,F,Z,M,Q,I,B,D,B,E,M,K,W,D\n" +
                "T,G,L,B,H,C,B,E,C,H,T,O,Y,I,K\n" +
                "O,J,Y,E,U,L,N,C,C,L,Y,B,Z,U,H\n" +
                "W,Z,M,I,S,U,K,U,R,B,I,D,U,X,S\n" +
                "K,Y,L,B,Q,Q,P,M,D,F,C,K,E,A,B";

            wordSearchStarTrek = new WordSearch(gridStarTrek);

            string gridStarWars = "CHEWBACCA,JARJAR,KENOBI,LUKE,VADER,YODA\n" +
            "W,Z,R,K,I,H,C,J,M,J\n" +
            "I,Q,C,P,E,P,M,T,F,A\n" +
            "I,W,H,T,A,N,I,B,L,R\n" +
            "J,K,J,T,W,D,O,Z,P,J\n" +
            "E,K,U,L,O,V,O,B,K,A\n" +
            "U,G,Q,Y,A,Z,Q,Y,I,R\n" +
            "X,D,N,D,P,H,P,V,Y,W\n" +
            "C,H,E,W,B,A,C,C,A,E\n" +
            "J,R,Y,O,P,X,Y,O,L,X\n" +
            "S,N,F,W,H,P,T,J,W,Y";

            wordSearchStarWars = new WordSearch(gridStarWars);

            string gridStarGate = "CAMERON,DANIEL,GEORGE,HANK,JACK,JONAS,SAMANTHA,VALA\n" +
                "U,R,K,A,H,E,O,D,M,K,S,U\n" +
                "D,Q,B,C,V,I,Q,A,N,N,D,R\n" +
                "A,N,Y,C,A,X,N,N,P,A,J,A\n" +
                "Y,O,E,N,A,J,X,I,W,H,L,D\n" +
                "N,O,C,A,E,M,Y,E,F,A,B,L\n" +
                "J,M,Y,Q,H,J,E,L,V,K,K,B\n" +
                "C,I,I,G,Y,Y,O,R,S,I,G,M\n" +
                "S,A,M,A,N,T,H,A,O,E,U,S\n" +
                "S,R,L,E,C,E,E,P,O,N,I,I\n" +
                "M,R,I,E,U,N,R,R,S,N,D,L\n" +
                "P,R,A,J,N,H,G,Z,Y,P,V,J\n" +
                "G,M,X,J,S,E,S,A,N,O,J,U\n";

            wordSearchStarGate = new WordSearch(gridStarGate);
        }

        [TestMethod]
        public void Answers_FromStarTrekString()
        {
            List<string> answers = new List<string>()
            {
                "BONES",
                "KHAN",
                "KIRK",
                "SCOTTY",
                "SPOCK",
                "SULU",
                "UHURA"
            };
            CollectionAssert.AreEqual(answers, wordSearchStarTrek.Answers);
        }

        [TestMethod]
        public void GenerateGridArray_FromStarTrekString()
        {
            string[,] grid = new string[15, 15]
            {
                { "U", "M", "K", "H", "U", "L", "K", "I", "N", "V", "J", "O", "C", "W", "E" },
                { "L", "L", "S", "H", "K", "Z", "Z", "W", "Z", "C", "G", "J", "U", "Y", "G" },
                { "H", "S", "U", "P", "J", "P", "R", "J", "D", "H", "S", "B", "X", "T", "G" },
                { "B", "R", "J", "S", "O", "E", "Q", "E", "T", "I", "K", "K", "G", "L", "E" },
                { "A", "Y", "O", "A", "G", "C", "I", "R", "D", "Q", "H", "R", "T", "C", "D" },
                { "S", "C", "O", "T", "T", "Y", "K", "Z", "R", "E", "P", "P", "X", "P", "F" },
                { "B", "L", "Q", "S", "L", "N", "E", "E", "E", "V", "U", "L", "F", "M", "Z" },
                { "O", "K", "R", "I", "K", "A", "M", "M", "R", "M", "F", "B", "A", "P", "P" },
                { "N", "U", "I", "I", "Y", "H", "Q", "M", "E", "M", "Q", "R", "Y", "F", "S" },
                { "E", "Y", "Z", "Y", "G", "K", "Q", "J", "P", "C", "Q", "W", "Y", "A", "K" },
                { "S", "J", "F", "Z", "M", "Q", "I", "B", "D", "B", "E", "M", "K", "W", "D" },
                { "T", "G", "L", "B", "H", "C", "B", "E", "C", "H", "T", "O", "Y", "I", "K" },
                { "O", "J", "Y", "E", "U", "L", "N", "C", "C", "L", "Y", "B", "Z", "U", "H" },
                { "W", "Z", "M", "I", "S", "U", "K", "U", "R", "B", "I", "D", "U", "X", "S" },
                { "K", "Y", "L", "B", "Q", "Q", "P", "M", "D", "F", "C", "K", "E", "A", "B" }
            };

            CollectionAssert.AreEqual(grid, wordSearchStarTrek.GridArray);
        }

        [TestMethod]
        public void WordExistsAtCoordinateOrientation_FromStarTrekGrid()
        {
            Assert.IsTrue(wordSearchStarTrek.WordExistsAtCoordinateOrientation(
                "BONES", new Coordinate(6, 0), WordSearch.Orientation.South));
            Assert.IsTrue(wordSearchStarTrek.WordExistsAtCoordinateOrientation(
                "KHAN", new Coordinate(9, 5), WordSearch.Orientation.North));
            Assert.IsTrue(wordSearchStarTrek.WordExistsAtCoordinateOrientation(
                "KIRK", new Coordinate(7, 4), WordSearch.Orientation.West));
            Assert.IsTrue(wordSearchStarTrek.WordExistsAtCoordinateOrientation(
                "SCOTTY", new Coordinate(5, 0), WordSearch.Orientation.East));
            Assert.IsTrue(wordSearchStarTrek.WordExistsAtCoordinateOrientation(
                "SPOCK", new Coordinate(1, 2), WordSearch.Orientation.SouthEast));
            Assert.IsTrue(wordSearchStarTrek.WordExistsAtCoordinateOrientation(
                "SULU", new Coordinate(3, 3), WordSearch.Orientation.NorthWest));
            Assert.IsTrue(wordSearchStarTrek.WordExistsAtCoordinateOrientation(
                "UHURA", new Coordinate(0, 4), WordSearch.Orientation.SouthWest));
        }

        [TestMethod]
        public void LetterExistsAtCoordinate_FromStarTrekGrid()
        {
            Assert.IsTrue(wordSearchStarTrek.LetterExistsAtCoordinate('U', new Coordinate(0, 0)));
            Assert.IsTrue(wordSearchStarTrek.LetterExistsAtCoordinate('E', new Coordinate(0, 14)));
            Assert.IsTrue(wordSearchStarTrek.LetterExistsAtCoordinate('K', new Coordinate(14, 0)));
            Assert.IsTrue(wordSearchStarTrek.LetterExistsAtCoordinate('B', new Coordinate(14, 14)));
            Assert.IsFalse(wordSearchStarTrek.LetterExistsAtCoordinate('A', new Coordinate(-1, 0)));
            Assert.IsFalse(wordSearchStarTrek.LetterExistsAtCoordinate('A', new Coordinate(-1, -1)));
            Assert.IsFalse(wordSearchStarTrek.LetterExistsAtCoordinate('A', new Coordinate(6, -3)));
            Assert.IsFalse(wordSearchStarTrek.LetterExistsAtCoordinate('A', new Coordinate(30, 30)));
        }

        [TestMethod]
        public void GetCoordinatesFromOriginOrientationAndLength_FromStarTrekGrid()
        {
            List<Coordinate> test1 = wordSearchStarTrek.GetCoordinatesFromOriginOrientationAndLength(
                new Coordinate(0, 0), WordSearch.Orientation.East, 5);
            List<Coordinate> test1Expected = new List<Coordinate>()
            {
                new Coordinate(0,0),
                new Coordinate(0,1),
                new Coordinate(0,2),
                new Coordinate(0,3),
                new Coordinate(0,4)
            };

            CollectionAssert.AreEqual(test1Expected, test1);

            List<Coordinate> test2 = wordSearchStarTrek.GetCoordinatesFromOriginOrientationAndLength(
                new Coordinate(5, 6), WordSearch.Orientation.West, 3);
            List<Coordinate> test2Expected = new List<Coordinate>()
            {
                new Coordinate(5,6),
                new Coordinate(5,5),
                new Coordinate(5,4)
            };

            CollectionAssert.AreEqual(test2Expected, test2);

            List<Coordinate> test3 = wordSearchStarTrek.GetCoordinatesFromOriginOrientationAndLength(
                new Coordinate(0, 5), WordSearch.Orientation.South, 7);
            List<Coordinate> test3Expected = new List<Coordinate>()
            {
                new Coordinate(0,5),
                new Coordinate(1,5),
                new Coordinate(2,5),
                new Coordinate(3,5),
                new Coordinate(4,5),
                new Coordinate(5,5),
                new Coordinate(6,5)
            };

            CollectionAssert.AreEqual(test3Expected, test3);

            List<Coordinate> test4 = wordSearchStarTrek.GetCoordinatesFromOriginOrientationAndLength(
                new Coordinate(3, 3), WordSearch.Orientation.SouthEast, 3);
            List<Coordinate> test4Expected = new List<Coordinate>()
            {
                new Coordinate(3,3),
                new Coordinate(4,4),
                new Coordinate(5,5)
            };

            CollectionAssert.AreEqual(test4Expected, test4);
        }

        [TestMethod]
        public void FindWordCoordinates_FromStarTrekGrid()
        {
            List<Coordinate> expectedBones = new List<Coordinate>() {
                new Coordinate(6, 0),
                new Coordinate(7, 0),
                new Coordinate(8, 0),
                new Coordinate(9, 0),
                new Coordinate(10, 0)
            };
            List<Coordinate> expectedKhan = new List<Coordinate>() {
                new Coordinate(9, 5),
                new Coordinate(8, 5),
                new Coordinate(7, 5),
                new Coordinate(6, 5)
            };
            List<Coordinate> expectedKirk = new List<Coordinate>() {
                new Coordinate(7, 4),
                new Coordinate(7, 3),
                new Coordinate(7, 2),
                new Coordinate(7, 1)
            };
            List<Coordinate> expectedScotty = new List<Coordinate>() {
                new Coordinate(5, 0),
                new Coordinate(5, 1),
                new Coordinate(5, 2),
                new Coordinate(5, 3),
                new Coordinate(5, 4),
                new Coordinate(5, 5)
            };
            List<Coordinate> expectedSpock = new List<Coordinate>() {
                new Coordinate(1, 2),
                new Coordinate(2, 3),
                new Coordinate(3, 4),
                new Coordinate(4, 5),
                new Coordinate(5, 6)
            };
            List<Coordinate> expectedSulu = new List<Coordinate>() {
                new Coordinate(3, 3),
                new Coordinate(2, 2),
                new Coordinate(1, 1),
                new Coordinate(0, 0)
            };
            List<Coordinate> expectedUhura = new List<Coordinate>() {
                new Coordinate(0, 4),
                new Coordinate(1, 3),
                new Coordinate(2, 2),
                new Coordinate(3, 1),
                new Coordinate(4, 0)
            };

            List<Coordinate> actualBones = wordSearchStarTrek.FindWordCoordinates("BONES");

            CollectionAssert.AreEqual(expectedBones, actualBones );
            CollectionAssert.AreEqual(expectedKhan, wordSearchStarTrek.FindWordCoordinates("KHAN"));
            CollectionAssert.AreEqual(expectedKirk, wordSearchStarTrek.FindWordCoordinates("KIRK"));
            CollectionAssert.AreEqual(expectedScotty, wordSearchStarTrek.FindWordCoordinates("SCOTTY"));
            CollectionAssert.AreEqual(expectedSpock, wordSearchStarTrek.FindWordCoordinates("SPOCK"));
            CollectionAssert.AreEqual(expectedSulu, wordSearchStarTrek.FindWordCoordinates("SULU"));
            CollectionAssert.AreEqual(expectedUhura, wordSearchStarTrek.FindWordCoordinates("UHURA"));
        }

        [TestMethod]
        public void FindWord_FromStarTrekGrid()
        {
            string expectedBones = "BONES: (0, 6),(0, 7),(0, 8),(0, 9),(0, 10)";
            string expectedKhan = "KHAN: (5, 9),(5, 8),(5, 7),(5, 6)";
            string expectedKirk = "KIRK: (4, 7),(3, 7),(2, 7),(1, 7)";
            string expectedScotty = "SCOTTY: (0, 5),(1, 5),(2, 5),(3, 5),(4, 5),(5, 5)";
            string expectedSpock = "SPOCK: (2, 1),(3, 2),(4, 3),(5, 4),(6, 5)";
            string expectedSulu = "SULU: (3, 3),(2, 2),(1, 1),(0, 0)";
            string expectedUhura = "UHURA: (4, 0),(3, 1),(2, 2),(1, 3),(0, 4)";

            Assert.AreEqual(expectedBones, wordSearchStarTrek.WordLocationsString("BONES"));
            Assert.AreEqual(expectedKhan, wordSearchStarTrek.WordLocationsString("KHAN"));
            Assert.AreEqual(expectedKirk, wordSearchStarTrek.WordLocationsString("KIRK"));
            Assert.AreEqual(expectedScotty, wordSearchStarTrek.WordLocationsString("SCOTTY"));
            Assert.AreEqual(expectedSpock, wordSearchStarTrek.WordLocationsString("SPOCK"));
            Assert.AreEqual(expectedSulu, wordSearchStarTrek.WordLocationsString("SULU"));
            Assert.AreEqual(expectedUhura, wordSearchStarTrek.WordLocationsString("UHURA"));
        }

        [TestMethod]
        public void FindWords_FromStarTrekGrid()
        {
            string expectedOutputStarTrek = "BONES: (0, 6),(0, 7),(0, 8),(0, 9),(0, 10)\r\n" +
            "KHAN: (5, 9),(5, 8),(5, 7),(5, 6)\r\n" +
            "KIRK: (4, 7),(3, 7),(2, 7),(1, 7)\r\n" +
            "SCOTTY: (0, 5),(1, 5),(2, 5),(3, 5),(4, 5),(5, 5)\r\n" +
            "SPOCK: (2, 1),(3, 2),(4, 3),(5, 4),(6, 5)\r\n" +
            "SULU: (3, 3),(2, 2),(1, 1),(0, 0)\r\n" +
            "UHURA: (4, 0),(3, 1),(2, 2),(1, 3),(0, 4)\r\n";

            Assert.AreEqual(expectedOutputStarTrek, wordSearchStarTrek.AnswerLocations());
            
            string expectedOutputStarWars = "CHEWBACCA: (0, 7),(1, 7),(2, 7),(3, 7),(4, 7),(5, 7),(6, 7),(7, 7),(8, 7)\r\n" +
                "JARJAR: (9, 0),(9, 1),(9, 2),(9, 3),(9, 4),(9, 5)\r\n" +
                "KENOBI: (3, 0),(4, 1),(5, 2),(6, 3),(7, 4),(8, 5)\r\n" +
                "LUKE: (3, 4),(2, 4),(1, 4),(0, 4)\r\n" +
                "VADER: (5, 4),(4, 5),(3, 6),(2, 7),(1, 8)\r\n" +
                "YODA: (7, 5),(6, 4),(5, 3),(4, 2)\r\n";

            Assert.AreEqual(expectedOutputStarWars, wordSearchStarWars.AnswerLocations());

            string expectedOutputStarGate = "CAMERON: (3, 2),(4, 3),(5, 4),(6, 5),(7, 6),(8, 7),(9, 8)\r\n" +
                "DANIEL: (7, 0),(7, 1),(7, 2),(7, 3),(7, 4),(7, 5)\r\n" +
                "GEORGE: (10, 6),(9, 7),(8, 8),(7, 9),(6, 10),(5, 11)\r\n" +
                "HANK: (9, 3),(9, 2),(9, 1),(9, 0)\r\n" +
                "JACK: (5, 3),(4, 2),(3, 1),(2, 0)\r\n" +
                "JONAS: (10, 11),(9, 11),(8, 11),(7, 11),(6, 11)\r\n" +
                "SAMANTHA: (0, 7),(1, 7),(2, 7),(3, 7),(4, 7),(5, 7),(6, 7),(7, 7)\r\n" +
                "VALA: (8, 5),(9, 4),(10, 3),(11, 2)\r\n";

            Assert.AreEqual(expectedOutputStarGate, wordSearchStarGate.AnswerLocations());
        }
    }
}
