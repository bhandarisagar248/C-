using System;
using System.Linq.Expressions;
namespace SealedClass{

// sealed class are use to restrict the user from inheriting the class
public sealed class Parent{

public String name="Sealed Class";
public void message(){
    Console.WriteLine("This is the Sealed Class");
}

}


// public class Child:Parent{

// }

public class Test{

public static void Main(String[] args){

    Console.WriteLine("Cannot Inherit the Sealed Class");
}


}
}







