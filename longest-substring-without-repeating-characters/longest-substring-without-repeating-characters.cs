public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length<2)
        {
            return s.Length;
        }
        int start=0;
        int length=2;
        while((start+length)<=s.Length)
        {
            if(UniqueCharacters(s.Substring(start,length)))
            {
                length++;
            }
            else
            {
                start++;
            }
        }
        return length-1;
    }
    public bool UniqueCharacters(string word)
    {
        char[] wordChar=word.ToCharArray();
        List<char> charList=new List<char>();
        
        
        for(int x=0;x<wordChar.Length;x++)
        {
            
            if(charList.Contains(wordChar[x]))
            {
                return false;
            }
            else
            {
                charList.Add(wordChar[x]);
            }
        }
        return true;
    }
}