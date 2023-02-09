using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSpeed
{
    internal class car_speed
    {

        private float acceleration;
        private string engine_number;
        private bool start;
        private float time;
        private float velocity;

        public car_speed(float accleration = 0, string engine_number = " ", bool start = false)
        {
            this.acceleration = accleration;
            this.engine_number = engine_number;
            this.start = false; //what if false
        }

        public void set_acceleration(float acceleration ) 
        { 
            this.acceleration = acceleration;
        }

        public float get_acceleration() 
        { 
            acceleration = Single.Parse(Console.ReadLine());
            return this.acceleration;
        }

        public void set_engine_number(string engine_number)
        {
            this.engine_number = engine_number;
        }

        public string get_engine_number()
        {
            engine_number=Console.ReadLine();
            return this.engine_number;
        }

        public void Start()
        {
            this.start=true;
            Console.WriteLine("CAR STARTED SUCCESSFULLY...!");
        }

        public void stop() 
        { 
            this.start=false;
            Console.WriteLine("CAR STOPPED SUCCESSFULLY...!");
        }

        public void set_time(float time)
        {
            this.time = time;
        }

        public float get_time()
        {
            time=Single.Parse(Console.ReadLine());
            //Console.WriteLine("ENTER THE TIME : " + time + "SECOND(S)");
            return this.time;
        }

        public void set_velocity(float velocity=0)
        {
            this.velocity = velocity;
            if(this.start==true)
            {
                velocity = (acceleration * time);
                Console.WriteLine("VELOCITY OF THE CAR AFTER " + time + " SECOND(S) IS " + velocity);
            }
        }


        static void Main(string[] args)
        {
            car_speed cs = new car_speed();
            for(int i=1; i<=3; i++)
            {
                Console.WriteLine("DETAILS FOR THE CAR : " + i);
                Console.WriteLine("ENTER THE ENGINE NUMBER");
                cs.get_engine_number();
                Console.WriteLine("ENTER THE ACCELERATION");
                cs.get_acceleration();
                Console.WriteLine("ENTER TIME");
                cs.get_time();
                //Console.WriteLine("ENGINE NUMBER OF CAR SET TO CAR" + i);
                //Console.WriteLine("CAR'S ACCELERATION IS " + cs.get_acceleration());
                cs.Start();
                cs.set_velocity();
                //cs.stop();
            }
        }
    }
}
