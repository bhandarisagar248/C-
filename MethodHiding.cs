using System;
namespace MethodHiding{

//we use 'new' keyword to achieve method hiding
//when the method is delcared with 'new' Keyword the method will automatically hide the method of parent class


public class Parent{

public String name="Parent Class";
public Parent(){


}

public void ParentMethod(){

    Console.WriteLine("This is the method of: "+name);
}



}

public class Child:Parent{
String name="Child Class";
public Child(){

}

public new void ParentMethod(){
    Console.WriteLine("The Parent Method is hide by "+name+" Method");

}

}

public class Test{

public static void Main(String[] args){

    Child c=new Child();

    c.ParentMethod();
}


}





}