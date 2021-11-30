public class Solution {
    public string SimplifyPath(string path) {
        List<string> folderList=new List<string>();
	  string[] pathList=path.Split("/");

	  for(int i=0;i<pathList.Length;i++)
	  {
		
		string folder=pathList[i];
		if(folder=="."|| folder=="")
		{
			//skip
			continue;
		}
		else if(folder=="..")
		{
			//remove last item from List
			if(folderList.Count==0)
			{
				continue;
			}
			folderList.RemoveAt(folderList.Count-1);
		}
		else
		{
			folderList.Add(folder);
		}
	  }

		if(folderList.Count==0)
		{
			return "/";
		}
	  string result="";
	  for(int i=0;i<folderList.Count;i++)
	  {

		  result+="/"+folderList[i];
	  }

	  return result;
    }
}
/*
class Program {
  public static void Main (string[] args) {
    // Console.WriteLine ("Hello World");
	string result = SimplifyPath("/home//foo/");
	Console.WriteLine(result);
  }
  public static string SimplifyPath(string path)
  {
	  List<string> folderList=new List<string>();
	  string[] pathList=path.Split("/");

	  for(int i=0;i<pathList.Length;i++)
	  {
		
		string folder=pathList[i];
		if(folder=="."|| folder=="")
		{
			//skip
			continue;
		}
		else if(folder=="..")
		{
			//remove last item from List
			if(folderList.Count==0)
			{
				continue;
			}
			folderList.RemoveAt(folderList.Count-1);
		}
		else
		{
			folderList.Add(folder);
		}
	  }

		if(folderList.Count==0)
		{
			return "/";
		}
	  string result="";
	  for(int i=0;i<folderList.Count;i++)
	  {

		  result+="/"+folderList[i];
	  }

	  return result;
  }
}
*/