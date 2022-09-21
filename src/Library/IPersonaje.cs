using System.Collections.Generic;
namespace Roleplay_PII_Grupal
{
    public interface IPersonaje
    {
        string Nombre { get; set;}
        double VidaInicial { get; }
        double Vida { get; set;}
    }
}