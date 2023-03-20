using System;

class Player
    {
        private string id;
        private string name;
        private int salary;
        private DateTime joiningDate;

        public Player(string id, string name, int salary, DateTime joiningDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joiningDate = joiningDate;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Player ID: "+ id);
            Console.WriteLine("Player Name: "+ name);
            Console.WriteLine("Player Salary: "+ salary);
            Console.WriteLine("Player Joining Date: "+ joiningDate.ToShortDateString());
        }
    }

    class Cricketer : Player
    {
        private int totalRun;
        private int totalWicket;

        public Cricketer(string id, string name, int salary, DateTime joiningDate, int totalRun, int totalWicket)
            : base(id, name, salary, joiningDate)
        {
            this.totalRun = totalRun;
            this.totalWicket = totalWicket;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Runs: "+totalRun);
            Console.WriteLine("Total Wickets: "+ totalWicket);
        }
    }

    class Footballer : Player
    {
        private int totalGoal;
        private int totalAssist;

        public Footballer(string id, string name, int salary, DateTime joiningDate, int totalGoal, int totalAssist)
            : base(id, name, salary, joiningDate)
        {
            this.totalGoal = totalGoal;
            this.totalAssist = totalAssist;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Goals: "+ totalGoal);
            Console.WriteLine("Total Assists: "+totalAssist);
        }
    }
class Program
{
    static void Main(string[] args)
    {
        Cricketer cr = new Cricketer("P-01", "Shakib", 70000, new DateTime(2006, 8, 6), 6755, 285);
        Footballer ft = new Footballer("P-02", "Jamal", 50000, new DateTime(2013, 6, 13), 20, 15);
        cr.ShowInfo();
        ft.ShowInfo();
    }
}
