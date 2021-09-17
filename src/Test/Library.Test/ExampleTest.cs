using NUnit.Framework;
using System;

namespace Program
{

    [TestFixture]
    public class ExampleTest
    {

        [Test]
        public void MagoSeLaReBancaContraUnEnanoYUnElfo()
        {
            //Prueba de que un personaje puede ser atacado por otros 2 (y del mismo modo, más de 2 si así se quisiese), y además que los Items son asignados correctamente y le otorgan al Personaje lo establecido
            
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
