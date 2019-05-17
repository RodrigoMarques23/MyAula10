using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public class NPC : Agent
    {
        private readonly string s;
        private Random rnd; 
        public NPC (string name) : base(name)
        {
            s = "NWSE";
            rnd = new Random();
        }

        public override char Move()
        {
            int i = rnd.Next(4);
            return s[i];
        }

        public override string ToString() => base.ToString() + $"I'm an NPC and my name is{Name}";
    }
}
