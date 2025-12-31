using System;
namespace Core_Programming_OOPs.Object_Modelling
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*
            // Demonstration of Aggregation Relationship
            Library library1 = new Library("City Library");
            Library library2 = new Library("Central Library");

            Book book1 = new Book("C# Programming", "John Doe");
            Book book2 = new Book("Introduction to Algorithms", "Jane Smith");

            library1.AddBook(book1);
            library2.AddBook(book1); // same book in different library
            library2.AddBook(book2);

            // displaying books in library1
            library1.DisplayBooks();
            // displaying books in library2
            library2.DisplayBooks();
            */


            // Demonstration of Composition Relationship
            //Company company = new Company("Tech Solutions");
            //company.AddDepartment("HR");
            //company.AddDepartment("IT");
            //company.DisplayCompanyDetails();


            // Demonstration of Association Relationship
            //Bank bank = new Bank("Global Bank");
            //Customer customer = new Customer("Bob");
            //bank.OpenAccount(customer, 1000.0);
            //customer.ViewBalance();


            /*
            // Demonstration of Association and Aggregation Relationship
            School school = new School("Glory Modern");
            Student student1 = new Student("Rahul");
            Student student2 = new Student("Anay");
            school.AddStudent(student1);
            school.AddStudent(student2);

            Course course1 = new Course("Mathematics");
            Course course2 = new Course("Science");
            student1.AddCourse(course1);
            student1.AddCourse(course2);
            student2.AddCourse(course1);

            course1.ShowEnrolledStudents();
            course2.ShowEnrolledStudents();
            student1.ViewEnrolledCourses();
            school.ShowStudents();
            */

            /*
            // Demonstration of Composition and Aggregation Relationship
            University university = new University("Global University");
            university.AddDepartment("Computer Science");
            university.AddDepartment("Business Administration");
            
            Faculty fac1 = new Faculty("Dr. Smith");
            Faculty fac2 = new Faculty("Prof. Johnson");
            university.AddFaculty(fac1);
            university.AddFaculty(fac2);

            university.DisplayDetails();
            */

            /*
            // Demonstration of Association and Communication Relationship
            Hospital hospital = new Hospital("City Hospital");
            Doctor doctor = new Doctor("Rahul");
            Doctor doctor1 = new Doctor("Smith");
            Patient patient = new Patient("Anay");

            hospital.AddDoctor(doctor);
            hospital.AddPatient(patient);

            doctor.AddPatient(patient);
            doctor1.AddPatient(patient);
            doctor.Consult(patient);
            doctor.ShowPatients();
            patient.ShowDoctors();
            */


            /*
            Product p1 = new Product("Laptop", 1200.0);
            Product p2 = new Product("Smartphone", 800.0);
            Product p3 = new Product("Tablet", 5000.0);

            Customerr c = new Customerr("Alice");
            Order order = new Order(101);

            order.AddProduct(p1);
            order.AddProduct(p2);
            order.AddProduct(p3);

            c.PlaceOrder(order);

            Console.WriteLine($"Total Bill Amount: {order.CalculateTotal()}");
            */


        }
    }
}