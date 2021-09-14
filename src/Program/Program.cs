using System;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago pj1 = new Mago("Juan");
            Item gorro = new Item("Gorro magico", 0, 20,0 );
            Item baculo = new Item("Baculo", 10,10,10);
            pj1.AddMano1(baculo);
            pj1.AddCasco(gorro);
            Console.WriteLine(pj1.LibroHechizosPoder());
            Console.WriteLine(pj1.Vida);
            pj1.EstudiarHechizo("Lluvia acida");
            Console.WriteLine(pj1.LibroHechizosPoder());
            Console.WriteLine(pj1.AtaqueTotal);
        }
    }
}
