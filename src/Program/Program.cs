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
            Item escudo = new Item("Escudo divino", 10,1000,10);
            pj1.AddMano1(baculo);
            //Console.WriteLine(pj1.Mano1.GetItem());
            pj1.AddCasco(gorro);
            //Console.WriteLine(pj1.LibroHechizosPoder());
            //Console.WriteLine(pj1.Vida);
            pj1.EstudiarHechizo("Lluvia acida");
            //Console.WriteLine(pj1.LibroHechizosPoder());
            //Console.WriteLine(pj1.Ataque);
            //Console.WriteLine(pj1.Mano1.Ataque);
            //Console.WriteLine(pj1.AtaqueTotal() + " ataque total");
            //Console.WriteLine(pj1.Ataque);
            //Console.WriteLine(pj1.VerLibroHechizos());
            pj1.OlvidarHechizo("Lluvia acida");
            Console.WriteLine(pj1.AtaqueTotal() + " ataque total");
            Console.WriteLine(pj1.DefensaTotal() + " defensa total");
            //Console.WriteLine(pj1.VerLibroHechizos());
            pj1.AddItem(gorro);
            pj1.AddItem(baculo);
            Console.WriteLine(pj1.Magia);
            Console.WriteLine(pj1.xAtaqueTotal + " Ataque total 2da forma");
            Console.WriteLine(pj1.xDefensaTotal + " Defensa total 2da forma");
            
            /*
            Elfo pj2 = new Elfo("Juan");
            Item mascara = new Item("Mascara", 0, 20,0 );
            Item arco = new Item("Arco", 30,10,10);
            Item flecha = new Item("Flecha roja", 5,0,0);
            pj2.AddMano1(arco);
            pj2.AddMano2(flecha);
            //Console.WriteLine(pj1.Mano1.GetItem());
            pj2.AddCasco(mascara);
            Console.WriteLine(pj2.Ataque);
            Console.WriteLine(pj2.Armadura);
            */

        }
    }
}
