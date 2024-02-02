using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class CollectionBoard
    {
        private int TotalScore;
        private int TotalValue;

        public int Score
        {
            get
            {
                return TotalScore;
            }
            set { TotalScore = value; }
        }
        public int Value
        {
            get 
            {
                return TotalValue;
            }
            set { TotalValue = value; }
        }
    }
}
