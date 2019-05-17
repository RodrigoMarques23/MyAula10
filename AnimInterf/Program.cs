using AnimInterf;
using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            const int n = 10;
            Animal[] animais = new Animal[n];
            Random rnd = new Random();

            //criar array 10 animais aleatorios
            for (int i = 0; i < n; i++)
            {
                switch (rnd.Next(2))
                {
                    case 0: animais[i] = new Bee(); break;
                    case 1: animais[i] = new Bat(); break;
                }
            }
            
            //percorrer array de animais
            foreach (Animal a in animais)
            {
                //chamar metodo sound 
                Console.Write(a.Sound()+ " ");
                //se for mamifero apresentar n de nipples
                if (a is IMammal)
                    Console.Write($"Este animal tem" + (a as IMammal) +"mamilos");

                //se puder voar apresentar n de asas
                if (a is ICanFly)
                    Console.Write($"Este animal tem" + (a as ICanFly) + "asas");

                Console.WriteLine();
            }
        }
    }
}
