using System;
using System.IO;
using System.Security.Cryptography;

namespace StreamWriter_ex{

public class StreamWriter_Example{

public static void Main(String[] args){


String path=@"E:\C# Projects\ConsoleApp1\demo.txt";

using(FileStream fs=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write)){


StreamWriter sw=new StreamWriter(fs);

// String message="Hello from Stream Writer";
// sw.WriteLine(message);
// sw.WriteLine(message);
// sw.WriteLine(message);

int[] array={5,6,7,8,2,10};
foreach(var item in array){
    sw.Write(item+" ");
}


sw.Flush();
sw.Close();


}



}



}





}