using System;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
namespace File_Handling{


public class FileExample{


public static void Main(String[] args){

String path=@"E:\C# Projects\ConsoleApp1\file.txt";  // @ is called verbatim literal

FileStream fs=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);
//file mode trauncate-> open an existing file and cut all the stored value of the file.So the file size become 0


String data="Hello Welcome to the programming World";
 byte[] data_byte=Encoding.UTF8.GetBytes(data);

 fs.Write(data_byte,0,data_byte.Length);


// fs.WriteByte(66);
// fs.WriteByte(67);  //in ASCII A starts from 65

Console.WriteLine(fs);

fs.Close();

}


}



}







