// List<Student> students = [
//     new Student{Id="s1",Name="Abel ",Departement="cs",GPA=2.67m,Age=21},
//     new Student{Id="s2",Name="selamawit ",Departement="software enginering",GPA=3.45m,Age=29},
//     new Student{Id="s3",Name="HENOK ",Departement="COMPUTER SCIENCE",GPA=3.05m,Age=45},
//     new Student{Id="s4",Name="Aster ",Departement="cs",GPA=3.85m,Age=27},
// ];


// var studentInfo = students.OrderByDescending(c => c.Age>=25);
// Console.WriteLine(studentInfo);

//         // Display result
//         foreach (var student in studentInfo)
//         {
//             Console.WriteLine(
//                 $"ID: {student.Id}, " +
//                 $"Name: {student.Name}, " +
//                 $"Department: {student.Departement}, " +
//                 $"GPA: {student.GPA}, " +
//                 $"Age: {student.Age}"
//             );
//         }
    
using System;
class Program
{
    static void Main(string[] args)
    {
        string Regin="Addis Ababa";
        Console.WriteLine(Regin.ToUpper());
    }
}