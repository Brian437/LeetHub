public class Solution {
    public int Trap(int[] height) {
        int[] totalHeight=new int[height.Length];
        int[] totalWater=new int[height.Length];
        int[] maxHeightLeft=new int[height.Length];
        int[] maxHeightRight=new int[height.Length];
        int total=0;
        
        maxHeightLeft[0]=0;
        for(int i=1;i<height.Length;i++)
        {
            maxHeightLeft[i]=Math.Max(maxHeightLeft[i-1],height[i-1]);
        }
        
        maxHeightLeft[height.Length-1]=0;
        for(int i=height.Length-2;i>=0;i--)
        {
            maxHeightRight[i]=Math.Max(maxHeightRight[i+1],height[i+1]);
        }
        
        for(int i=0;i<height.Length;i++)
        {
            totalHeight[i]=Math.Min(maxHeightLeft[i],maxHeightRight[i]);
            totalWater[i]=totalHeight[i]-height[i];
            totalWater[i]=Math.Max(0,totalWater[i]);
            total+=totalWater[i];
            
            // Console.WriteLine("========");
            // Console.WriteLine("i:"+i);
            // Console.WriteLine("Max Height Left:"+maxHeightLeft[i]);
            // Console.WriteLine("Max Height Right:"+maxHeightRight[i]);
            // Console.WriteLine("Height:"+height[i]);
            // Console.WriteLine("Total Height:"+totalHeight[i]);
            // Console.WriteLine("Total Water:"+totalWater[i]);
            
            
        }
        return total;
    }
}