using System;
namespace BaseKeyword{

//Base keyword is use to access field ,constructor and methods of the base class

public class Base{

public String color="White";

//constructor
public Base(){

}


//method of base class

public void printColor(){
    Console.WriteLine("The color is :"+color);
}


public class Derived:Base{

String color="Red";

public void ShowColor(){
    Console.WriteLine("The base Color is :"+base.color);
    Console.WriteLine("The Derived Color is:"+color);
}

//calling the method of base class
public void BaseMethod(){
    base.printColor();
}



}


public class TestBase{


public static void Main(String[] args){

Derived d=new Derived();

d.ShowColor();
Console.WriteLine();

d.BaseMethod();



}


}



}







}