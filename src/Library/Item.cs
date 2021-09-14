using System;

namespace Program
{
    public class Item
    {
        public Item(string nombre, int ataque, int defensa, int magia)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Magia = magia;
        }

        public string Nombre {get;set;}
        public int Ataque {get; set;}
        public int Defensa {get;set;}
        public int Magia {get; set;}
    }
}
