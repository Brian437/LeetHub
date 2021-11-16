public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        
        int left=0;
        int right=0;
        int highestLength=0;
        
        while(right<nums1.Length)
        {
            // Console.WriteLine("Right: "+right);
            // Console.WriteLine("Left: "+left);
            
            //Sliding Window;
            if(ContainsSubArray(left,right,nums1,nums2))
            {
                //valid
                int length=right-left+1;
                // Console.WriteLine("Length: "+length);
                highestLength=Math.Max(length,highestLength);
                right++;
                
            }
            else
            {
                // invalid
                left++;
            }
            right=Math.Max(left,right);
            // Console.WriteLine("##########");
            
        }
        return highestLength;
    }
    
    public bool ContainsSubArray(
        int start,
        int end, 
        int[] mainArray, 
        int[] searchArray
    ){
        int length=end-start+1;
        
        // if(start==0 && end==4)
        // {
        //     Console.WriteLine("TEST101");
        // }
        
        for(int i=0;i<=searchArray.Length - length;i++)
        {
            // if(start==0 && end==4)
            // {
            //     Console.WriteLine("TEST102");
            // }
            if(mainArray[start]==searchArray[i])
            {
                // if(start==0 && end==4)
                // {
                //     Console.WriteLine("TEST103");
                // }
                for(int j=0;j<length;j++)
                {
                    // Console.WriteLine("i:"+i);
                    // Console.WriteLine("j:"+j);
                    // Console.WriteLine("----------");
                    // if(start==0 && end==4)
                    // {
                    //     Console.WriteLine("TEST104-"+j);
                    // }
                    if(mainArray[start+j]!=searchArray[i+j])
                    {
                        break;
                    }
                    if(j+1==length)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}





/*

nums1 nums2


biggest repeated subarray

[1,2,3,2,1]
   l
   r

[3,2,1,4,7]
      
[3,2,1]

highestLength


*/