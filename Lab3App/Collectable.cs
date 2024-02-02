using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        public CollectionBoard Board;

        public virtual void Display() {
            Console.WriteLine("Collectable is displayed"); //for a generic Collectable case
        }

        public string Description { get; set; }

        public virtual void AddMe(List<Collectable> list)
        {

        }
    }
}
