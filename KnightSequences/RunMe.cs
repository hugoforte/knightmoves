using System;

namespace KnightSequences
{
    class RunMe
    {
        /// <summary>
        /// Runs program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Initialize a keypad
            KeyPad keyPad = InitKeyPadForTest();
            //Generate valid moves
            keyPad.InitializeValidMoves();

            //Gets the number of valid moves in a sequence on 1 with no vowels, should be 14
            Console.WriteLine(keyPad.GetNumberOfValidMoves(10, 2));

            if (!WannaTry(11, "Wanna try sequence of 11(y/n)", keyPad))
            {
                return;
            }


            if (!WannaTry(15, "Wow, that was fast!, Wanna try sequence of 15?", keyPad))
            {
                return;
            }

            if (!WannaTry(30, "Crazy, still fast, how about 30?", keyPad))
            {
                return;
            }

            if (WannaTry(60, "Think we can do... 60?!??", keyPad))
            {
                Console.WriteLine("You won! Press any key to exit");
            }
            Console.ReadKey();
                        
        }

        /// <summary>
        /// Runs a sequence if user presses 'y'
        /// </summary>
        /// <param name="sequence">the length of the sequence</param>
        /// <param name="message">the message to be displayed before the question</param>
        /// <param name="keyPad">the keypad to compute the number of valid moves</param>
        /// <returns></returns>
        private static bool WannaTry(int sequence, string message, KeyPad keyPad){
            Console.WriteLine(message);
            ConsoleKeyInfo yesNO;
            yesNO = Console.ReadKey();
            Console.WriteLine();
            if (yesNO.KeyChar == 'Y' || yesNO.KeyChar == 'y')
            {
                Console.WriteLine(keyPad.GetNumberOfValidMoves(sequence, 2));
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Initializes a keypad
        /// </summary>
        /// <returns>the initialized keypad</returns>
        private static KeyPad InitKeyPadForTest()
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
    }
}
