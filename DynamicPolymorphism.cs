using System;
namespace DynamicPolymorphism{

public abstract class Shape{

    public abstract double area();
}

public class Rectangle:Shape{

public int l;
public int b;

public Rectangle(int l,int b){
    this.l=l;
    this.b=b;
}
public override double area(){
    return l*b;
} 

}

public class Test{

    public static void Main(string[] args){

        Rectangle r=new Rectangle(5,4);

        Console.WriteLine("The area of rectangle is:"+r.area());
    }
}






}