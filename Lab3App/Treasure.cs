using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score {  get; set; }

        public Treasure(string description, int score, int value)
        {
            base.Description = description;

        }

        public void UpdateTotalScore()
        {

            //update the score
            Board.Score += Score;

            Console.WriteLine("Total Score is updated to: " + Board.Score);
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);


            Console.WriteLine(base.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();

        }


    }
}
