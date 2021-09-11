public class Solution {
    public bool IsUgly(int num) {
        if(num==0)
        {
            return false;
        }
        bool  changed=true;
        while(changed)
        {
            changed=false;
            if(num%2==0)
            {
                num/=2;
                changed=true;
            }
            if(num%3==0)
            {
                num/=3;
                changed=true;
            }
            if(num%5==0)
            {
                num/=5;
                changed=true;
            }
        }
        return num==1;
    }
}