using System;

namespace Program
{
    public class Item
    {
        public Item(string nombre, double ataque, double defensa, double magia)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Magia = magia;
        }

        public string Nombre {get;set;}
        public double Ataque {get; set;}
        public double Defensa {get;set;}
        public double Magia {get; set;}
        public string GetItem()
        {
            string texto = $"Esto es un {this.Nombre}, tiene un ataque de {this.Ataque} y de defensa {this.Defensa}, cuenta con {this.Magia} puntos de magia.";
            return texto;
        }
    }
}
