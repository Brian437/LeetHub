public class Solution {
    public int NumTilePossibilities(string tiles) {
        Dictionary <string,int> letterList=new Dictionary <string,int>();
        Dictionary <string,int> letterListUsed=new Dictionary <string,int>();
        List<string> posibleSeq=new List<string>();
        int counter=0;
        bool isUnique=true;
        for(int x=0;x<tiles.Length;x++)
        {
            String letter=tiles.Substring(x,1);
            if(letterList.ContainsKey(letter))
            {
                letterList[letter]+=1;
            }
            else
            {
                letterList.Add(letter,1);
                letterListUsed.Add(letter,0);
            }
        }
        foreach(KeyValuePair<string,int> letter in letterList)
        {
            Console.WriteLine(letter.Value);
            if(letter.Value>1)
            {
                isUnique=false;
            }
        }
        if(isUnique)
        {
            counter=0;
            int letterCount=tiles.Length;
            while (letterCount>0)
            {
                // Console.WriteLine(counter);
                counter+=nPr(tiles.Length,letterCount);//*nCr(tiles.Length,letterCount);
                letterCount--;
            }
            // foreach(KeyValuePair<string,int> letterKeyValue in letterList)
            // {
            //     // Console.WriteLine(counter);
            //     counter/=letterKeyValue.Value;
            // }
            return counter;
        }
        else
        {
            NumTilePossibilitiesRecursion(letterList,posibleSeq,"",letterListUsed);
            return posibleSeq.Count;
        }
    }
    public void NumTilePossibilitiesRecursion(
        Dictionary <string,int> letterList,
        List<string> posibleSeq,
        string word,
        Dictionary <string,int> letterListUsed
    ){
        if(word !="" &&!posibleSeq.Contains(word))
        {
            posibleSeq.Add(word);
        }
        
        foreach (KeyValuePair<string,int> letter in letterList)
        {
            if(letter.Value>letterListUsed[letter.Key])
            {
                letterListUsed[letter.Key]++;
                NumTilePossibilitiesRecursion(letterList,posibleSeq,word+letter,letterListUsed);
                letterListUsed[letter.Key]--;
            }
        }
    }
    static int fact(int n) 
    { 
        if (n <= 1) 
            return 1; 
        return n * fact(n - 1); 
    } 
  
    static int nPr(int n, int r) 
    { 
        return fact(n) / fact(n - r); 
    } 
    public static int nCr(int n, int r)
    {
        // naive: return Factorial(n) / (Factorial(r) * Factorial(n - r));
        return nPr(n, r) / fact(r);
    }
  
//     public static void Main() 
//     { 
//         int n = 5; 
//         int r = 2; 
  
//         Console.WriteLine(n + "P" + r + " = "
//                         + nPr(n, r)); 
//     } 
}