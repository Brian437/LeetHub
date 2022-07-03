public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int total=nums1.Length+nums2.Length;
        int mid=total/2;
        int current=0;
        int left=0;
        int right=0;
        double median=0;
        
        bool evenCount=total%2==0;
        
        if(evenCount)
        {
            mid--;
        }
        
        while(current<mid)
        {
            median=SmallerNumber(nums1,nums2,ref left,ref right);
            current=left+right;
        }
        
        if(evenCount)
        {
            median=SmallerNumber(nums1,nums2,ref left, ref right);
            median+=SmallerNumber(nums1,nums2,ref left, ref right);
            median/=2;
            return median;
        }
        else
        {
            return SmallerNumber(nums1,nums2,ref left, ref right);
        }
        
        //return -1;
    }
    private double SmallerNumber(int[] nums1, int[] nums2,ref int left, ref int right)
    {
        double smallerNumber=0;
        
        
        
        if(left>=nums1.Length && right>=nums2.Length)
        {
            throw new Exception("No more numbers");
        }
        if(left>=nums1.Length)
        {
            smallerNumber=nums2[right];
            right++;
            return smallerNumber;
        }
        if(right>=nums2.Length)
        {
            smallerNumber=nums1[left];
            left++;
            return smallerNumber;
        }
        if(nums1[left]>nums2[right])
        {
            smallerNumber=nums2[right];
            right++;
            return smallerNumber;
        }
        else
        {
            smallerNumber=nums1[left];
            left++;
            return smallerNumber;
        }
    }
}