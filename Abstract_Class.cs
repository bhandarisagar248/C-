using System;
namespace AbstractClass{


//abstract class is class with at least one abstract method which is used to inherit the base class
public abstract class Area{


//abstract method
    abstract public double area(); 
}

public class circle:Area{
public int radius ;
 public circle(int r){
    radius=r;
 }

 public override double area(){
 return Math.PI*radius*radius;
 }

 public static void Main(String[] args){

circle c=new circle(5);
Console.WriteLine("The Area of circle is:"+c.area());

 }

        
        }


    }
