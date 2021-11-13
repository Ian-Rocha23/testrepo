namespace Interfaces2
{
    public class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public int Speed { get; set; }
        public int Wheels { get; set; }

        public Vehicle(string brand = "No Brand",
            int wheels = 0, int speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }


        public void Move()
        {
            Console.WriteLine($"The {Brand} moves forward at {Speed} MPH. ");
        }
        public void Stop()
        {
            Console.WriteLine($"The {Brand} stops. ");
        }
    }
}
