public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int ProvinceCount=0;
        bool[] marked=new bool[isConnected.Length];
        
        /*
        
            go though each cities
            increase provence count
            visit neightbour cities
            mark the cities
            
            skip viseted cities
        
        */
        // Console.WriteLine("Test102");
        for(int i=0;i<isConnected.Length;i++)
        {
            // Console.WriteLine("Test101");
            if(marked[i])
            {
                continue;
            }
            ProvinceCount++;
            MarkCity(i,isConnected,marked);
        }
        return ProvinceCount;
    }
    public void MarkCity(int city,int[][] isConnected,bool[] marked)
    {
        // Console.WriteLine("Test103");
        if(marked[city])
        {
            return;
        }
        marked[city]=true;
        for(int i=0;i<isConnected.Length;i++)
        {
            if(isConnected[city][i]==1)
            {
                MarkCity(i,isConnected,marked);
            }
        }
    }
}