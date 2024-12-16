using System;

namespace Interface{


//interface is the blueprint for the class it consists of the method which is implemented by the inherited class

public interface measurement{


    public double area();
    public double perimeter();

}

public class rectangle :measurement{
public int l;
public int b;
public rectangle(int l,int b){
this.l=l;
this.b=b;
}
public double area(){
 return l*b;
} 

public double perimeter(){
return 2*(l+b);

}

public static void Main(String[] args){

    rectangle rec=new rectangle(4,5);

    Console.WriteLine("The area of rectangle is:"+rec.area());
    Console.WriteLine("The perimeter of rectangle is:"+rec.perimeter());
}


}

}