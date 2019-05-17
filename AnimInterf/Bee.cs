using System;
using AnimInterf;

namespace AnimInterf
{
    public class Bee : Animal, ICanFly
    {
        public int NumberofWings => 4;
        public override string Sound()
        {
            return base.Sound() + "bZZZZ!";
        }
    }
}
