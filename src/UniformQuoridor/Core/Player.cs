namespace UniformQuoridor.Core
{
    public class Player
    {
        public int Id { get; }
        
        public Cell Cell { get; set; }

        public Cell[] TargetCells { get; private set; }

        public int RemainingFences { get; set; } = 10;
        
        public PlayerType PlayerType { get; set; }

        public Player(int id, Board board)
        {
            Id = id;

            InitPlayer(board);
        }

        private void InitPlayer(Board board)
        {
            const int firstRowIndex = 0;
            int lastRowIndex = board.Size - 1;
            int initialColumnIndex = board.Size / 2;

            TargetCells = new Cell[board.Size];

            if (Id == 1)
            {
                Cell = board.Cells[lastRowIndex, initialColumnIndex];
                for (int c = 0; c < board.Size; c++)
                {
                    TargetCells[c] = board.Cells[firstRowIndex, c];
                }
            }
            else
            {
                Cell = board.Cells[firstRowIndex, initialColumnIndex];
                for (int c = 0; c < board.Size; c++)
                {
                    TargetCells[c] = board.Cells[lastRowIndex, c];
                }
            }
        }

        public override string ToString()
        {
            return $"Player {Id}";
        }
    }

    public enum PlayerType
    {
        Human,
        Computer
    }
}
