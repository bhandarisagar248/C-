using System;
namespace MethodOverriding{

//the method with 'virtual' keyword is override with method with 'override' keyword


public class Base{

public Base(){

}

public virtual void BaseMethod(){

    Console.WriteLine("This is the Base Method.");
}

}


public class Derived:Base{

public Derived(){

}

public override void BaseMethod(){
    Console.WriteLine("The base method is override by derived Method::::::::");

}

}


public class Test{


    public static void Main(String[] args){

        Derived d=new Derived();
        d.BaseMethod();
}




}

}