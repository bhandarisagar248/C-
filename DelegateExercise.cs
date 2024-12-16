using System;
namespace Delegate_Examples{

//delegate decleration decleration
public delegate double circle_delegate(int r);
public delegate double rectangle_delegate(int l,int b);

public delegate double triangle_delegate(int b,int h);

public class Example{

//function to calculate area of triangle circle and rectangle

public static double Circle(int r){

    return Math.PI*r*r;
}

public static double Rectangle(int l,int b){

    return l*b;
}

public static double Triangle(int b,int h){
    return 0.5 *b*h;
}



public static void Main(String[] args){

circle_delegate cd=new circle_delegate(Circle);
cd(5);
Console.WriteLine("The area of circle is:"+cd(5));


rectangle_delegate rd=new rectangle_delegate(Rectangle);
rd(5,4);
Console.WriteLine("The area of rectangle is:"+rd(5,4));


triangle_delegate td=new triangle_delegate(Triangle);
td(2,4);

Console.WriteLine("The area of triangle is:"+td(2,4));


}


}

}
