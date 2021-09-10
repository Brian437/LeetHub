public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] sortedNums=(int[])nums.Clone();
        Array.Sort(sortedNums);
        int startIndex=0;
        int endIndex=sortedNums.Length-1;
        int lowerNumber=-1;
        int higherNumber=-1;
        while(startIndex<endIndex && lowerNumber==-1 && higherNumber==-1)
        {
            int sum=sortedNums[startIndex]+sortedNums[endIndex];
            if(sum>target)
            {
                endIndex--;
            }
            else if(sum<target)
            {
                startIndex++;
            }
            else if(sum==target)
            {
                lowerNumber=sortedNums[startIndex];
                higherNumber=sortedNums[endIndex];
            }
        }
        return new int[]{Array.IndexOf(nums,lowerNumber),Array.LastIndexOf(nums,(int)higherNumber)};
    }
}