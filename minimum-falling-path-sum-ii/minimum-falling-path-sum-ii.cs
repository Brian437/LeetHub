public class Solution {
    public int MinFallingPathSum(int[][] arr) {
        int[,] grid =new int[arr.Length,arr[0].Length];
        
        for(int x=0;x<grid.GetLength(0);x++)
        {
            for(int y=0;y<grid.GetLength(1);y++)
            {
                grid[x,y]=smallestNumbrFromAbove(grid,x,y)+arr[x][y];
            }
        }
        int smallestNum=int.MaxValue;
        for(int y=0;y<grid.GetLength(1);y++)
        {
            smallestNum=Math.Min(grid[grid.GetLength(0)-1,y],smallestNum);
        }
        // for(int x=0;x<grid.GetLength(0);x++)
        // {
        //     for(int y=0;y<grid.GetLength(1);y++)
        //     {
        //         Console.WriteLine(grid[x,y]);
        //     }
        //     Console.WriteLine("NEXT ROW!");
        //  }
        return smallestNum;
    }
    public int smallestNumbrFromAbove(int[,] grid,int x, int y)
    {
        if(x==0)
        {
            return 0;
        }
        // if(y==0)
        // {
        //     return grid[x-1,1];
        // }
        // else if(y==(grid.GetLength(1)-1))
        // {
        //     return grid[x-1,grid.GetLength(1)-2];
        // }
        // else
        // {
        //     int left=grid[x-1,y-1];
        //     int right=grid[x-1,y+1];
        //     if(left>right)
        //     {
        //         return right;
        //     }
        //     else
        //     {
        //         return left;
        //     }
        // }
        int smallestNumber=int.MaxValue;
        for(int i=0;i<grid.GetLength(1);i++)
        {
            if(i==y)
            {
                continue;
            }
            smallestNumber=Math.Min(smallestNumber,grid[x-1,i]);
        }
        return smallestNumber;
    }
}