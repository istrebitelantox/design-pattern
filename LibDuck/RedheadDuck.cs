using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDuck
{
    public class RedheadDuck : Duck, IFlyBehavior, IQuackBehavior
    {
        
        public override string Display()
        {
            flyBehavior = new FlyWithWings();
            return "Display" + this.GetType();

        }

        public string fly()
        {
            return "fly" + this.GetType();
        }

        public string quack()
        {
            return "quack" + this.GetType();
        }
    }
}
