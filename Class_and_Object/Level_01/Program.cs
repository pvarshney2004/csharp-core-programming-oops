using System;
namespace Core_Programming_OOPs.Class_and_Object.Level_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            //Employee emp = new Employee("John Doe", 101, 54000);
            //emp.DisplayEmployeeDetails();

            // Create an instance of the Circle class
            //Circle circle = new Circle(5.0);
            //double area = circle.CalculateArea();
            //double circumference = circle.CalculateCircumference();
            //Console.WriteLine($"Circle with Radius: {circle.Radius} having Area: {area:F2} and Circumference: {circumference:F2}");

            // Create an instance of the Book class
            Book book = new Book("C# Programming", "Jon Skeet", 599);
            book.DisplayBookDetails();

        }
    }

}
