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
            Console.WriteLine(pj1.DefensaTotal() + " ataque total");
            //Console.WriteLine(pj1.Ataque);
            //Console.WriteLine(pj1.VerLibroHechizos());
            pj1.OlvidarHechizo("Lluvia acida");
            //Console.WriteLine(pj1.VerLibroHechizos());
            Console.WriteLine(pj1.Magia);
            

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

            Mago Protagonista = new Mago("Mago Arkadian");
            Item GorraVD= new Item("Gorra Vieja y Desgastada", 0, 10, 0);
            Item TunicaAA = new Item("Túnica Azul de Aprendiz", 0, 10, 0);
            Item TalismanSB = new Item("Talismán de Summoner Básico", 0, 0, 20);
            Protagonista.AddMano1(TalismanSB);
            Protagonista.AddCasco(GorraVD);
            Protagonista.AddChaleco(TunicaAA);
            Protagonista.EstudiarHechizo("Luz Sagrada");
            Protagonista.EstudiarHechizo("Presion de Viento");
            //Console.WriteLine(Protagonista.Ataque);
            //Console.WriteLine(Protagonista.VerLibroHechizos());

            Enano Zafrin = new Enano("Herrero Zafrin");
            Item MartilloH = new Item("Martillo de Herrero Enano", 10, 0, 0);
            Item ArmaduraMZ= new Item("Armadura Majestuosa de Zafrin", 20, 100, 0);
            Item CascoGZ = new Item("Casco de Guerra de Zafrin", 5, 40, 5);
            Item MartilloMDZ = new Item("Martillo Matadioses de Zafrin", 60, 0, 0);
            Zafrin.AddMano1(MartilloMDZ);          
            Zafrin.AddChaleco(ArmaduraMZ);             
            Zafrin.AddCasco(CascoGZ);

            
            /* Enano vs Mago
            Zafrin.AtacarMago(Protagonista);
            Protagonista.AtacarEnano(Zafrin);
            Console.WriteLine(Protagonista.Vida);
            Console.WriteLine(Zafrin.Vida);
            */
        }
    }
}
