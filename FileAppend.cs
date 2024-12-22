using System;
using System.IO;
using System.Net.Mail;
using System.Text;
namespace fileAppend{


    public class File_Append{

public static void Main(String[] args){

String path=@"E:\C# Projects\ConsoleApp1\file.txt";

FileStream file=new FileStream(path,FileMode.Append,FileAccess.Write,FileShare.Read);

String data="My name is XYZ";
//converting String to byte s
byte[] data_byte=Encoding.UTF8.GetBytes(data);

//writing to the file
file.Write(data_byte,0,data_byte.Length);
Console.WriteLine("File appended Success");



}




    }
}