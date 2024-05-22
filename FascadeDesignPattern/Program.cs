namespace FascadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Fascade Design Pattern -------------");

            //The Client will use the Facade Interface instead of the Subsystems
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
