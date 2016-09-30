using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Fly
{
    public class FlyImpossible : IFlyBehavior
    {
        public string Fly()
        {
            return "I can't fly!";
        }
    }
}
