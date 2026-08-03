public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new bool[board.Length, 10];
        var cols = new bool[board.Length, 10];
        var squares = new bool[9, 10];
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board.Length; j++)
            {
                if (board[i][j] == '.') continue;
                if(rows[i, board[i][j] - '0'] || cols[j, board[i][j] - '0'] 
                || squares[(i / 3) * 3 + (j/3), board[i][j] - '0']) return false;
                rows[i,(int) board[i][j] - '0'] = true;
                cols[j,(int) board[i][j] - '0'] = true;
                squares[(i / 3) * 3 + (j/3), board[i][j] - '0'] = true;
            }
        }
        return true;
    }
}
