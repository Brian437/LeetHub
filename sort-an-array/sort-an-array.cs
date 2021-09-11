public class Solution {
    public int[] SortArray(int[] nums) {
        if(nums.Length<2)
        {
            return nums;
        }
        // return InsertionSort(nums);
        return MergeSort(nums);
    }
    public int[] InsertionSort(int[] nums)
    {
        if(nums.Length<2)
        {
            return nums;
        }
        for(int x=1;x<nums.Length;x++)
        {
            int y=x;
            while(y>0 && nums[y]<nums[y-1])
            {
                SwapPosition(nums,y,y-1);
                y--;
            }
        }
        return nums;
    }
    public void SwapPosition(int[] array,int pos1,int pos2)
    {
        int temp=array[pos1];
        array[pos1]=array[pos2];
        array[pos2]=temp;
    }
    public int[] MergeSort(int[] array)
    {
        // Console.WriteLine(array.Length);
        if(array.Length<=1)
        {
            return array;
        }
        int midPoint= (int)Math.Ceiling((decimal)array.Length/2);
        int[] leftArray = array.Take(midPoint).ToArray();
        int[] rightArray = array.Skip(midPoint).ToArray();
        
        leftArray=MergeSort(leftArray);
        rightArray=MergeSort(rightArray);
        
        int[] mergeArray=MergeArray(leftArray,rightArray);
        
        return mergeArray;
    }
    public int[] MergeArray(int[] leftArray, int[] rightArray)
    {
        int[] mergeArray=new int[leftArray.Length+rightArray.Length];
        int leftIndex=0;
        int rightIndex=0;
        int mergeIndex=0;
        while(leftIndex<leftArray.Length || rightIndex<rightArray.Length)
        {
            
            // Console.WriteLine("LEFT INDEX:"+leftIndex);
            // Console.WriteLine("RIGHT INDEX:"+rightIndex);
            // Console.WriteLine("LEFT VALUE:"+GetIndexValue(leftIndex,leftArray));
            // Console.WriteLine("RIGHT VALUE:"+GetIndexValue(rightIndex,rightArray));
            
            if(
                rightIndex>=rightArray.Length ||
                (leftIndex<leftArray.Length && rightArray[rightIndex]>leftArray[leftIndex])
            ){
                mergeArray[mergeIndex]=leftArray[leftIndex];
                // Console.WriteLine(mergeArray[mergeIndex]);
                leftIndex++;
                // Console.WriteLine("LEFT");
            }
            else
            {
                mergeArray[mergeIndex]=rightArray[rightIndex];
                // Console.WriteLine(mergeArray[mergeIndex]);
                rightIndex++;
                // Console.WriteLine("RIGHT");
            }
            mergeIndex++;
            // Console.WriteLine("=============");
        }
        // Console.WriteLine("=========================");
        return mergeArray;
    }
    public string GetIndexValue(int index,int[] array)
    {
        if(index>=array.Length)
        {
            return "OUT OF BOUNDS";
        }
        else
        {
            return array[index].ToString();
        }
    }
}