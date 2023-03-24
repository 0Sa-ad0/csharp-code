/*Write a C# program for the following scenario:
A sport club is willing to have their player information in a console-based system, for which they asked to build a simple console-based application which will have some basic player information. The club has 2 types of Players: Cricketer & Footballer. All the Players will have id, name, salary and joining date. Cricketer players will have totalRun and totalWicket, and Footballer will have totalGoal and totalAssist. ShowInfo() method will provide all the information for each type of Player. 
The Main method is already given for you, try to write other classes to make it happen, write appropriate fields, methods, properties etc. Use proper access modifiers, types etc. [Optional: For joining date if you can create custom type then it will be considered as bonus part.]  

using System;

namespace ConsoleAppEmployeeInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Cricketer cr = new Cricketer("P-01", "Shakib", 70000, "06-08-2006", 6755, 285 );
            Footballer ft = new Footballer("P-02", "Jamal", 50000, "13-06-2013", 20, 15);
            cr.ShowInfo();
            ft.ShowInfo();
        }
    }
}*/





//SOLUTION

using System;

namespace ConsoleAppPlayerInformation
{
    class Player
    {
        private string id;
        private string name;
        private double salary;
        private DateTime joiningDate;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateTime JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }

        public Player(string id, string name, double salary, string joiningDate)
        {
            Id = id;
            Name = name;
            Salary = salary;
            JoiningDate = DateTime.Parse(joiningDate);
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Joining Date: " + JoiningDate.ToShortDateString());
            Console.WriteLine();
        }
    }

    class Cricketer : Player
    {
        private int totalRun;
        private int totalWicket;

        public int TotalRun
        {
            get { return totalRun; }
            set { totalRun = value; }
        }

        public int TotalWicket
        {
            get { return totalWicket; }
            set { totalWicket = value; }
        }

        public Cricketer(string id, string name, double salary, string joiningDate, int totalRun, int totalWicket) : base(id, name, salary, joiningDate)
        {
            TotalRun = totalRun;
            TotalWicket = totalWicket;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Runs: " + TotalRun);
            Console.WriteLine("Total Wickets: " + TotalWicket);
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }
    }

    class Footballer : Player
    {
        private int totalGoal;
        private int totalAssist;

        public int TotalGoal
        {
            get { return totalGoal; }
            set { totalGoal = value; }
        }

        public int TotalAssist
        {
            get { return totalAssist; }
            set { totalAssist = value; }
        }

        public Footballer(string id, string name, double salary, string joiningDate, int totalGoal, int totalAssist) : base(id, name, salary, joiningDate)
        {
            TotalGoal = totalGoal;
            TotalAssist = totalAssist;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Goals: " + TotalGoal);
            Console.WriteLine("Total Assists: " + TotalAssist);
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cricketer cr = new Cricketer("P-01", "Shakib", 70000, "2006, 8, 6", 6755, 285);
            Footballer ft = new Footballer("P-02", "Jamal", 50000, "2013, 6, 13", 20, 15);
            cr.ShowInfo();
            ft.ShowInfo();
        }
    }
}

