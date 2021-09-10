public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        const int TARGET=0;
        IList<IList<int>> threeSum=new List<IList<int>>();
        Array.Sort(nums);
        
        for(int x=0;x<nums.Length;x++)
        {
            if(x>0&&nums[x]==nums[x-1])
            {
                continue;
            }
            int startIndex=x+1;
            int endIndex=nums.Length-1;
            Console.WriteLine(nums[x]);
            while(startIndex<endIndex)
            {
                if(
                    startIndex>x+1 &&
                    endIndex<nums.Length-1 &&
                    nums[startIndex]==nums[startIndex-1] &&
                    nums[endIndex]==nums[endIndex+1]
                ){
                    startIndex++;
                    endIndex--;
                    continue;
                }
                int sum=nums[x]+nums[startIndex]+nums[endIndex];
                if(sum>TARGET)
                {
                    endIndex--;
                }
                else if (sum<TARGET)
                {
                    startIndex++;
                }
                else if(sum==TARGET)
                {
                    IList<int> newList=new List<int>();
                    newList.Add(sum=nums[x]);
                    newList.Add(sum=nums[startIndex]);
                    newList.Add(sum=nums[endIndex]);
                    
                    // if(!ListContains(threeSum,newList))
                    // {
                        threeSum.Add(newList);
                    // }
                    startIndex++;
                    endIndex--;
                }
            }
        }
        
        return threeSum;
    }
    public bool ListContains(IList<IList<int>> threeSum,IList<int> newList)
    {
        // foreach(IList<int> sublist in threeSum)
        // {
            // if(
            //     sublist[0]==newList[0] &&
            //     sublist[1]==newList[1] &&
            //     sublist[2]==newList[2]
            // ){
            //     return true;
            // }
        // }
        return false;
    }
}