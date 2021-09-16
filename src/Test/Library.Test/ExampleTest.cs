using NUnit.Framework;
using System;

namespace Program
{


    public class ExampleTest
    {

        [Test]
        public void enanoSeLaDaAMagoYElfoHelea()
        {
            Mago pj32 = new Mago("Phanilorh");
            Item Mystic = new Item("Gorro Mistico", 5, 10,15 );
            Item Fenix = new Item("Baculo de Fenix", 20,10,30); 
            pj32.AddMano1(Fenix);
            pj32.AddCasco(Mystic);
            
            Enano pj33 = new Enano("Dvalin");
            Item cuernos = new Item("Cuernos Forjados", 10, 30,0 );
            Item Forja = new Item("Forja del Herrero", 30,50,0);
            Item Martillo = new Item("Martillo Mitologico", 20,15,0);
            pj33.AddMano1(Forja);
            pj33.AddMano2(Martillo);
            pj33.AddCasco(cuernos);

            Elfo pj34 = new Elfo("Galardiel");
            Item SombreroSanador = new Item("Sombrero Sanador", 10, 30,20);
            Item BáculoCurandero = new Item("La Mano de Dios", 30,10,40);
            Item BotasRápidas = new Item("Flash un Poroto", 0,30,10);
            pj33.AddMano1(BáculoCurandero);
            pj33.AddBotas(BotasRápidas);
            pj33.AddCasco(SombreroSanador);
            /* luego de crear los personajes y asignar los items 
            realizamos un testeo del código probando un atq y curando al personaje atacado*/

            pj33.AtacarMago(pj32);
            Assert.AreEqual(pj32.Vida, -50 ); 
            pj34.CurarMago(pj32);
            Assert.AreEqual(pj32.Vida, pj32.Vida ); // el elfo cura y vuelve a la vida inicial del pj
        }

    }


}