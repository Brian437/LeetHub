public class Solution {
    public int Rob(int[] nums) {
        // int maxValue=0;
        int[] totalValue=new int[nums.Length];
        
        // RobRecursion(nums,0,0,ref maxValue);
        // RobRecursion(nums,1,0,ref maxValue);
        if(nums.Length==0)
        {
            return 0;
        }
        if(nums.Length==1)
        {
            return nums[0];
        }
        for(int x=nums.Length-1;x>=0;x--)
        {
            if(x+2>=nums.Length)
            {
                totalValue[x]=nums[x];
            }
            else if(x+3>=nums.Length)
            {
                totalValue[x]=nums[x]+totalValue[x+2];
            }
            else if(totalValue[x+3]>totalValue[x+2])
            {
                totalValue[x]=nums[x]+totalValue[x+3];
            }
            else
            {
                totalValue[x]=nums[x]+totalValue[x+2];
            }
        }
        for(int x=0;x<totalValue.Length;x++)
        {
            Console.WriteLine(totalValue[x]);
        }
        if(totalValue[0]>totalValue[1])
        {
            return totalValue[0];
        }
        else
        {
            return totalValue[1];
        }
        // return maxValue;
    }
//     public void RobRecursion(
//         int[] nums,
//         int houseNumber,
//         int totalValue,
//         ref int maxValue
//     ){
//         //no more  houses
//         if(houseNumber>=nums.Length)
//         {
//             return;
//         }
        
//         totalValue+=nums[houseNumber];
        
//         if(totalValue>maxValue)
//         {
//             maxValue=totalValue;
//         }
        
        
//         RobRecursion(nums,houseNumber+2,totalValue,ref maxValue);
//         RobRecursion(nums,houseNumber+3,totalValue,ref maxValue);
        
//     }
}