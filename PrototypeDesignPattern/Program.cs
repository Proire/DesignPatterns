namespace PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Design Pattern!\n");

            // Creating an Instance of Employee Class
            Employee emp1 = new Employee(){
                Name = "Proire",
                Department = "IT"
            };


            // Creating another Instance of Employee with Existing Employee Instance using Assignment Operator
            // Both emp1 and emp2 share the same memory location as = Operator uses Call By Reference Mechanism

            Employee emp2 = emp1;
            // Changing the Name Property Value of emp2 instance, 
            // it will also change the Name Property Value of emp1 instance
            emp2.Name = "Faker";
            Console.WriteLine("Employee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Employee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            Console.Read();
        }
    }
}
