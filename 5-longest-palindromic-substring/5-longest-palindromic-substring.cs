public class Solution {
    public string LongestPalindrome(string s) {
        // return "";
        int start=0;
        // string result="";
        int length=s.Length;
        int end=start+length;
        while(length>0)
        {
            if(IsPalindrome(s,start,end))
            {
                // result=s.Substring(start,end-start);
                return s.Substring(start,length);
            }
            start++;
            end=start+length;
            
            if(end>s.Length)
            {
                length--;
                start=0;
                end=start+length;
            }
            // Console.WriteLine("Start:"+start);
            // Console.WriteLine("End:"+end);
            // Console.WriteLine("=======");
        }
        return "";
        // return result;
    }
    public bool IsPalindrome(string s,int start,int end)
    {
        return IsPalindrome(s.Substring(start,end-start));
    }
    public bool IsPalindrome(string s)
    {
        for(int i=0;i<s.Length/2;i++)
        {
            int j=s.Length-i-1;
            if(s[i]!=s[j])
            {
                return false;
            }
        }
        return true;
    }
}