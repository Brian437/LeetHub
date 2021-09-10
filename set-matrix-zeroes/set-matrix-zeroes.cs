public class Solution {
    public void SetZeroes(int[][] matrix) {
        /*
          colne matrix
          111
          101
          111
          
          111
          000
          111
          
          000
          000
          000
          
          101
          000
          101
          
          fff
          ftf
          fff
          
          
          
          Create matrix of bolleans (true/false) original zeros
          go though matric
            if zero set boolen to true
            
        */
        
        // boolen[][] zero=new boolen[][matrix.Length];
        
        bool[] colZero=new bool[matrix[0].Length];
        bool[] rowZero =new bool[matrix.Length];
        
        for(int i=0;i<matrix.Length;i++)
        {
          // zero[i]=new boolen[matrix[i].Length];
          for(int j=0;j<matrix[i].Length;j++)
          {
            if(matrix[i][j]==0)
            {
              // zero[i][j]=true;
              rowZero[i]=true;
              colZero[j]=true;
            }
          }
        }
        
        for(int i=0;i<matrix.Length;i++)
        {
          // zero[i]=new boolen[matrix[i].Length];
          for(int j=0;j<matrix[i].Length;j++)
          {
            if(rowZero[i] || colZero[j])
            {
              matrix[i][j]=0;
            }
          }
        }
    }
}