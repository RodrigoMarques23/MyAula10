using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public abstract class Agent
    {

        public string Name { get; }
        public Agent(string name)
        {
            Name = name;
        }

        public abstract char Move();
        

    }
}
