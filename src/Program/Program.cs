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
            Item baston = new Item("Baston", 10,10,15);
            Item escudo = new Item("Escudo divino", 10,1000,10);
            pj1.AddMano1(baculo);
            Console.WriteLine(pj1.Mano1.GetItem());
            pj1.AddCasco(gorro);
            Console.WriteLine(pj1.LibroHechizosPoder());
            Console.WriteLine(pj1.Vida);
            pj1.EstudiarHechizo("Lluvia acida");
            Console.WriteLine(pj1.LibroHechizosPoder());
            Console.WriteLine(pj1.Ataque);
            Console.WriteLine(pj1.Mano1.Ataque);
            Console.WriteLine(pj1.AtaqueTotal() + " ataque total");
            Console.WriteLine(pj1.Ataque);
            Console.WriteLine(pj1.VerLibroHechizos());
            pj1.OlvidarHechizo("Lluvia acida");
            Console.WriteLine(pj1.VerLibroHechizos());
            Console.WriteLine(pj1.Magia + " magia con baculo");
            pj1.RemoveMano1();
            pj1.ChangeMano1(baston);
            Console.WriteLine(pj1.Magia + " magia sin baculo");


            Elfo pj2 = new Elfo("Juan");
            Item mascara = new Item("Mascara", 0, 20,0 );
            Item arco = new Item("Arco Maestro", 30,10,10);
            Item flecha = new Item("Flecha roja", 5,0,0);
            pj2.AddMano1(arco);
            pj2.AddMano2(flecha);
            Console.WriteLine(pj1.Mano1.GetItem());
            pj2.AddCasco(mascara);
            pj2.AtacarMago(pj1);
            Console.WriteLine($"{pj1.Vida} puntos de vida");
            pj2.CurarMago(pj1);
            Console.WriteLine(pj2.Ataque);
            Console.WriteLine(pj2.DefensaTotal() + " defensa total");
            Console.WriteLine(pj2.AtaqueTotal() + " ataque total");
          
            Item arco = new Item("Arco", 30,10,10);
            Item flecha = new Item("Flecha roja", 5,0,0);
            pj2.AddMano1(arco);
            pj2.AddMano2(flecha);
            //Console.WriteLine(pj1.Mano1.GetItem());
            pj2.AddCasco(mascara);
            Console.WriteLine(pj2.Ataque);
            Console.WriteLine(pj2.Armadura);
            Mago pj32 = new Mago("Phanilorh");
            Item Mystic = new Item("Gorro Mistico", 5, 10,15 );
            Item Fenix = new Item("Baculo de Fenix", 20,10,30);
            Item grimorio = new Item("Grimorio Alado", 10,0,30);
            pj32.AddMano1(Fenix);
            pj32.Addmano2(grimorio);
            pj32.AddCasco(Mystic);
            Enano pj33 = new Enano("Dvalin");
            Item cuernos = new Item("Cuernos Forjados", 10, 30,0 );
            Item Forja = new Item("Forja del Herrero", 30,50,0);
            Item Martillo = new Item("Martillo Mitologico", 20,15,0);
            pj33.AddMano1(Forja);
            pj33.Addmano2(Martillo);
            pj33.AddCasco(cuernos);
            

            Item EscudoGrande = new Item("Escudo grande", 0, 100, 0);
            Item EspadaMortal = new Item("Espada mortal", 45, 0, 0);
            Item BotasLentas = new Item("Botas lentas", 0, 10, 0);
            Enano PersonajeEnano1 = new Enano("Lebron James");

        }
    }
}
