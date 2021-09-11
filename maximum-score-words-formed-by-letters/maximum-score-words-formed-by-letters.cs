public class Solution {
    const int DIFFERENT_LETTERS=26;
    const int LOWERCASE_A_ASCII_KEY=97;
    
    public int MaxScoreWords(string[] words, char[] letters, int[] score) {
        Dictionary<char,int> letterCount=new Dictionary<char,int>();
        Dictionary<char,int> letterValue=new Dictionary<char,int>();
        Dictionary<char,int> lettersUsed=new Dictionary<char,int>();
        Dictionary<string,int> wordScore=new Dictionary<string,int>();
        int maxScore=0;
        int currentScore=0;
        
        
        for(int x=0;x<letters.Length;x++)
        {
            if(letterCount.ContainsKey(letters[x]))
            {
                letterCount[letters[x]]++;
            }
            else
            {
                letterCount.Add(letters[x],1);
                lettersUsed.Add(letters[x],0);
            }
        }
        for(int x=0;x<DIFFERENT_LETTERS;x++)
        {
            char letter=(char)(x+LOWERCASE_A_ASCII_KEY);
            letterValue.Add(letter,score[x]);
        }
        for(int x=0;x<words.Length;x++)
        {
            string word=words[x];
            int wordValue=WordValue(word,letterValue);
            Console.WriteLine(word+":"+wordValue);
            if(!wordScore.ContainsKey(word))
            {
                wordScore.Add(word,wordValue);
            }
        }
        GoThoughList(
            words,
            ref maxScore,
            letterCount,
            letterValue,
            lettersUsed,
            0,
            new List<string>(),
            wordScore,
            ref currentScore
        );
        
        return maxScore;
    }
    public void GoThoughList(
        string[] words,
        ref int maxScore,
        Dictionary<char,int> letterCount,
        Dictionary<char,int> letterValue,
        Dictionary<char,int> lettersUsed,
        int index,
        List<string> wordsUsed,
        Dictionary<string,int> wordScore,
        ref int currentScore
    ){
        //Base Case
        //insuffisant letters
        if(!HasEnoughLetters(letterCount,lettersUsed))
        {
            return;
        }
        //reached end of list
        
        if(currentScore>maxScore)
        {
            maxScore=currentScore;
        }
        
        if(index<words.Length)
        {
            //Add word
            LetterUsedChange(words[index], lettersUsed,1);
            wordsUsed.Add(words[index]);
            currentScore+=wordScore[words[index]];
            GoThoughList(
                words,
                ref maxScore,
                letterCount,
                letterValue,
                lettersUsed,
                index+1,
                wordsUsed,
                wordScore,
                ref currentScore
            );
            currentScore-=wordScore[words[index]];
            wordsUsed.Remove(words[index]);
            LetterUsedChange(words[index], lettersUsed,-1);

            //Skip word
            GoThoughList(
                words,
                ref maxScore,
                letterCount,
                letterValue,
                lettersUsed,
                index+1,
                wordsUsed,
                wordScore,
                ref currentScore
            );
        }
    }
    public bool HasEnoughLetters(Dictionary<char,int> letterCount,Dictionary<char,int> lettersUsed)
    {
        try
        {
            // return false;
            foreach(KeyValuePair<char,int> item in lettersUsed)
            {
                char key=item.Key;
                if(!letterCount.ContainsKey(key))
                {
                    letterCount.Add(key,0);
                }
                if(lettersUsed[key]>letterCount[key])
                {
                    return false;
                }
            }
            return true;
        }
        catch(Exception ex)
        {
            return false;
        }
        
    }
    public void LetterUsedChange(string word,Dictionary<char,int> lettersUsed,int change)
    {
        for(int x=0;x<word.Length;x++)
        {
            char letter=char.Parse(word.Substring(x,1));
            if(!lettersUsed.ContainsKey(letter))
            {
                lettersUsed.Add(letter,0);
            }
            lettersUsed[letter]+=change;
        }
    }
    public int WordValue(string word,Dictionary<char,int> letterValue)
    {
        int wordValue=0;
        for(int x=0;x<word.Length;x++)
        {
            char letter=Char.Parse(word.Substring(x,1));
            wordValue+=letterValue[letter];
        }
        return wordValue;
    }

}
