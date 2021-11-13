namespace Interfaces2
{
    public interface IDrivable
    {
        public int Wheels { get; set; }
        public int Speed { get; set; }

        public void Move();
        public void Stop();
    }
}
