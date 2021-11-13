namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bike = new Vehicle("Harley", 2, 85);
            
            if (bike is IDrivable)
            {
                Console.WriteLine($"The {bike.Brand} is going {bike.Speed} MPH. ");
                bike.Move();     
            }
            else
            {
                Console.WriteLine($"The old {bike.Brand} does not run. ");
            }
        }
    }
}



	




