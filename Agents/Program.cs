using System;

namespace Agents
{
    public class Program
    {
        static void Main(string[] args)
        {
            Agent[] agents = new Agent[]
            {
                new NPC("n1"),
                new NPC("n2"),
                new Player("p1")
            };
            foreach (Agent a in agents)
            {
                Console.WriteLine("has mote to" + a.Move());
            }
        }
    }
}
