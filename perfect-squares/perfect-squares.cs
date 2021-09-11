public class Solution {
    public int NumSquares(int n) {
        int smallestSquareSize=int.MaxValue;
        SquareCounterRecursion(n,0,ref smallestSquareSize);
        return smallestSquareSize;
    }
    public void SquareCounterRecursion(
        int n,
        int currentSquareCount,
        ref int smallestSquareCount
    ){
        if(n<0)
        {
            //n is a negitive number
            return;
        }
        if(currentSquareCount>smallestSquareCount)
        {
            /*
                current square count exeeds smallest square count,
                no point of continuing since we are not going to find a smaller number
            */
            return;
        }
        if(n==0)
        {
            //n is zero
            smallestSquareCount=Math.Min(currentSquareCount,smallestSquareCount);
            return;
        }
        
        int squareLimitMax=(int)Math.Floor(
            Math.Sqrt(n)
        );
        int squareLimitMin=(int)Math.Floor(
            ((double)squareLimitMax/2)+1
        );
        for(int x=squareLimitMax;x>=squareLimitMin;x--)
        {
            SquareCounterRecursion(n-x*x,currentSquareCount+1,ref smallestSquareCount);
        }
    }
}