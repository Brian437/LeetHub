public class Solution {
    public int NumRookCaptures(char[][] board) {
        int captureCount=0;
        int rookX=0;
        int rookY=0;
        for(int x=0;x<board.Length;x++)
        {
            for(int y=0;y<board[x].Length;y++)
            {
                if(board[x][y]=='R')
                {
                    rookX=x;
                    rookY=y;
                }
            }
        }
        if(Move(board,rookX,rookY,1,0))
        {
            captureCount++;
        }
        if(Move(board,rookX,rookY,-1,0))
        {
            captureCount++;
        }
        if(Move(board,rookX,rookY,0,1))
        {
            captureCount++;
        }
        if(Move(board,rookX,rookY,0,-1))
        {
            captureCount++;
        }
        
        
        return captureCount;
    }
    public bool Move(char[][] board,int x,int y, int pathX, int pathY)
    {
        if(x<0||x>=board.Length || y<0||y>=board[0].Length)
        {
            return false;
        }
        if(board[x][y]=='B')
        {
            return false;
        }
        if(board[x][y]=='p')
        {
            return true;
        }
        return Move(board,x+pathX,y+pathY,pathX,pathY);
    }
}