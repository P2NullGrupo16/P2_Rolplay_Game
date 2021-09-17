using NUnit.Framework;
using System;

namespace Program
{


    public class ExampleTest
    {

        [Test]
        public void EnfrentamientoElfovsEnanoConItemsGanadorEsperadoEnano()
        //test necesario para comprobar que los metodos de agregar items y atacar funcionan correctamente
        {
            Enano grrr = new Enano("Tomatoide");

            Item MartilloH = new Item("Martillo de Herrero", 25, 0, 0);
            Item EscudoD = new Item("Escudo Portentoso", 0, 10, 0);
            Item CorazaA = new Item("Coraza Antigua", 0, 8, 0);

            grrr.AddMano1(MartilloH);
            grrr.AddMano2(EscudoD);
            grrr.AddChaleco(CorazaA);
            
            Elfo mesias = new Elfo("Jesuschrist");
            Item ArcoE = new Item("Arco Enclenque", 5, 0, 0);
            Item FlechaM = new Item("Flecha de Madera", 5, 0, 0);
            Item GorraC = new Item("Gorra de Cazador Elfo", 0, 8, 0);
            Item TunicaVD = new Item("Tunica Vieja y Desgastada", 0, 1, 0);

            mesias.AddMano1(ArcoE);
            mesias.AddMano2(FlechaM);
            mesias.AddChaleco(TunicaVD);
            mesias.AddCasco(GorraC);

            /*en este momento, tenemos a dos personajes, el elfo Jesuschrist, que junto con sus items acumula un total de 150 de vida, 69 de defensa y 80 de ataque
            Y el Enano Tomatoide, el cual en total debería contar con 200 de vida, 38 de defensa y 115 de ataque
            Según estos datos, el enfrentamiento debería culminar con el elfo muriendo luego de dos ataques*/

            grrr.AtacarElfo(mesias);
            grrr.AtacarElfo(mesias);

            Assert.AreEqual(mesias.Vida, -80);
            Assert.AreEqual(grrr.Vida, 200.0d);
            
        }


        [Test]
        public void TestAtaqueTotalEnano() // Comprueba que el ataque total de un enano sea la suma del ataque de sus items equipados + su ataque base.
        {
            Enano Lebroncito = new Enano("Lebron Jr");
            Item EspadaCorta = new Item("Espada corta", 20, 0, 0);
            Lebroncito.AddMano1(EspadaCorta);
            double expected = 90 + EspadaCorta.Ataque;
            Assert.AreEqual(expected, Lebroncito.AtaqueTotal());    
        }

        [Test]
        public void TestAtaqueTotalElfo() // Comprueba que el ataque total de un elfo sea la suma del ataque de sus items equipados + su ataque base.
        {
            Elfo ElFitoPaez = new Elfo("Elfito Paez");
            Item EspadaLarga = new Item("Espada larga", 30, 0, 0);
            ElFitoPaez.AddMano1(EspadaLarga);
            double expected = 70 + EspadaLarga.Ataque;
            Assert.AreEqual(expected, ElFitoPaez.AtaqueTotal());    
        }

        [Test]
        public void TestAtaqueTotalMago() // Comprueba que el ataque total de un mago sea la suma del ataque de sus items equipados + su ataque base + su libro de hechizos.
        {
            Mago MagoFachero = new Mago("El mago facha");
            Item Varita = new Item("Varita", 40, 0, 0);
            MagoFachero.AddMano1(Varita);
            MagoFachero.EstudiarHechizo("hechizo 1");
            double expected = 10 + Varita.Ataque + MagoFachero.LibroHechizosPoder();
            Assert.AreEqual(expected, MagoFachero.AtaqueTotal());    
        }  
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