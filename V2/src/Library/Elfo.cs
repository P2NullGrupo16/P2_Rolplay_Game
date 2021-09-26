using System;
using System.Collections;
using System.Text;

namespace Program
{
    public class Elfo: IPersonaje
    {
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 150;
            this.Defensa = 60;
            this.Ataque = 70;
            this.Resistencia = 60;
            this.Magia = 60;
            this.Vida1 = 150;
        }
        public string GetPersonajeInfo()
        {
            return $"Este personaje es un Elfo llamado: {this.Nombre}\nVida: {this.Vida}\nAtaque: {this.Ataque}\nDefensa: {this.Defensa}\nMagia: {this.Magia}\nResistencia: {this.Resistencia}";
        }      
        private double vida ;
        private double armadura ;
        private Item mano1;
        private Item mano2;
        private Item casco;
        private Item chaleco;
        private Item botas;

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
                this.Ataque += value.Ataque;
                this.Defensa += value.Defensa;
                this.Magia += value.Magia;
            }
        }
        public Item Mano2 
        {
            get
            {
                return this.mano2;
            }
            set
            {
                this.mano2 = value;
                this.Ataque += value.Ataque;
                this.Defensa += value.Defensa;
                this.Magia += value.Magia;
            }
        }
        
        public double Defensa {get; set;}
        public double Ataque {get;set;}
        public string Nombre {get;set;}
        public double Resistencia {get; set;}
        public double Vida1 = 80;
        
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
        public double Magia {get;set;}
        
        public double AtaqueTotal() 
        {
            double ataqueTotal =  this.Ataque;
            return ataqueTotal;
        }
        public double DefensaTotal()
        {
            double defensaTotal = this.Defensa + this.Mano1.Defensa +  this.Armadura;
            return defensaTotal;            
        }

        // el elfo es el unico personaje que puede curar, para esto utiliza 3 metodos, uno por cada raza de personajes.
        public void CurarMago(Mago otro_pj)
        {   
            this.Resistencia -= 5;
            this.Magia -= 10;
            otro_pj.Vida = otro_pj.Vida1;
            Console.WriteLine($"Se restablecieron los puntos de vida de {otro_pj.Nombre}");
        }
        public void CurarEnano(Enano otro_pj)
        {   
            this.Resistencia -= 5;
            this.Magia -= 10;
            otro_pj.Vida = otro_pj.Vida1;
            Console.WriteLine($"Se restablecieron los puntos de vida de {otro_pj.Nombre}");
        }
        public void CurarElfo(Elfo otro_pj)
        {   
            this.Resistencia -= 5;
            this.Magia -= 10;
            otro_pj.Vida = otro_pj.Vida1;
            Console.WriteLine($"Se restablecieron los puntos de vida de {otro_pj.Nombre}");
        }
        
        public void Atacar(IPersonaje otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= this.AtaqueTotal();
            Console.WriteLine($"Se restaron {this.AtaqueTotal()} puntos a la vida de {otro_pj.Nombre}");
        }
        //borre metodos atacar
        
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
        public void AddMano2(Item baculo)
        {
            this.Mano1 = baculo;
        }
        public void RemoveMano2()
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
        public void ChangeMano2 (Item armaNuevo)
        {
            this.RemoveMano2();
            this.Mano1 = armaNuevo;
        }
    }
}