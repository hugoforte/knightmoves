using System;
using System.Collections;
using System.Collections.Generic;

namespace KnightSequences
{
    /// <summary>
    /// Represents a full kepad, can retain knowledge about all key on the keypad and calculate the number of 
    /// possble moves within itself.
    /// TODO: Processing of the valid moves could be moved out of this class
    /// </summary>
    class KeyPad
    {
        #region Class variables
        /// <summary>
        /// Stores all the keypad keys
        /// </summary>
        KeyPadKey[][] m_keyPadKeys;

        /// <summary>
        /// Used for optimization
        /// </summary>
        private Hashtable OptimizationCache { get; set; }

        /// <summary>
        /// Rows in the keypad
        /// </summary>
        private byte Rows { get; set; }

        /// <summary>
        /// Columns in the keypad
        /// </summary>
        private byte Columns { get; set; }
        #endregion
        #region KeyPad
        /// <summary>
        /// Constructor, initializes a [row x column] keypad
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public KeyPad(byte rows, byte columns)
        {
            Rows = rows;
            Columns = columns;

            m_keyPadKeys = new KeyPadKey[rows][];
            for (int i = 0; i < m_keyPadKeys.Length; i++)
            {
                m_keyPadKeys[i] = new KeyPadKey[columns];
            }
            OptimizationCache = new Hashtable();
        }
        #endregion
        #region SetPadKey
        /// <summary>
        /// Set a key to the defined coordinates
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="keyPad"></param>
        public void SetPadKey(int row, int column, KeyPadKey keyPadKey)
        {
            m_keyPadKeys[row][column] = keyPadKey;
        }
        #endregion
        #region InitializeValidMoves
        /// <summary>
        /// Generates valid moves for each key in the grid
        /// TODO: use 'on demand' initialization instead here, 
        /// the first time a key is accessed, generate the moves for it
        /// </summary>
        public void InitializeValidMoves()
        {
            for (byte row = 0; row < m_keyPadKeys.Length; row++)
            {
                for (byte column = 0; column < m_keyPadKeys[row].Length; column++)
                {
                    Position currentPos = new Position(row, column);
                    KeyPadKey currentKey = m_keyPadKeys[row][column];
                    if (currentKey != null)
                    {
                        currentKey.ValidMoves = GetKnightMoves(currentPos);
                    }
                }
            }
        }
        #endregion
        #region CantTouchThis
        /// <summary>
        /// If there is no key at the position, say so!
        /// </summary>
        /// <param name="pos">The position to check</param>
        /// <returns>True if there is nothing there</returns>
        private bool CantTouchThis(Position pos)
        {
            return m_keyPadKeys[pos.Row][pos.Column] == null;
        }
        #endregion
        #region GetKnightMoves
        /// <summary>
        /// Given a position in the grid, generates all valid knights moves from that position
        /// TODO: Should probably calculate the number of valid moves instead of hardcoding them to handle any size grid
        /// </summary>
        /// <param name="pos"></param>
        /// <returns>The list of valid moves for the position</returns>
        private List<Position> GetKnightMoves(Position pos)
        {
            List<Position> validMoves = new List<Position>();
            //down two and left one
            if (pos.Row < 2 && pos.Column > 0)
            {
                Position validMove = new Position((byte)(pos.Row + 2), (byte)(pos.Column - 1));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }

            //Up two and right one
            if (pos.Row > 1 && pos.Column < Columns - 1)
            {
                Position validMove = new Position((byte)(pos.Row - 2), (byte)(pos.Column + 1));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }

            //Up two and left one
            if (pos.Row > 1 && pos.Column > 0)
            {
                Position validMove = new Position((byte)(pos.Row - 2), (byte)(pos.Column - 1));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }

            //Down two and right one
            if (pos.Row < 2 && pos.Column < Columns - 1)
            {
                Position validMove = new Position((byte)(pos.Row + 2), (byte)(pos.Column + 1));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }

            //Up one and right two
            if (pos.Row > 0 && pos.Column < Columns - 2)
            {
                Position validMove = new Position((byte)(pos.Row - 1), (byte)(pos.Column + 2));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }

            //Down one and left two
            if (pos.Row < Rows - 1 && pos.Column > 1)
            {
                Position validMove = new Position((byte)(pos.Row + 1), (byte)(pos.Column - 2));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }

            //Up one and left two
            if (pos.Row > 0 && pos.Column > 1)
            {
                Position validMove = new Position((byte)(pos.Row - 1), (byte)(pos.Column - 2));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }

            //Down one and right two            
            if (pos.Row < Rows - 1 && pos.Column < Columns - 2)
            {
                Position validMove = new Position((byte)(pos.Row + 1), (byte)(pos.Column + 2));
                if (!CantTouchThis(validMove))
                {
                    validMoves.Add(validMove);
                }
            }
            return validMoves;
        }
        #endregion
        #region GetKeyPad
        /// <summary>
        /// Returns the keypad key in the given position
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public KeyPadKey GetKeyPadKey(Position pos)
        {
            return m_keyPadKeys[pos.Row][pos.Column];
        }
        #endregion
        #region GetNumberOfValidMoves
        /// <summary>
        /// Caluclates the number of possible knight move sequences
        /// </summary>
        /// <param name="movesInSequence">The number of moves that consitutes a complete sequence</param>
        /// <param name="vowelsAllowed">The number of vowels allowed in the sequence</param>
        /// <returns>The number of possible moves</returns>
        public long GetNumberOfValidMoves(int movesInSequence, int vowelsAllowed)
        {
            long numberOfValidMoves = 0;
            for (byte row = 0; row < m_keyPadKeys.Length; row++)
            {
                for (byte column = 0; column < m_keyPadKeys[row].Length; column++)
                {
                    KeyPadKey currentKey = m_keyPadKeys[row][column];
                    //if we have a current key and
                    //1 The key is not a vowel OR the key is a vowel and we have vowels left to use in the sequence
                    if (currentKey != null && ((!currentKey.IsVowel) || (currentKey.IsVowel && vowelsAllowed > 0)))
                    {
                        numberOfValidMoves += GetValidMovesForKey(movesInSequence, currentKey,
                             (currentKey.IsVowel) ? vowelsAllowed - 1 : vowelsAllowed);
                    }
                }
            }
            return numberOfValidMoves;
        }
        #endregion
        #region GetValidMovesForKey
        /// <summary>
        /// Returns the number of possible moves for a key
        /// TODO - Done: Implement cashe that just returns the moves if the function has been called before with the same criteria
        /// TODO: Can I calculate the number of moves instead of iterating through the sequence
        /// </summary>
        /// <param name="movesInSequence"></param>
        /// <param name="key"></param>
        /// <param name="vowelsAllowed"></param>
        /// <returns></returns>
        public long GetValidMovesForKey(int movesInSequence, KeyPadKey key, int vowelsAllowed)
        {
            //Try to fetch this sequence from cashe if is has already been processed
            //This made a DRASTIC performance increase
            long numberOfValidMoves = GetValidMovesForKeyFromCashe(movesInSequence, key, vowelsAllowed);
            if (numberOfValidMoves > 0)
            {
                return numberOfValidMoves;
            }

            if (movesInSequence > 1)
            {
                foreach (Position validMove in key.ValidMoves)
                {
                    KeyPadKey keyToMoveTo = GetKeyPadKey(validMove);
                    if (keyToMoveTo != null && ((!keyToMoveTo.IsVowel) || (keyToMoveTo.IsVowel && vowelsAllowed > 0)))
                    {
                        numberOfValidMoves += GetValidMovesForKey(movesInSequence - 1, keyToMoveTo,
                            (keyToMoveTo.IsVowel) ? vowelsAllowed - 1 : vowelsAllowed);
                    }
                }
            }
            else
            {
                return 1;
            }
            string casheKey = movesInSequence.ToString() + ":" + key.Label + ":" + vowelsAllowed.ToString();
            //only add if cachekey does not already exist
            if (!OptimizationCache.Contains(casheKey))
            {
                OptimizationCache.Add(casheKey, numberOfValidMoves);
            }
            //save result in cache

            return numberOfValidMoves;
        }
        #endregion
        #region GetValidMovesForKeyFromCashe
        /// <summary>
        /// Generates a cashekey from the numberOfMovesInSequence, key.label and vowelsAllowed and determines if this 
        /// combination has already been hit
        /// </summary>
        /// <param name="movesInSequence"></param>
        /// <param name="key"></param>
        /// <param name="vowelsAllowed"></param>
        /// <returns>The number of valid moves from here on, or 0 if not processed yet</returns>
        private long GetValidMovesForKeyFromCashe(int movesInSequence, KeyPadKey key, int vowelsAllowed)
        {
            string casheKey = movesInSequence.ToString() + ":" + key.Label + ":" + vowelsAllowed.ToString();
            if (OptimizationCache.ContainsKey(casheKey))
            {
                return (long)OptimizationCache[casheKey];
            }
            else
            {
                return 0;
            }

        }
        #endregion
        #region CalculateValidMovesForKey
        /// <summary>
        /// TODO: Is there a way to just calculate the number of valid moves instead of recursively finding out?
        /// </summary>
        /// <param name="movesInSequence"></param>
        /// <param name="key"></param>
        /// <param name="vowelsAllowed"></param>
        /// <returns></returns>
        public long CalculateValidMovesForKey(int movesInSequence, KeyPadKey key, int vowelsAllowed)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
