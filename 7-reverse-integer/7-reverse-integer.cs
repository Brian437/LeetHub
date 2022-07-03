public class Solution {
    public int Reverse(int x) {
        string strX=x.ToString();
        string reverse="";
        bool negative=x<0;
        for(int i=0;i<strX.Length;i++)
        {
            if(strX[i]=='-')
            {
                continue;
            }
            reverse=strX[i]+reverse;
        }
        if(negative)
        {
            reverse="-"+reverse;
        }
        try
        {
            return int.Parse(reverse);
        }
        catch
        {
            return 0;
        }
        
    }
}