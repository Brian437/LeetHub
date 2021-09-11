public class Solution {
    public int NumberOfSteps (int num) {
        int counter=0;
        // Console.WriteLine(num);
        
        while(num!=0)
        {
            if(num%2==0)
            {
                num/=2;
            }
            else
            {
                num--;
            }
            counter++;
            // Console.WriteLine(num);
        }
        
        return counter;
    }
}