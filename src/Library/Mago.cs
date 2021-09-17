using System;
using System.Collections;
using System.Text;

namespace Program
{
    public class Mago
    {
        public Mago(string nombre)
        {
            /* Se crea al personaje con los stats bases, que son identicos para todos los personajes creados de una misma raza*/
            this.Nombre = nombre;
            this.Vida = 120;
            this.Defensa = 40;
            this.Ataque = 10;
            this.Resistencia = 60;
            this.Magia = 100;
            this.Vida1 = 120;
            
        }
        public string GetPersonajeInfo()        /// muestra la información del personaje, nombre, vida, etc
        {
            return $"Este personaje es un Mago llamado: {this.Nombre}\nVida: {this.Vida}\nAtaque: {this.Ataque}\nDefensa: {this.Defensa}\nMagia: {this.Magia}\nResistencia: {this.Resistencia}";
        }
        public ArrayList LibroHechizos = new ArrayList();       // con ArrayList creamos un lugar donde poder almacenar los hechizos que el mago aprende
        public double LibroHechizosPoder()          //retorna el valor basico del libro de hechizos y adiciona 5 puntos de ataque y magia por cada hechizo que posea el libro.
        {
            double poderHechizo = 30;
            foreach (string hechizo in LibroHechizos)
            {
                poderHechizo += 5;
            }
            this.Magia += poderHechizo;
            return poderHechizo;
        }
        
        private double vida ;
        private double armadura ;
        private Item mano1;
        private Item casco;
        private Item chaleco;
        private Item botas;

        /* aca se le asigna un lugar especifico para cada item que es equipado el personaje 
        entonces se puede saber que tiene equipado el mismo llamando a la propiedad.
        A su vez esto permite que cada una de estas propiedades, pueda adicionarle los valores que corresponda segun su tipo
        los cascos, chalecos y botas solo suman a la defensa, las armas y escudos suman al ataque, defensa y magia, si poseen valores. */
        public Item Casco 
        {
            get
            {
                return this.casco;
            }
            set
            {
                this.casco = value;
                this.Armadura += value.Defensa;
            }
        }
        public Item Chaleco 
        {
            get
            {
                return this.chaleco;
            }
            set
            {
                this.chaleco = value;
                this.Armadura += value.Defensa;
            }
        }
        public Item Botas
        {
            get
            {
                return this.botas;
            }
            set
            {
                this.botas = value;
                this.Armadura += value.Defensa;
            }
        }
        public Item Mano1 
        {
            get
            {
                return this.mano1;
            }
            set
            {
                this.mano1 = value;
                this.Magia += value.Magia;
                this.Defensa += value.Defensa;
                this.Ataque += value.Ataque;
            }
        }
        //public Item Mano2 {get; set;}   El mago, no tiene habilitada esta mano, ya que tiene el libro de hechizos

        public double Defensa {get; set;}
        public double Ataque {get;set;}
        public string Nombre {get;set;}
        public double Resistencia {get; set;}
        public double Vida1 = 120;
        public double Magia {get;set;}
        
        public double Armadura
        {
            get
            {
                return this.armadura;
            }
            set
            {
                this.armadura = value;
            }
        }
        public double Vida 
        {
            get 
            {
                return this.vida;
            }
            set
            {
                this.vida = value;
            }
        }

        public double AtaqueTotal()         //ataque total calculado entre el ataque basico (+las armas que posea) + puntos por hechizos en el libro
        {
            double ataqueTotal = this.Ataque + this.LibroHechizosPoder();
            return ataqueTotal;
        }
        public double DefensaTotal()            // defensa total calculado entre el ataque basico (+ las armas) + puntos de armadura (puntos de defensa por cada equipo)
        {
            double defensaTotal = this.Defensa +  this.Armadura;            
            return defensaTotal;            
        }
        public void AtacarMago(Mago otro_pj)            // para los metodos de atacar necesitamos crear uno por cada raza de personaje.
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= this.AtaqueTotal();
            Console.WriteLine($"Se restaron {this.AtaqueTotal()} puntos a la vida de {otro_pj.Nombre}");
        }
        public void AtacarEnano(Enano otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= this.AtaqueTotal();
            Console.WriteLine($"Se restaron {this.AtaqueTotal()} puntos a la vida de {otro_pj.Nombre}");
        }
        public void AtacarElfo(Elfo otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= this.AtaqueTotal();
            Console.WriteLine($"Se restaron {this.AtaqueTotal()} puntos a la vida de {otro_pj.Nombre}");
        }
        // el mago puede: aprender hechizos, olvidar hechizos y ver el contenido del libro de hechizos.
        public void EstudiarHechizo(string hechizo)
        {
            this.LibroHechizos.Add(hechizo);
        }
        public void OlvidarHechizo(string hechizo)
        {
            this.LibroHechizos.Remove(hechizo);
        }
        public string VerLibroHechizos()
        {
            StringBuilder text = new StringBuilder("Los hechizos que contiene el libro son:\n");
            foreach (string hechizo in LibroHechizos)
            {
                text.Append($"- {hechizo}\n");
            }
            return text.ToString().TrimEnd();
        }

        /* Cada item posee 3 metodos compatibles, agregar, quitar o cambiar.*/
        public void AddCasco(Item casco)
        {
            this.Casco = casco;
        }
        public void RemoveCasco()
        {
            if (!(this.Casco.Nombre == ""))
            {
                this.Defensa -= this.Casco.Defensa;
                this.Casco = new Item("",0,0,0);
            }
            else
            {
                Console.WriteLine("No tiene objeto equipado en Casco");
            }
        }
        public void ChangeCasco (Item casco)
        {
            this.RemoveCasco();
            this.Casco = casco;
        }
        public void AddChaleco(Item chaleco)
        {
            this.Chaleco = chaleco;
        }
        public void RemoveChaleco()
        {
            if (!(this.Chaleco.Nombre == ""))
            {
                this.Defensa -= this.Chaleco.Defensa;
                this.Chaleco = new Item("",0,0,0);
            }
            else
            {
                Console.WriteLine("No tiene objeto equipado en Chaleco");
            }
        }
        public void ChangeChaleco (Item chaleco)
        {
            this.RemoveChaleco();
            this.Chaleco = chaleco;
        }
        public void AddBotas(Item botas)
        {
            this.Botas = botas;
        }
        public void RemoveBotas()
        {

            if (!(this.Botas.Nombre == ""))
            {
                this.Defensa -= this.Botas.Defensa;
                this.Botas = new Item("",0,0,0);
            }
            else
            {
                Console.WriteLine("No tiene objeto equipado en Botas");
            }
        }
        public void ChangeBotas (Item botas)
        {
            this.RemoveBotas();
            this.Botas = botas;
        }
        public void AddMano1(Item baculo)
        {
            this.Mano1 = baculo;
        }
        public void RemoveMano1()
        {
            if (!(this.Mano1.Nombre == ""))
            {
                this.Magia -= this.Mano1.Magia;
                this.Defensa -= this.Mano1.Defensa;
                this.Ataque -= this.Mano1.Ataque;
                this.Mano1 = new Item("",0,0,0);
            }
            else
            {
                Console.WriteLine("No tiene objeto equipado en Mano1");
            }
        }
        public void ChangeMano1 (Item armaNuevo)
        {
            this.RemoveMano1();
            this.Mano1 = armaNuevo;
        }
    }
}