public class Solution {
    public int UniquePathsIII(int[][] grid) {
        int pathCount=0;
        int startX=-1;
        int startY=-1;
        int endX=-1;
        int endY=-1;
        int emptySquareCounter=0;
        
        for(int x=0;x<grid.Length;x++)
        {
            // Console.WriteLine("X:"+x);
            for(int y=0;y<grid[x].Length;y++)
            {
                // Console.WriteLine("Y:"+y);
                // Console.WriteLine(grid[x][y]);
                if(grid[x][y]==0)
                {
                    emptySquareCounter++;
                }
                if(grid[x][y]==1)
                {
                    startX=x;
                    startY=y;
                }
                if(grid[x][y]==2)
                {
                    endX=x;
                    endY=y;
                }
            }
        }
        if(startX==-1)
        {
            throw new Exception("No starting points");
        }
        else if(endX==-1)
        {
            throw new Exception("No ending points");
        }
        
        MoveToPath(startX,startY,endX,endY,ref pathCount,grid,emptySquareCounter,0,"");
        return pathCount;
    }
    public void MoveToPath(
        int x,
        int y,
        int endX,
        int endY,
        ref int pathCount,
        int[][] grid,
        int emptySquareCounter,
        int moveCounter,
        string direction
    ){
        //Basecases

        //Out of bounds
        if(x<0 || x>=grid.Length || y<0 || y>=grid[0].Length)
        {
            return;
        }
        //Reach obstacle
        {
            if(grid[x][y]==-1)
            {
                return;
            }
        }
        //Reach target
        if(x==endX && y==endY)
        {
            if(moveCounter==emptySquareCounter+1)
            {
                // Console.WriteLine(direction);
                pathCount++;
            }
            return;
        }
        //reach path already traved
        if(grid[x][y]==-2)
        {
            return;
        }
        
        grid[x][y]=-2;
        //Move up
        MoveToPath(x-1, y,endX,endY,ref pathCount,grid,emptySquareCounter,moveCounter+1,direction+"U");
        //Move Down
        MoveToPath(x+1, y,endX,endY,ref pathCount,grid,emptySquareCounter,moveCounter+1,direction+"D");
        //Move Left
        MoveToPath(x, y-1,endX,endY,ref pathCount,grid,emptySquareCounter,moveCounter+1,direction+"L");
        ///Move Right
        MoveToPath(x, y+1,endX,endY,ref pathCount,grid,emptySquareCounter,moveCounter+1,direction+"R");
        grid[x][y]=0;
    }
}