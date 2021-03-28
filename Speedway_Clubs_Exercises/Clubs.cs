using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speedway_clubs
{
    class Clubs
    {
        protected string names;
        protected string league;
        protected string startYear;

        public string Names
        {
            get { return names; }
            set { names = value; }
        }
        public string League
        {
            get { return league; }
            set { league = value; }
        }
        public string StartYear
        {
            get { return startYear; }
            set { startYear = value; }
        }

        public Clubs()
        {

        }

        public Clubs(string names, string league, string startYear)
        {
            this.names = names;
            this.league = league;
            this.startYear = startYear;
        }

        public virtual void OutputInfo()
        {
            Console.WriteLine($"Club: {Names}");
            Console.WriteLine($"League: {League}");
            Console.WriteLine($"The begining of the club: {StartYear}");
        }
    }
}
