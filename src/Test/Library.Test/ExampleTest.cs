using NUnit.Framework;
using System;

namespace Program
{


    public class ExampleTest
    {

        [Test]
        public void MagoSeLaReBancaContraUnEnanoYUnElfo()
        {
            //Prueba de que un personaje puede ser atacado por otros 2 (y del mismo modo, más de 2 si asi se quisiese), y además que los Items son asignados correctamente y le otorgan al Personaje lo establecido
            
            //Creo a un personaje Enano 
            Enano MuyEnano = new Enano("Después de esta no la cuento"); //Se crea un personaje Enano

            //Se crean varios Items
            Item LanzaF = new Item("Lanza Frágil", 10, 0, 0);
            Item BotasC = new Item("Botas de Cuero", 0, 5, 0);
            Item CascoM = new Item("Balde de Madera", 0, 5, 0);
            Item CorazaC = new Item("Coraza de Escamas de Cocodrilo", 0, 10, 0);

            //Equipo al Enano con los Items ya creados
            MuyEnano.AddBotas(BotasC);
            MuyEnano.AddCasco(CascoM);
            MuyEnano.AddChaleco(CorazaC);
            MuyEnano.AddMano1(LanzaF);


            //Creo a un personaje ELfo
            Elfo ElfoElemental = new Elfo("Elfo Aprendíz del Elemento Hielo");

            //Se crean varios Items
            Item BastónElemental = new Item("Bastón Escarchado", 25, 0, 0);
            Item BotasT = new Item("Botas de Tela", 0, 2, 0);
            Item ChalecoC = new Item("Chaleco de Cuero",0, 9, 0);
            Item CascoL = new Item("Casco Ligero", 0, 10, 0);

            //Equipo al Elfo con los Items que acabo de crear
            ElfoElemental.AddBotas(BotasT);
            ElfoElemental.AddMano1(BastónElemental);
            ElfoElemental.AddChaleco(ChalecoC);
            ElfoElemental.AddCasco(CascoL);


            //Creo al mago invencible
            Mago MagoRePolenta = new Mago("Fane the Shapeshifter");

            //Le doy Items para que mate a todo lo que se mueva
            Item VaritaOP = new Item("Death's Last Stand", 155, 10, 10);
            Item BotasOP = new Item("Boots of the Tyrant", 0, 90, 0);
            Item ChalecoOP = new Item("Ratch Muvora", 0, 135, 0);
            Item CascoOP = new Item("Silent Wizard Hat", 0, 95, 0);

            //Le doy los Items 
            MagoRePolenta.AddMano1(VaritaOP);
            MagoRePolenta.AddCasco(CascoOP);
            MagoRePolenta.AddBotas(BotasOP);
            MagoRePolenta.AddChaleco(ChalecoOP);

            Console.WriteLine($"{MuyEnano.Nombre}: " + MuyEnano.DefensaTotal() + " puntos de defensa total y " + MuyEnano.AtaqueTotal() + " puntos de ataque total");
            Console.WriteLine($"{ElfoElemental.Nombre}: " + ElfoElemental.DefensaTotal() + " puntos de defensa total y " + ElfoElemental.AtaqueTotal() + " puntos de ataque total");
            Console.WriteLine($"{MagoRePolenta.Nombre}: " + MagoRePolenta.DefensaTotal() + " puntos de defensa total y " + MagoRePolenta.AtaqueTotal() + " puntos de ataque total");

            
            //Se realizan 2 Test para ver si efectivamente el valor esperado es igual al obtenido, primero tras el ataque del primer personaje y luego tras el ataque del segundo
            MuyEnano.AtacarMago(MagoRePolenta);
            double expected = 30.0d;
            Assert.AreEqual(expected, MagoRePolenta.Vida);
            
            ElfoElemental.AtacarMago(MagoRePolenta);
            Assert.AreEqual(MagoRePolenta.Vida, -65.0d);

            //Se realizan Test para comprobar Stats de ataque luego de agregados los Items
            //MuyEnano.AtaqueTotal();
            Assert.AreEqual(MuyEnano.AtaqueTotal(), 90.0d);

            //ElfoElemental.AtaqueTotal();
            Assert.AreEqual(ElfoElemental.AtaqueTotal(), 95.0d);

            //MagoRePolenta.AtaqueTotal();
            Assert.AreEqual(MagoRePolenta.AtaqueTotal(), 195.0d);





        }

    }


}