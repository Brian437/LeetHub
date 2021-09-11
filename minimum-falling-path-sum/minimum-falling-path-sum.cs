public class Solution {
    public int MinFallingPathSum(int[][] A) {
        // int smallestNumber=int.MaxValue;
        // for(int y=0;y<A[0].Length;y++)
        // {
        //     MoveDownPath(A,0,y,0,ref smallestNumber);
        // }
        // return smallestNumber;
        int[,] smallestNumberGrid= new int[A.Length,A[0].Length];
        for(int x=0;x<A.Length;x++)
        {
            for(int y=0;y<A[x].Length;y++)
            {
                if(x==0)
                {
                    smallestNumberGrid[x,y]=A[x][y];
                }
                else
                {
                    int smallestNumberAbove=
                        SmallestNumberAbove(smallestNumberGrid,x,y);
                    smallestNumberGrid[x,y]=smallestNumberAbove+A[x][y];
                }
            }
        }
        
        int smallestNumber=int.MaxValue;
        for(int y=0;y<smallestNumberGrid.GetLength(1);y++)
        {
            int number=smallestNumberGrid[smallestNumberGrid.GetLength(0)-1,y];
            if(number<smallestNumber)
            {
                smallestNumber=number;
            }
        }
        // for(int x=0;x<A.Length;x++)
        // {
        //     for(int y=0;y<A[x].Length;y++)
        //     {
        //         Console.WriteLine(smallestNumberGrid[x,y]);
        //     }
        //     Console.WriteLine("NEXT ROW!");
        // }
        return smallestNumber;
    }
    public int SmallestNumberAbove(int[,] grid,int x, int y)
    {
        int smallestNumber=int.MaxValue;
        if(x==0)
        {
            return 0;
        }
        for(int i=y-1;i<=(y+1);i++)
        {
            if(i<0 || i>=grid.GetLength(1))
            {
                continue;
            }
            int number=grid[x-1,i];
            if(number<smallestNumber)
            {
                smallestNumber=number;
            }
        }
        return smallestNumber;
    }
    public void MoveDownPath(
        int[][] A,
        int x,
        int y,
        int currentValue, 
        ref int smallestNumber)
    {
        //base cases
        //out of bounds
        if(y<0 || y>=A[0].Length)
        {
            return;
        }
        int pathValue=A[x][y];
        currentValue+=pathValue;
        //reached target
        if(x==(A.Length-1))
        {
            if(currentValue<smallestNumber)
            {
                smallestNumber=currentValue;
            }
            return;
        }
        
        MoveDownPath(A,x+1,y-1,currentValue,ref smallestNumber);
        MoveDownPath(A,x+1,y,currentValue,ref smallestNumber);
        MoveDownPath(A,x+1,y+1,currentValue,ref smallestNumber);
        
    }
}