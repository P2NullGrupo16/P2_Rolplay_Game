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

    }


}