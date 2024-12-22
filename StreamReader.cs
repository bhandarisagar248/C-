using System;
using System.IO;
namespace StreamReader_ex{

public class StreamReader_Example{

public static void Main(String[] args){

String path=@"E:\C# Projects\ConsoleApp1\demo.txt";

using(FileStream file=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read)){

StreamReader sr=new StreamReader(file);

// Console.WriteLine(sr.ReadLine());
String result="";
while((result=sr.ReadLine())!=null){

    Console.WriteLine(result);
}
sr.Close();

}

}



}



}