public class Solution {
    public string Convert(string s, int numRows) {
        /*
            L  B
            I YL
            KM O
            E  G
            LBIYLKMOEG
            
            2 modes
            down mode zig
            up-right mode zag
            
            array of lists of numbers
            go though each number and ignore spaces
        */
        
        string[] strRow=new string[numRows];
        int index=0;
        int column=0;
        int row=0;
        bool downMode=true;
        string output="";
        
        if(""==s)
        {
            return "";
        }
        if(1==numRows)
        {
            return s;
        }
        
        while(index<s.Length)
        {
            // Console.WriteLine("Index:"+index);
            // Console.WriteLine("Column:"+column);
            // Console.WriteLine("Row:"+row);
            // Console.WriteLine("DownMode:"+downMode);
            // Console.WriteLine("=======================");
            
            char letter=Char.Parse(s.Substring(index,1));
            if(downMode)
            {
                //add letter
                //move down
                strRow[row]+=letter;
                if((strRow.Length-1)<=row)
                {
                    downMode=false;
                    row--;
                    column++;
                    if(0>=row)
                    {
                         downMode=true;
                    }
                }
                else
                {
                    row++;
                }
            }
            else
            {
                //add letter
                //move up-right
                for(int x=0;x<strRow.Length;x++)
                {
                    if(x==row)
                    {
                        strRow[x]+=letter;
                    }
                }
                column++;
                row--;
                if(0>=row)
                {
                     downMode=true;
                }
            }
            index++;
        }
        for(int x=0;x<strRow.Length;x++)
        {
            if(strRow[x]==null||strRow[x]=="")
            {
                continue;
            }
            for(int y=0;y<strRow[x].Length;y++)
            {
                char letter=Char.Parse(strRow[x].Substring(y,1));
                output+=letter;
            }
        }
        return output;
    }
}