public class Solution {
    public int NumJewelsInStones(string J, string S) {
        Dictionary<char,int> stoneCountList=new Dictionary<char,int>();
        char[] charS=S.ToCharArray();
        char[] charJ=J.ToCharArray();
        for(int x=0;x<charS.Length;x++)
        {
            if(stoneCountList.ContainsKey(charS[x]))
            {
                stoneCountList[charS[x]]++;
            }
            else
            {
                stoneCountList.Add(charS[x],1);
            }
        }
        // foreach(KeyValuePair<char,int> stoneCount in stoneCountList)
        // {
        //     Console.WriteLine(stoneCount.Key+":"+stoneCount.Value);
        // }
        int numJewelsInStones=0;
        for(int x=0;x<charJ.Length;x++)
        {
            if(stoneCountList.ContainsKey(charJ[x]))
            {
                numJewelsInStones+=stoneCountList[charJ[x]];
            }
        }
        return numJewelsInStones;
    }
}