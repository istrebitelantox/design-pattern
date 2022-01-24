using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDuck;

namespace SolDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] kryak = new Duck[]
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };
            foreach (Duck krya in kryak)
            {
                Console.WriteLine(krya.Swim());
                Console.WriteLine(krya.Display());
                if(krya is IFlyBehavior)
                {
                    Console.WriteLine((krya as IFlyBehavior).fly());
                }
                if(krya is IQuackBehavior)
                {
                    Console.WriteLine((krya as IQuackBehavior).quack());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
