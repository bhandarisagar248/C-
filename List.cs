// using System;
// using System.Linq;
// using System.Collections.Generic;
// namespace ListOperation{



//     public class ListExample{
// public static void Main(String[] args){

//     List<String> student=new List<string>();

//     student.Add("Ramesh Shrestha");
//     student.Add("Sabin Shrestha");
//     student.Add("Samir Khadka");
//     student.Add("Dipesh Luitel");
//     student.Add("Abiral Khatiwada");

//     foreach(String std in student){
//         Console.WriteLine(std);
//     }


// //removing specific name
// student.Remove("Samir Khadka");
// student.Remove("Abiral Khatiwada");


// Console.WriteLine("\n");
// Console.WriteLine("Updated List:::::");
// foreach(String updated in student){
//         Console.WriteLine(updated);
//     }


//   // Sorting the list
//         var sortedList = student.OrderBy(name => name).ToList();

//         // Displaying the sorted list
//         Console.WriteLine("\nSorted List:");
//         foreach (string sorted in sortedList)
//         {
//             Console.WriteLine(sorted);
//         }


// Boolean result=student.Contains("Sagar Bhandari");


// if(result){
//     Console.WriteLine("Name exist");
// }

// else{
//     Console.WriteLine("Name Does not exist");
// }
// }

//     }
// }