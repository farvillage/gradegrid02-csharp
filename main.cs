using System;

double grade01 = 0;
double grade02 = 0;
double grade03 = 0;

System.Console.WriteLine("Enter your first grade: ");
grade01 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter your second grade: ");
grade02 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter your third grade: ");
grade03 = double.Parse(Console.ReadLine());

double averageGrade = grade01 + grade02 + grade03 / 2;

if (averageGrade >= 7)
{
    Console.WriteLine("You passed the exam!");
}
else if (averageGrade >= 6)
{
    Console.WriteLine("You have to do the replacement class.");
}
else
{
    Console.WriteLine("You failed the exam!");
}

System.Console.WriteLine("Your average grade is " + averageGrade);
