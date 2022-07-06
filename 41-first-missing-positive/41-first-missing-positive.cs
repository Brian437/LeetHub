public class Solution {
    public int FirstMissingPositive(int[] nums) {
        bool[] numInList=new bool[nums.Length];
        
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]<=nums.Length && nums[i]>0)
            {
                Console.WriteLine(nums[i]+"/"+i);
                numInList[nums[i]-1]=true;
            }
        }
        
        for(int i=0;i<nums.Length;i++)
        {
            if(!numInList[i])
            {
                return i+1;
            }
        }
        
        return nums.Length+1;
    }
}