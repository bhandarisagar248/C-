using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;

namespace LINQ_Example{


//defining a student class
public class Student{
    public String name {get; set;}

    public int marks {get; set;}

    public String department {get; set;}

}

public class LINQ_Exercise{

public static void Main(String[] args){

//creating list of Student type
List<Student> std=new List<Student>{


new Student{name="Ramesh", marks=75,department="Bsc.CSIT"},
new Student{name="Samir",marks=80,department="Bsc.CSIT"},
new Student{name="Pujan", marks=68 ,department="BIM"},
new Student{name="Sita", marks=66 ,department="BIM"},
new Student{name="Mohan", marks=81 ,department="BBA"},
new Student{name="Jiya", marks=90 ,department="BBA"},
};

//filter student marks greater than 70
var filterStudent=std.Where(s=>s.marks>70);

//sort student by name in ascending order

var SortedStudent=filterStudent.OrderBy(s=>s.name);


//group student by department
var GroupedStudent=SortedStudent.GroupBy(s=>s.department);


//displaying filterstudent sortedstudent groupedstudent

// foreach(var group in GroupedStudent){

//     Console.WriteLine("Grouped Student Detailed:"+group);

// }

 foreach (var group in GroupedStudent)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  Name: {student.name}, Marks: {student.marks}");
                }
            }

}


}






}