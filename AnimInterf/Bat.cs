using AnimInterf;
using System;

namespace AnimInterf
{
    public class Bat : Animal, IMammal
    {
        public int NumberofNipples =>4;
        public override string ToString ()
        {
            return base.ToString() + "bat"    ;
        }
        public override string Sound()
        {
            return base.Sound() + "gri";
        }
    }
}
