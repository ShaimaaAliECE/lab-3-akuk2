using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int Value;
        public Coin(string description, int score, int value) : base(description, score, value)
        {
            base.Score = score;
            base.Description = description;
            this.Value = value;
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + base.Description + " is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(base.Description + " Collected, Congrats!!!!");

            UpdateTotalScore();

            //update total value
            Board.Value += Value;

            Console.WriteLine("Total Value is updated to: " + Board.Value);

        }
    }
}
