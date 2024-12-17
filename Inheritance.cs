using System;
using System.Reflection.Emit;
namespace Inheritance{

public class Base{

public int rollno=50;

// Constructor of base class
public Base(){

}

public void Display(){

    Console.WriteLine("This is method of Derived Class");
}

}

public class Derived:Base{

    public Derived(){

    }

    public void Message(){
        Console.WriteLine("This is the Method of Derived Class");
    }



public static void Main(String[] args){

Derived obj=new Derived();

obj.Message();
obj.Display();
Console.WriteLine(obj.rollno);

}


}





}