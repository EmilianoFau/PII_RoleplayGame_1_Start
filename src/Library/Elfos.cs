using System;
using System.Collections;

namespace Roleplay_PII_Grupal
{
    public class Elfos
    {
        public string Nombre { get; set;}
        public double VidaInicial { get; }
        public ArrayList Inventario = new ArrayList();
        public double Vida { get; set;}

        public Elfos(string nombre, double vida, Item inventario) {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Inventario.Add(inventario);
            this.VidaInicial= this.Vida;
        }

        public static void Atacar(Item item, Magos personaje){
            personaje.Vida -= item.ValorAtaque;
        }

        public static void Curar(Magos personaje){
            personaje.Vida = personaje.VidaInicial;
        }
    }
}