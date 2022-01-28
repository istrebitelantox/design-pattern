using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDuck
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public string Display()
        {
            return "Display\t" + this.GetType() + " \n" + this.flyBehavior.fly() + "\n " + this.quackBehavior.quack();
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public string Swim()
        {
            return "Буль буль буль\t" +" "+ this.GetType();

        }
        public string fly()
        {
            return flyBehavior.fly();
        }
        public string quack()
        {
            return quackBehavior.quack();
        }

    }
}
