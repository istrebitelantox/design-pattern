﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDuck
{
    public class DQuack : IQuackBehavior
    {
        public string quack()
        {
            return "Кря кря кря\t" + this.GetType();
        }
    }
}
