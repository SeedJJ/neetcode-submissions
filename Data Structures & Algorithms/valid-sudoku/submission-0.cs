public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++) {
            List<char> row = board[i].ToList();
            if (!IsValidRowOrCol(row)) {
                return false;
            }
        }
        for (int i = 0; i < 9; i++) {
            List<char> col = board.Select(row => row[i]).ToList();
            if (!IsValidRowOrCol(col)) {
                return false;
            }
        }
        for (int i = 0; i < 9; i += 3) {
            for (int j = 0; j < 9; j += 3) {
                if (!IsValidBox(board, i, j)) {
                    return false;
                }
            }
        }
        return true;
    }

    bool IsValidRowOrCol(List<char> nums) {
        int[] count = new int[9];
        foreach (char c in nums) {
            if (c == '.') {
                continue;
            }
            int num = c - '0';
            count[num-1]++;
            if (count[num-1] > 1) {
                return false;
            }
        }
        return true;
    }

    bool IsValidBox(char[][] board, int startingRow, int startingCol) {
        int[] count = new int[9];

        for (int row = startingRow; row < startingRow + 3; row++) {
            for (int col = startingCol; col < startingCol + 3; col++) {
                char c = board[row][col];

                if (c == '.') {
                    continue;
                }

                int num = c - '0';

                count[num - 1]++;

                if (count[num - 1] > 1) {
                    return false;
                }
            }
        }

        return true;
    }
}
