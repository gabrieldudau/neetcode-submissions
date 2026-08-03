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
                int num = board[i][j] - '0';
                if(rows[i, num] || cols[j, num] 
                || squares[(i / 3) * 3 + (j/3), num]) return false;
                rows[i, num] = true;
                cols[j, num] = true;
                squares[(i / 3) * 3 + (j/3), num] = true;
            }
        }
        return true;
    }
}
