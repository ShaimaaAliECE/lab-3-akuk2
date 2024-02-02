using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool : Collectable
    {

        public Tool(string description)
        {
            base.Description = description;
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);

            string name = base.Description;

            Console.WriteLine(name + " Collected, Congrats!!!!");
            DoAction();

        }
        public virtual void DoAction()
        {
            Console.WriteLine("Tool is used");
        }
    }
}
