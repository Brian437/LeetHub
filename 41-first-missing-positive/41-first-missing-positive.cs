public class Solution {
    public int FirstMissingPositive(int[] nums) {
        // List<int> numList=new List<int>();
        bool[] numInList=new bool[nums.Length];
        
        for(int i=0;i<nums.Length;i++)
        {
            // if(!numList.Contains(nums[i]) && nums[i]>0)
            // {
                // numList.Add(nums[i]);
            // }
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
        
        // int num=1;
        
        // while(true)
        // {
        //     if(numList.Contains(num))
        //     {
        //         num++;
        //     }
        //     else
        //     {
        //         return num;
        //     }
        // }
        return nums.Length+1;
    }
}