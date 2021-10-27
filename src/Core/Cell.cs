namespace UniformQuoridor.Core
{
    public class Cell
    {
        public int X { get; }

        public int Y { get; }

        public Cell Top { get; set; }

        public Cell Right { get; set; }

        public Cell Bottom { get; set; }

        public Cell Left { get; set; }

        public bool IsFree { get; set; } = true;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
