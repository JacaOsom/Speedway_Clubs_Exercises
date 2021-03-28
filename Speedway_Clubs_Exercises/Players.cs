using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speedway_clubs
{
    class Players : Clubs
    {
        private string name;
        private string lastName;
        //public int points;


        public Players()
        {

        }

        public Players(Clubs player)
        {
            name = player.Names;
            league = player.League;
            startYear = player.StartYear;
        }

        public Players(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        //public int Points
        //{
        //    get { return points; }
        //    set { points = value; }
        //}

        public override void OutputInfo()
        {
            Console.WriteLine($"Player: {Name} {LastName}");

        }
        public virtual void PointsPlayers(int s)
        {
            Console.WriteLine($"{Name} {LastName} {s}");
        }
    }
}
