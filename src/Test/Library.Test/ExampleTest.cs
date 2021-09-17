using NUnit.Framework;
using System;

namespace Program
{

    [TestFixture]
    public class ExampleTest
    {

        [Test]
        public void TestMetodosAtacarDerivados()  
        {
            /*Prueba que se carguen los item, y que los metodos atacar y curar funcionen bien.*/
            Mago pj1 = new Mago("Juan");
            Item gorro = new Item("Gorro magico", 0, 20,0 );
            Item baculo = new Item("Baculo", 10,10,10);
            Item baston = new Item("Baston", 10,10,15);
            Item escudo = new Item("Escudo divino", 10,100,10);
            pj1.AddMano1(baculo);       // agrega arma en mano1
            pj1.AddCasco(gorro);        // agrega casco
            Console.WriteLine(pj1.GetPersonajeInfo());          // muestra datos del personaje
            pj1.EstudiarHechizo("Lluvia acida");        // aprende hechizos que aumentan su magia
            pj1.EstudiarHechizo("Tempestad");           // aprende hechizos que aumentan su magia
            Console.WriteLine(pj1.VerLibroHechizos());          //muestra los hechizos que aprendio y quedaron guardados en el libro
            Console.WriteLine(pj1.Magia + " puntos de magia\n");           // muestra el nuevo valor que tiene el personaje en la magia
             

            Elfo pj2 = new Elfo("Puma");
            Item bodyArmor = new Item("Cota de malla", 0, 20,0 );
            Item arco = new Item("Arco Maestro", 30,10,10);
            Item flecha = new Item("Flecha roja", 5,0,0);
            // equipamos al personaje con arco y flecha, y un chaleco. 
            pj2.AddMano1(arco);
            pj2.AddMano2(flecha);
            pj2.AddChaleco(bodyArmor);
            Console.WriteLine(pj2.GetPersonajeInfo());          //muestra la descripcion del personaje
            pj2.AtacarMago(pj1);            //este personaje ataca al otro personaje que es un mago
            Console.WriteLine($"{pj1.Nombre}: {pj1.Vida} puntos de vida");
            pj2.CurarMago(pj1);             //restablecemos los puntos de vida del personaje atacado
            Console.WriteLine($"{pj1.Nombre}: {pj1.Vida} puntos de vida");
            Console.WriteLine($"{pj2.Nombre}: " + pj2.DefensaTotal() + " defensa total");       //muestra valores totales de ataque y defensa.
            Console.WriteLine($"{pj2.Nombre}: " + pj2.AtaqueTotal() + " ataque total");
        }
  
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

    }


}