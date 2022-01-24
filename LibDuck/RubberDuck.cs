using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDuck
{
    public class RubberDuck : Duck, IQuackBehavior
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }

        public string quack()
        {
            return "quack" + this.GetType();
        }
    }
}
