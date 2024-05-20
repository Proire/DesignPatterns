namespace PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Design Pattern!\n");

            // Creating an Instance of Employee Class
            Employee emp1 = new Employee { 
                Name = "Anurag",
                Department = "IT"
            };
            // Instead of using Assignment Operator, now use the Clone method to create a Cloned Object
            // Both emp1 and emp2 having different Memory Address
            Employee emp2 = emp1.GetClone();
            // Changing the Name Property Value of emp2 instance, 
            // will not change the Name Property Value of emp1 instance
            emp2.Name = "Pranaya";
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);

            Console.WriteLine("\nClick any key to exit ..");
            Console.Read();
        }
    }
}
