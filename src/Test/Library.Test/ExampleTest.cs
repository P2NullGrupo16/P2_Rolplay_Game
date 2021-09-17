using NUnit.Framework;
using System;

namespace Test.Library
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
            pj2.AddChaleco(boyArmor);
            Console.WriteLine(pj2.GetPersonajeInfo());          //muestra la descripcion del personaje
            pj2.AtacarMago(pj1);            //este personaje ataca al otro personaje que es un mago
            Console.WriteLine($"{pj1.Nombre}: {pj1.Vida} puntos de vida");
            pj2.CurarMago(pj1);             //restablecemos los puntos de vida del personaje atacado
            Console.WriteLine($"{pj1.Nombre}: {pj1.Vida} puntos de vida");
            Console.WriteLine($"{pj2.Nombre}: " + pj2.DefensaTotal() + " defensa total");       //muestra valores totales de ataque y defensa.
            Console.WriteLine($"{pj2.Nombre}: " + pj2.AtaqueTotal() + " ataque total");
            
        }

    }


}