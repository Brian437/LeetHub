public class Solution {
    public bool IsPalindrome(int x) {
        // Console.WriteLine("Test101");
        if(x<0)
        {
            return false;
        }
        return IsPalindromString(x);
    }
    public bool IsPalindromString(int x)
    {
        // Console.WriteLine("Test102");
        string strX=x.ToString();
        // Console.WriteLine("Test103");
        for(int i=0;i<strX.Length/2;i++)
        {
            int j=strX.Length-1-i;
            // Console.WriteLine("S:"+strX[i]);
            // Console.WriteLine("E:"+(strX[strX.Length-1-i]));
            // Console.WriteLine(j);
            // Console.WriteLine("==========");
            if(strX[i]!=strX[j])
            {
                return false;
            }
        }
        return true;
    }
}