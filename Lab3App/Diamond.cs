using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string description, int score) : base(description, score, 0)
        {
            base.Description = description;
            base.Score = score;
        }

        public override void Display()
        {
            Console.WriteLine("Diamond " + base.Description + " is displayed");
        }

    }
}
