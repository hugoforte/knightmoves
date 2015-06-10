using System;
using System.Collections.Generic;

namespace KnightSequences
{
    /// <summary>
    /// Class defines a key in the keypad, it can retain knowledge about the moves that are valid from itself
    /// </summary>
    class KeyPadKey
    {
        /// <summary>
        /// The text in the field (not really relevant, more for debugging
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Is the key's text a vowel 
        /// </summary>
        public bool IsVowel { get; set; }

        //
        // 
        /// <summary>
        /// What moves are valid from this position
        /// #TODO this information should not be know to the subclass
        /// </summary>
        public List<Position> ValidMoves {get; set;}

        /// <summary>
        /// Default constructor, defines a key that can be pressed and does not count as a vowel
        /// </summary>
        public KeyPadKey()
        {
            Label = "";
            IsVowel = false;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="label"></param>
        public KeyPadKey(string label)
        {
            Label = label;
            IsVowel = false;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="label"></param>
        /// <param name="isVowel"></param>
        public KeyPadKey(string label, bool isVowel)
        {
            Label = label;
            IsVowel = isVowel;
        }
    }
}
