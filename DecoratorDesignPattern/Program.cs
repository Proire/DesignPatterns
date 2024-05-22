namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Decorator Design Pattern ---------------");

            //Create an instance of Concrete Component BMWCar
            ICar bmwCar1 = new BMWCar();
            //Calling the ManufactureCar method will create the BMWCar without an engine
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            //The Process for adding Petrol Engine to the existing Car
            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadKey();
        }
    }
}
