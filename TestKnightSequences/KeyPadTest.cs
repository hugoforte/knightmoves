using KnightSequences;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System;

namespace TestKnightSequences
{
    
    
    /// <summary>
    ///This is a test class for KeyPadTest and is intended
    ///to contain all KeyPadTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KeyPadTest
    {
        #region Additional test attributes
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        #region GetSequencesPerKey
        /*************************************************
         * Checks a sequence of 2 moves with no vovels, The number of valid moves should equal the sum of the
         * possible moves for each key, unless the move is to a vovel
        **************************************************/
        #region GetSequenceOfTwoForEachKeyWithNoLimitations
        [TestMethod()]
        public void GetSequenceOfTwoForEachKeyWithNoLimitations()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();
            KeyPadKey A = keyPad.GetKeyPadKey(new Position(0, 0));
            KeyPadKey B = keyPad.GetKeyPadKey(new Position(0, 1));
            KeyPadKey C = keyPad.GetKeyPadKey(new Position(0, 2));
            KeyPadKey D = keyPad.GetKeyPadKey(new Position(0, 3));
            KeyPadKey E = keyPad.GetKeyPadKey(new Position(0, 4));

            KeyPadKey F = keyPad.GetKeyPadKey(new Position(1, 0));
            KeyPadKey G = keyPad.GetKeyPadKey(new Position(1, 1));
            KeyPadKey H = keyPad.GetKeyPadKey(new Position(1, 2));
            KeyPadKey I = keyPad.GetKeyPadKey(new Position(1, 3));
            KeyPadKey J = keyPad.GetKeyPadKey(new Position(1, 4));

            KeyPadKey K = keyPad.GetKeyPadKey(new Position(2, 0));
            KeyPadKey L = keyPad.GetKeyPadKey(new Position(2, 1));
            KeyPadKey M = keyPad.GetKeyPadKey(new Position(2, 2));
            KeyPadKey N = keyPad.GetKeyPadKey(new Position(2, 3));
            KeyPadKey O = keyPad.GetKeyPadKey(new Position(2, 4));

            KeyPadKey one = keyPad.GetKeyPadKey(new Position(3, 1));
            KeyPadKey two = keyPad.GetKeyPadKey(new Position(3, 2));
            KeyPadKey three = keyPad.GetKeyPadKey(new Position(3, 3));

            //Number of valid moves are equal to the sum of the possible moves for each key
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, A, 2), "A");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, B, 2), "B");
            Assert.AreEqual(4, keyPad.GetValidMovesForKey(2, C, 2), "C");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, D, 2), "D");
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, E, 2), "E");

            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, F, 2), "F");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, G, 2), "G");
            Assert.AreEqual(6, keyPad.GetValidMovesForKey(2, H, 2), "H");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, I, 2), "I");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, J, 2), "J");

            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, K, 2), "K");
            Assert.AreEqual(4, keyPad.GetValidMovesForKey(2, L, 2), "L");
            Assert.AreEqual(4, keyPad.GetValidMovesForKey(2, M, 2), "M");
            Assert.AreEqual(4, keyPad.GetValidMovesForKey(2, N, 2), "N");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, O, 2), "O");

            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, one, 2), "One");
            Assert.AreEqual(4, keyPad.GetValidMovesForKey(2, two, 2), "Two");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, three, 2), "Three");
        }
        #endregion

        /*************************************************
         * Checks a sequence of 2 moves with no vovels, The number of valid moves should equal the sum of the
         * possible moves for each key, unless the move is to a vovel
        **************************************************/
        #region GetSequenceOfTwoWithNoVowelsAllowed
        [TestMethod()]
        public void GetSequenceOfTwoWithNoVowelsAllowed()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();
            KeyPadKey A = keyPad.GetKeyPadKey(new Position(0, 0));
            KeyPadKey B = keyPad.GetKeyPadKey(new Position(0, 1));
            KeyPadKey C = keyPad.GetKeyPadKey(new Position(0, 2));
            KeyPadKey D = keyPad.GetKeyPadKey(new Position(0, 3));
            KeyPadKey E = keyPad.GetKeyPadKey(new Position(0, 4));

            KeyPadKey F = keyPad.GetKeyPadKey(new Position(1, 0));
            KeyPadKey G = keyPad.GetKeyPadKey(new Position(1, 1));
            KeyPadKey H = keyPad.GetKeyPadKey(new Position(1, 2));
            KeyPadKey I = keyPad.GetKeyPadKey(new Position(1, 3));
            KeyPadKey J = keyPad.GetKeyPadKey(new Position(1, 4));

            KeyPadKey K = keyPad.GetKeyPadKey(new Position(2, 0));
            KeyPadKey L = keyPad.GetKeyPadKey(new Position(2, 1));
            KeyPadKey M = keyPad.GetKeyPadKey(new Position(2, 2));
            KeyPadKey N = keyPad.GetKeyPadKey(new Position(2, 3));
            KeyPadKey O = keyPad.GetKeyPadKey(new Position(2, 4));

            KeyPadKey one = keyPad.GetKeyPadKey(new Position(3, 1));
            KeyPadKey two = keyPad.GetKeyPadKey(new Position(3, 2));
            KeyPadKey three = keyPad.GetKeyPadKey(new Position(3, 3));

            //Number of valid moves are equal to the sum of the possible moves for each key
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, A, 0), "A");
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, B, 0), "B");
            Assert.AreEqual(4, keyPad.GetValidMovesForKey(2, C, 0), "C");
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, D, 0), "D");
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, E, 0), "E");

            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, F, 0), "F");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, G, 0), "G");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, H, 0), "H");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, I, 0), "I");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, J, 0), "J");

            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, K, 0), "K");
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, L, 0), "L");
            Assert.AreEqual(4, keyPad.GetValidMovesForKey(2, M, 0), "M");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, N, 0), "N");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, O, 0), "O");

            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, one, 0), "One");
            Assert.AreEqual(2, keyPad.GetValidMovesForKey(2, two, 0), "Two");
            Assert.AreEqual(3, keyPad.GetValidMovesForKey(2, three, 0), "Three");
        }
        #endregion
        #endregion

        /*************************************************
         * Makes sure the keypad generates valid moves for each key
        **************************************************/
        #region KeyPadGeneratesValidMovesForKeys
        /// <summary>
        ///A test for InitializeValidMoves
        ///</summary>
        [TestMethod()]
        public void KeyPadGeneratesValidMovesForKeys()
        {
            //Define keypad
            KeyPad keyPad = InitKeyPadForTest();

            keyPad.InitializeValidMoves();

            //The possible positions
            Position A = new Position(0, 0);
            Position B = new Position(0, 1);
            Position C = new Position(0, 2);
            Position D = new Position(0, 3);
            Position E = new Position(0, 4);

            Position F = new Position(1, 0);
            Position G = new Position(1, 1);
            Position H = new Position(1, 2);
            Position I = new Position(1, 3);
            Position J = new Position(1, 4);

            Position K = new Position(2, 0);
            Position L = new Position(2, 1);
            Position M = new Position(2, 2);
            Position N = new Position(2, 3);
            Position O = new Position(2, 4);

            Position one = new Position(3, 1);
            Position two = new Position(3, 2);
            Position three = new Position(3, 3);

            //A can move to H,L
            Assert.IsTrue(KeyContainsValidMoves(keyPad, A, L, H), "A does not have the correct moves");
            //B can move to K,M,I
            Assert.IsTrue(KeyContainsValidMoves(keyPad, B, K, M, I), "B does not have the correct moves");
            //C can move to F,L,N,J
            Assert.IsTrue(KeyContainsValidMoves(keyPad, C, F, L, N, J), "C does not have the correct moves");
            //D can move to G,M,O
            Assert.IsTrue(KeyContainsValidMoves(keyPad, D, G, M, O), "D does not have the correct moves");
            //E can move to H,N
            Assert.IsTrue(KeyContainsValidMoves(keyPad, E, H, N), "E does not have the correct moves");
            //F can move to C,M,1
            Assert.IsTrue(KeyContainsValidMoves(keyPad, F, C, M, one), "F does not have the correct moves");
            //G can move to D,N,2
            Assert.IsTrue(KeyContainsValidMoves(keyPad, G, D, N, two), "G does not have the correct moves");
            //H can move to A,K,1,3,O,E
            Assert.IsTrue(KeyContainsValidMoves(keyPad, H, A, K, one, three, O, E), 
                "H does not have the correct moves");
            //I can move to B,L,2
            Assert.IsTrue(KeyContainsValidMoves(keyPad, I, B, L, two), "I does not have the correct moves");
            //J can move to C,M,3
            Assert.IsTrue(KeyContainsValidMoves(keyPad, J, C, M, three), "J does not have the correct moves");
            //K can move to B,H,2
            Assert.IsTrue(KeyContainsValidMoves(keyPad, K, B, H, two), "K does not have the correct moves");
            //L can move to A,3,I,C
            Assert.IsTrue(KeyContainsValidMoves(keyPad, L, A, three, I, C), "L does not have the correct moves");
            //M can move to B,F,J,D
            Assert.IsTrue(KeyContainsValidMoves(keyPad, M, B, F, J, D), "M does not have the correct moves");
            //N can move to C,G,1,E
            Assert.IsTrue(KeyContainsValidMoves(keyPad, N, C, G, one, E), "N does not have the correct moves");
            //O can move to D,H,2
            Assert.IsTrue(KeyContainsValidMoves(keyPad, O, D, H, two), "D does not have the correct moves");
            //1 can move to F,H,N
            Assert.IsTrue(KeyContainsValidMoves(keyPad, one, F, H, N), "1 does not have the correct moves");
            //2 can move to G,K,O,I
            Assert.IsTrue(KeyContainsValidMoves(keyPad, two, G, K, O, I), "2 does not have the correct moves");
            //3 can move to L, H, 
            Assert.IsTrue(KeyContainsValidMoves(keyPad, three, L, H, J), "3 does not have the correct moves");

            //should fail test
            Assert.IsFalse(KeyContainsValidMoves(keyPad, three, one, two, three), "3 does not have the correct moves");
        }

        #region KeyContainsValidMoves
        //TODO: Refactor to reduce duplicate code
        /// <summary>
        /// Checks that a position contains the correct moves
        /// </summary>
        /// <param name="keyPad">The initialized keypad</param>
        /// <param name="origin">the position to pull the origin key from</param>
        /// <param name="firstPos">first key that the origin should be movable to</param>
        /// <param name="secondPos">Second key that the origin should be movable to</param>
        /// <returns></returns>
        private bool KeyContainsValidMoves(KeyPad keyPad, Position origin, Position firstPos, Position secondPos)
        {
            KeyPadKey key = keyPad.GetKeyPadKey(origin);
            List<Position> validMoves = new List<Position>();
            validMoves.Add(firstPos);
            validMoves.Add(secondPos);
            return ListOfPositionsContainSameValues(validMoves, key.ValidMoves);
        }

        private bool KeyContainsValidMoves(KeyPad keyPad, Position origin,
            Position firstPos, Position secondPos, Position thirdPos)
        {
            KeyPadKey key = keyPad.GetKeyPadKey(origin);
            List<Position> validMoves = new List<Position>();
            validMoves.Add(firstPos);
            validMoves.Add(secondPos);
            validMoves.Add(thirdPos);
            return ListOfPositionsContainSameValues(validMoves, key.ValidMoves);
        }

        private bool KeyContainsValidMoves(KeyPad keyPad, Position origin,
            Position firstPos, Position secondPos, Position thirdPos, Position fourthPos)
        {
            KeyPadKey key = keyPad.GetKeyPadKey(origin);
            List<Position> validMoves = new List<Position>();
            validMoves.Add(firstPos);
            validMoves.Add(secondPos);
            validMoves.Add(thirdPos);
            validMoves.Add(fourthPos);
            return ListOfPositionsContainSameValues(validMoves, key.ValidMoves);
        }

        private bool KeyContainsValidMoves(KeyPad keyPad, Position origin,
            Position firstPos, Position secondPos, Position thirdPos, Position fourthPos, Position fifthPos, Position sixthPos)
        {
            KeyPadKey key = keyPad.GetKeyPadKey(origin);
            List<Position> validMoves = new List<Position>();
            validMoves.Add(firstPos);
            validMoves.Add(secondPos);
            validMoves.Add(thirdPos);
            validMoves.Add(fourthPos);
            validMoves.Add(fifthPos);
            validMoves.Add(sixthPos);
            return ListOfPositionsContainSameValues(validMoves, key.ValidMoves);
        }
        #endregion

        private bool ListOfPositionsContainSameValues(List<Position> listOne, List<Position> listTwo)
        {
            List<Position> toRemove = new List<Position>();
            for (byte i = 0; i < listOne.Count; i++)
            {
                Position hasToExist = listOne[i];
                foreach (Position p in listTwo)
                {
                    if (p.Column == hasToExist.Column && p.Row == hasToExist.Row)
                    {
                        toRemove.Add(hasToExist);
                    }
                }
            }
            foreach (Position p in toRemove)
            {
                listOne.Remove(p);
            }
            return (listOne.Count == 0);
        }

        #endregion

        /*************************************************
         * The answer to this one was given
        **************************************************/
        #region GetSequenceOfOneWithNoLimitations
        /// <summary>
        ///Tests a sequence of one with one vowel allowed
        ///</summary>
        [TestMethod()]
        public void GetSequenceOfOneWithNoLimitations()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            //Gets the number of valid moves in a sequence on 1, should be 18
            Assert.AreEqual(18, keyPad.GetNumberOfValidMoves(1, 1));
        }
        #endregion

        /*************************************************
         * The answer to this one was given
        **************************************************/
        #region GetSequenceOfOneWithNoVowels
        /// <summary>
        ///Tests a sequence of one with no vowels
        ///</summary>
        [TestMethod()]
        public void GetSequenceOfOneWithNoVowels()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            Assert.AreEqual(14, keyPad.GetNumberOfValidMoves(1, 0));
        }
        #endregion

        /*************************************************
         * Had to manually calculate this one
        **************************************************/
        #region GetSequenceOfTwoWithNoLimitation
        /// <summary>
        ///Tests a sequence of two with two vowels allowed (no limitations)
        ///</summary>
        [TestMethod()]
        public void GetSequenceOfTwoWithNoLimitation()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            Assert.AreEqual(60, keyPad.GetNumberOfValidMoves(2, 2));
        }
        #endregion

        /*************************************************
         * Had to manually calculate this one
        **************************************************/
        #region GetSequenceOfTwoWithNoVowels
        /// <summary>
        ///Tests a sequence of two with two vowels allowed (no limitations)
        ///</summary>
        [TestMethod()]
        public void GetSequenceOfTwoWithNoVowels()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            Assert.AreEqual(40, keyPad.GetNumberOfValidMoves(2, 0));
        }
        #endregion

        /*************************************************
         * Had to manually calculate this one
        **************************************************/
        #region GetSequenceOfTwoWithOneVowel
        /// <summary>
        ///Tests a sequence of two with two vowels allowed (no limitations)
        ///</summary>
        [TestMethod()]
        public void GetSequenceOfTwoWithOneVowel()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            Assert.AreEqual(60, keyPad.GetNumberOfValidMoves(2, 1));
        }
        #endregion

        /*************************************************
         * After successfully running the tests above, I was confident in my code, this test is just to verify that
         * nothing breaks as I continued to make changes to the code.
        **************************************************/
        #region Solution to Problem
        [TestMethod()]
        public void GetSequenceOfTenWithTwoVowels()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            Assert.AreEqual(1013398, keyPad.GetNumberOfValidMoves(10, 2));
        }
        #endregion

        /*************************************************
         * Here I wanted to see how long of a sequence I could squeeze in within a minute on my computer
        **************************************************/
        #region Performance Testing
        [TestMethod()]
        public void TryEleven()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();
            DateTime start = DateTime.Now;
            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            long numberOfValidMoves = keyPad.GetNumberOfValidMoves(11, 2);
            DateTime end = DateTime.Now;
            //What can I do in a minute
            Assert.IsTrue(end < start.AddMinutes(1));
        }

        [TestMethod()]
        public void TryTwelve()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            DateTime start = DateTime.Now;
            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            long numberOfValidMoves = keyPad.GetNumberOfValidMoves(12, 2);
            DateTime end = DateTime.Now;
            //What can I do in a minute
            Assert.IsTrue(end < start.AddMinutes(1));
        }

        [TestMethod()]
        public void TryThirteen()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            DateTime start = DateTime.Now;
            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            long numberOfValidMoves = keyPad.GetNumberOfValidMoves(13, 2);
            DateTime end = DateTime.Now;
            //What can I do in a minute
            Assert.IsTrue(end < start.AddMinutes(1));
        }

        [TestMethod()]
        public void TryFourteen()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            DateTime start = DateTime.Now;
            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            long numberOfValidMoves = keyPad.GetNumberOfValidMoves(14, 2);
            DateTime end = DateTime.Now;
            //What can I do in a minute
            Assert.IsTrue(end < start.AddMinutes(1));
        }

        [TestMethod()]
        public void TrySixty()
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            DateTime start = DateTime.Now;
            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            long numberOfValidMoves = keyPad.GetNumberOfValidMoves(60, 2);
            DateTime end = DateTime.Now;
            //What can I do in a minute
            Assert.IsTrue(end < start.AddMinutes(1));
        }
        #endregion

        #region InitKeyPadForTest
        /// <summary>
        /// Creates and initializes a keypad
        /// </summary>
        /// <returns></returns>
        private KeyPad InitKeyPadForTest()
        {
            KeyPad keyPad = new KeyPad(4, 5);
            //Initialize Keys
            //A can move to H,L
            keyPad.SetPadKey(0, 0, new KeyPadKey("A", true));
            //B can move to K,M,I
            keyPad.SetPadKey(0, 1, new KeyPadKey("B"));
            //C can move to F,L,N,J
            keyPad.SetPadKey(0, 2, new KeyPadKey("C"));
            //D can move to G,M,O
            keyPad.SetPadKey(0, 3, new KeyPadKey("D"));
            //E can move to H,N
            keyPad.SetPadKey(0, 4, new KeyPadKey("E", true));

            //F can move to C,M,1
            keyPad.SetPadKey(1, 0, new KeyPadKey("F"));
            //G can move to D,N,2
            keyPad.SetPadKey(1, 1, new KeyPadKey("G"));
            //H can move to A,K,1,3,O,E
            keyPad.SetPadKey(1, 2, new KeyPadKey("H"));
            //I can move to B,L,2
            keyPad.SetPadKey(1, 3, new KeyPadKey("I", true));
            //J can move to C,M,3
            keyPad.SetPadKey(1, 4, new KeyPadKey("J"));

            //K can move to B,H,2
            keyPad.SetPadKey(2, 0, new KeyPadKey("K"));
            //L can move to A,3,I,C
            keyPad.SetPadKey(2, 1, new KeyPadKey("L"));
            //M can move to B,F,J,D
            keyPad.SetPadKey(2, 2, new KeyPadKey("M"));
            //N can move to C,G,1,E
            keyPad.SetPadKey(2, 3, new KeyPadKey("N"));
            //O can move to D,H,2
            keyPad.SetPadKey(2, 4, new KeyPadKey("O", true));

            //Can't Touch This da da da da pa pam
            keyPad.SetPadKey(3, 0, null);
            //1 can move to F,H,N
            keyPad.SetPadKey(3, 1, new KeyPadKey("1"));
            //2 can move to G,K,O,I
            keyPad.SetPadKey(3, 2, new KeyPadKey("2"));
            //3 can move to L, H, J
            keyPad.SetPadKey(3, 3, new KeyPadKey("3"));
            //Can't Touch This da da da da pa pam
            keyPad.SetPadKey(3, 4, null);
            return keyPad;
        }
        #endregion
      }
}
