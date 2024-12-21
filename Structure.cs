using System;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace Structure{

//struct is user define type which is lightWeight alternative to Class
//Struct supports constructor ,indexer ,method,field,nested type,operators and properties

struct Student{

    public String name;
    public int rollno;
    public String email;

    public String phone;

    public  void DisplayDetails(){
  Console.WriteLine("Student Name:"+name);
  Console.WriteLine("Student Rollno:"+rollno);
  Console.WriteLine("Student Email:"+email);
  Console.WriteLine("Student Phone:"+phone);

    }
}

public class Test{

    public static void Main(String[] args){

//creating student types of Student
Student std;
std.name="Samir Khadka";
std.rollno=45;
std.email="samirkhadka@gmail.com";
std.phone="9841320246";


std.DisplayDetails();
    }

}


} 
