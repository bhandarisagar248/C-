using System;

namespace ExceptionHandling{

public class Example{

public static void Main(String[] args){

int x=5;
int y=0;



try{

int result=x/y;

Console.WriteLine("The result is :"+result);  //this line will not run
}

catch(DivideByZeroException){
Console.WriteLine("Cannot Divide A number by zero");
Console.WriteLine("Exception Occcured");
}


finally{

    Console.WriteLine("This block will always executed.");
}









}




}





}