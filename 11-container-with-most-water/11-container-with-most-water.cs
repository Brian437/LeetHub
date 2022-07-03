public class Solution {
    public int MaxArea(int[] height) {
        int maxArea=0;
        
//         for(int i=0;i<height.Length-1;i++)
//         {
//             for(int j=i+1;j<height.Length;j++)
//             {
//                 int containerHeight=Math.Min(height[i],height[j]);
//                 int containerWidth=j-i;
//                 int containerArea=containerHeight*containerWidth;
//                 maxArea=Math.Max(maxArea,containerArea);
                    
//             }
//         }
        
        // int left=0;
        // int right=height.Length-1;
        
        MaxAreaRecursion(height,0,height.Length-1, ref maxArea);
        
        return maxArea;
    }
    private void MaxAreaRecursion(int[] height,int left,int right,ref int maxArea,bool changeLeft=true)
    {
        // Console.WriteLine("left:"+left);
        // Console.WriteLine("right:"+right);
        // Console.WriteLine("==========");
        
        if(left>=right)
        {
           return;
        }
        // if(leftNumDone.Contains(left))
        // {
        //     return;
        // }
        
        int containerHeight=Math.Min(height[left],height[right]);
        int containerWidth=right-left;
        int containerArea=containerHeight*containerWidth;
        maxArea=Math.Max(maxArea,containerArea);
        
        if(changeLeft)
        {
            for(int i=left+1;i<right;i++)
            {
                if(height[i]>height[left])
                {
                    MaxAreaRecursion(height,i,right,ref maxArea);
                    break;
                }
            }
        }
        
        // leftNumDone.Add(left);
        
        for(int j=right;j>left;j--)
        {
            if(height[j]>height[right])
            {
                MaxAreaRecursion(height,left,j,ref maxArea,false);
                break;
            }
        }
    }
}