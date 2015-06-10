namespace KnightSequences
{
    class Position
    {
        public byte Row { get; set; }
        public byte Column { get; set; }

        public Position(byte row, byte column)
        {
            Row = row;
            Column = column;
        }
    }
}
