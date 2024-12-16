using System;
namespace Constructor{

public class Student{


//global variable decleration
public String name;
public int rollno;
public String email;


//default constuctor
public Student(){

}

//parameterized Constructor
public Student(String name,int rollno,String email){
    this.name=name;
    this.rollno=rollno;
    this.email=email;
}

public void display(){
    Console.WriteLine("Name:"+name);
    Console.WriteLine("Rollno:"+rollno);
    Console.WriteLine("Email:"+email);
}

public static void Main(String[] args){

    Student std=new Student("Sagar Bhandar",23,"sagarbhandari901@gmail.com");

    std.display();
}


}









}