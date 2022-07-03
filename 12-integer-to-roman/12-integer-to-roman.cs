public class Solution {
    public string IntToRoman(int num) {
        Dictionary<string,int> romanNumerals=new Dictionary<string,int>();
        
        romanNumerals.Add("M",1000);
        romanNumerals.Add("CM",900);
        romanNumerals.Add("D",500);
        romanNumerals.Add("CD",400);
        romanNumerals.Add("C",100);
        romanNumerals.Add("XC",90);
        romanNumerals.Add("L",50);
        romanNumerals.Add("XL",40);
        romanNumerals.Add("X",10);
        romanNumerals.Add("IX",9);
        romanNumerals.Add("V",5);
        romanNumerals.Add("IV",4);
        romanNumerals.Add("I",1);
        
        string roman="";
        int index=0;
        while(num>0)
        {
            int number=romanNumerals.ElementAt(index).Value;
            string letter=romanNumerals.ElementAt(index).Key;
            
            if(romanNumerals.ElementAt(index).Value<=num)
            {
                roman+=letter;
                num-=number;
            }
            else
            {
                index++;
            }
        }
        
        return roman;
    }
}