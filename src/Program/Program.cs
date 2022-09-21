using System;

namespace Roleplay_PII_Grupal
{
    class Program
    {
        static void Main(string[] args)
        {
            Item palito = new Item("Palito", "Hola", 100, 50, 0);
            Magos mago1 = new Magos("Oswald", 100, palito);
            Magos mago2 = new Magos("Emi", 100, palito);
            Enanos enano1 = new Enanos("si", 100, palito);
            mago1.Atacar(enano1);
            
            Console.WriteLine(enano1.Vida);
        }
    }
}
