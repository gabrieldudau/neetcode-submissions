public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new int[board.Length];
        var cols = new int[board.Length];
        var squares = new int[9];
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board.Length; j++)
            {
                if (board[i][j] == '.') continue;
                int num = board[i][j] - '0';
                int mask = 1 << num;
                int square = (i / 3) * 3 + (j/3);
                if((rows[i] & mask) != 0 
                || (cols[j] & mask) != 0 
                || (squares[square] & mask) != 0) return false;
                rows[i] |= mask;
                cols[j] |= mask;
                squares[square] |= mask;
            }
        }
        return true;
    }
}
