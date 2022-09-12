using System;
namespace Roleplay_PII_Grupal
{
    public class Item
    {
        public string Nombre { get;set; }
        public string Tipo { get;set; }
        public double Vida { get;set; }
        public double ValorAtaque { get;set; }
        public double ValorDefensa { get;set; }

        public Item(string nombre, string tipo, double vida, double valorAtaque, double valorDefensa)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Vida = vida;
            this.ValorAtaque = valorAtaque;
            this.ValorDefensa = valorDefensa;
        }
    }
}