using System;
using System.Collections.Generic;

namespace Roleplay_PII_Grupal
{
    public class Enanos : IPersonaje
    {
        public string Nombre { get; set;}
        public double VidaInicial { get; }
        public List<Item> Inventario = new List<Item>();
        public double Vida { get; set;}

        public Enanos(string nombre, double vida, Item inventario) {
            this.Nombre = nombre;
            this.Vida = vida;
            this.VidaInicial= this.Vida;
            AgregarItem(inventario);
        }

        public void AgregarItem(Item item) {
            this.Inventario.Add(item);
        }

        public void Atacar(IPersonaje perAtacado)
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

        public static void Curar(IPersonaje personaje){
            personaje.Vida = personaje.VidaInicial;
        }
    }
}