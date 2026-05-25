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
        string studentname="abeba";
        string studentId="stu_001";
        int enrolmentCout = 3;
        decimal grantAmount=199.99m;
        DateTime Enrolleddt =DateTime.UtcNow;

        // excute the above variables
        Console.WriteLine($"My Name is : ${studentname}");
        Console.WriteLine($"My id Number : ${studentId}");
        Console.WriteLine($"No of enrolment : ${enrolmentCout}");
        Console.WriteLine($"grantAmount : ${grantAmount}");
        Console.WriteLine($"EnrolmentDate was : ${Enrolleddt}");
    }
}