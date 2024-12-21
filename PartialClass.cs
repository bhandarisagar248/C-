using System;
using System.Security.Cryptography;
namespace PartialClass{

public partial class Area{

public int l;
public int b;
public Area(int l,int b){
    this.l=l;
    this.b=b;
}

}

public partial class Area{

public double area(){
    return l*b;
}

public double Perimeter(){
    return 2*(l+b);
}

}

public class Test{

    public static void Main(String[] args){

        Area area=new Area(5,6);
        Console.WriteLine("The area is :"+area.area());
        Console.WriteLine("The perimeter is :"+area.Perimeter());
    }
}







}