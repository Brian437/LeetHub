public class Solution {
    public int SmallestRangeI(int[] A, int K) {
        int smallestNumber=A[0];
        int largestNumber=0;
        for(int x=0;x<A.Length;x++)
        {
            if(A[x]<smallestNumber)
            {
                smallestNumber=A[x];       
            }
            if(A[x]>largestNumber)
            {
                largestNumber=A[x];
            }
        }
        
        int range=(largestNumber-K)-(smallestNumber+K);
        
        if(range>0)
        {
            return range;
        }
        else
        {
            return 0;
        }
    }
}