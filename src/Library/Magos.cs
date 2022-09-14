using System;
using System.Collections.Generic;

namespace Roleplay_PII_Grupal
{
    public class Magos
    {
        public string Nombre { get; set;}
        public double VidaInicial { get; }
        public List<Item> Inventario = new List<Item>();
        public double Vida { get; set;}

        public Magos(string nombre, double vida, Item inventario) {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Inventario.Add(inventario);
            this.VidaInicial= this.Vida;
        }

        public void Atacar(Magos perAtacado)
        {
            double Damage = 0;
            foreach (Item element in this.Inventario)
            {
                Damage += element.ValorAtaque;
            }
            if ((perAtacado.Vida - Damage) <= 0)
            {
                perAtacado.Vida = 0;
            }
            else
            {
                perAtacado.Vida -= Damage;
            }
        }

        public static void Curar(Magos personaje){
            personaje.Vida = personaje.VidaInicial;
        }
    }
}