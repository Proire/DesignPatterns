using AbstractFactoryDesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--------------------------- Abstract Factory Method -------------------------");
        // Client want Car and bike Details - but two types sports and regular 

        IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

        IBike regularBike = regularVehicleFactory.CreateBike();
        regularBike.GetDetails();
        
        ICar regularCar = regularVehicleFactory.CreateCar();
        regularCar.GetDetails();
        


        IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
       
        IBike sportsBike = sportsVehicleFactory.CreateBike();
        sportsBike.GetDetails();
        
        ICar sportsCar = sportsVehicleFactory.CreateCar();
        sportsCar.GetDetails();
    }
}