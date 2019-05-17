using System;

namespace AnimInterf
{
    public class Animal
    {
        public virtual string Sound()
        {
            return "Sound will be ";
        }
        public override string ToString()
        {
            return base.ToString() + " Im a ";
        }

    }
}
