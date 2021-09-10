public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> romanNumerals=new Dictionary<char,int>();
        romanNumerals.Add('I',1);
        romanNumerals.Add('V',5);
        romanNumerals.Add('X',10);
        romanNumerals.Add('L',50);
        romanNumerals.Add('C',100);
        romanNumerals.Add('D',500);
        romanNumerals.Add('M',1000);
        
        int index=s.Length-1;
        int value=0;
        while(index>=0)
        {
          char letter=char.Parse(s.Substring(index,1));
          char nextLetter=' ';
          if(index!=0)
          {
            nextLetter=char.Parse(s.Substring(index-1,1));
          }

          if(index>0&&romanNumerals[letter]>romanNumerals[nextLetter])
          {
            value+=romanNumerals[letter]-romanNumerals[nextLetter];
            index-=2;
          }
          else
          {
            value+=romanNumerals[letter];
            index--;
          }
        }

        return value;
    }
}