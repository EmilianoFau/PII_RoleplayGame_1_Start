using System;

namespace Roleplay_PII_Grupal
{
    class Program
    {
        static void Main(string[] args)
        {
            Item palito = new Item("Palito", "Hola", 100, 50, 0);
            Magos mago1 = new Magos("Oswald", 100, palito);
            Console.WriteLine(mago1.Inventario);
        }
    }
}
