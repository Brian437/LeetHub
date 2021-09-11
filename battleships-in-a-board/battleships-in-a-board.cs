public class Solution {
    public int CountBattleships(char[][] board) {
        int shipCounter=0;
        for(int x=0;x<board.Length;x++)
        {
            for(int y=0;y<board[x].Length;y++)
            {
                if('X'==board[x][y])
                {
                    shipCounter++;
                    MarkShip(board,x,y);
                }
            }
            
        }
        return shipCounter;
    }
    public void MarkShip(char[][] board,int x, int y)
    {
        //Basecase
        //out of range
        if(x<0||x>=board.Length||y<0||y>=board[x].Length)
        {
            return;
        }
        //location not a ship
        if(board[x][y]!='X')
        {
            return;
        }
        board[x][y]='x';
        
        //move up
        MarkShip(board,x-1,y);
        //move down
        MarkShip(board,x+1,y);
        ///move left
        MarkShip(board,x,y-1);
        //move right
        MarkShip(board,x,y+1);
    }
}