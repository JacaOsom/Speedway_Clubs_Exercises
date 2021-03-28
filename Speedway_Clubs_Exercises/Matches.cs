using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speedway_clubs
{
    class Matches : Clubs
    {
        protected string firstClub;
        protected string secondClub;
        public string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public string FirstClub
        {
            get { return firstClub; }
            set { firstClub = value; }
        }

        public string SecondClub
        {
            get { return secondClub; }
            set { secondClub = value; }
        }

        public Matches()
        {

        }
        public Matches(Clubs matches)
        {
            names = matches.Names;
        }

        public Matches(string firstClub, string secondClub)
        {
            this.firstClub = firstClub;
            this.secondClub = secondClub;
        }

        public virtual void ResultOfTheMatch(int a, int b)
        {
            Console.WriteLine(firstClub + $" {a}:{b} " + secondClub);
        }


    }
}
