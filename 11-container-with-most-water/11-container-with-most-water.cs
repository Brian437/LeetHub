public class Solution {
    public int MaxArea(int[] height) {
        int maxArea=0;
        
        
        MaxAreaRecursion(height,0,height.Length-1, ref maxArea);
        
        return maxArea;
    }
    private void MaxAreaRecursion(int[] height,int left,int right,ref int maxArea,bool changeLeft=true)
    {
        
        if(left>=right)
        {
           return;
        }
        
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