using System;

namespace CarSpeed
{
    internal class Car
    {
        private float acceleration;
        private string engineNumber;
        private bool start;
        private float time;
        private float velocity;

        public Car(float acceleration = 0, string engineNumber = " ", bool start = false)
        {
            Acceleration = acceleration;
            EngineNumber = engineNumber;
            Start = false;
        }

        public float Acceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }

        public string EngineNumber
        {
            get { return engineNumber; }
            set { engineNumber = value; }
        }

        public bool Start
        {
            get { return start; }
            set { start = value; }
        }

        public float Time
        {
            get { return time; }
            set { time = value; }
        }

        public float Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public void StartCar()
        {
            Start = true;
            Console.WriteLine("CAR STARTED SUCCESSFULLY...!");
        }

        public void StopCar()
        {
            Start = false;
            Console.WriteLine("CAR STOPPED SUCCESSFULLY...!");
        }

        public void CalculateVelocity()
        {
            if (Start)
            {
                Velocity = (Acceleration * Time);
                Console.WriteLine("VELOCITY OF THE CAR AFTER " + Time + " SECOND(S) IS " + Velocity);
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("DETAILS FOR THE CAR : " + i);
                Console.WriteLine("ENTER THE ENGINE NUMBER");
                car.EngineNumber = Console.ReadLine();
                Console.WriteLine("ENTER THE ACCELERATION");
                car.Acceleration = float.Parse(Console.ReadLine());
                Console.WriteLine("ENTER TIME");
                car.Time = float.Parse(Console.ReadLine());
                car.StartCar();
                car.CalculateVelocity();
            }
        }
    }
}
