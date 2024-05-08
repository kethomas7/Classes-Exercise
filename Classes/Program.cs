namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car katesCar = new Car() { Make = "Lexus", Model = "ES350", Year = 2015 };

            Console.WriteLine($"Here are details about my car: {katesCar.Make}, {katesCar.Model}, {katesCar.Year}");
        }
    }
}
