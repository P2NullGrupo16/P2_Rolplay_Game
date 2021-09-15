using System;
using System.Collections;
using System.Text;

namespace Program
{
    public class Mago
    {
        public Mago(string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 120;
            this.Defensa = 40;
            this.Ataque = 10;
            this.Resistencia = 60;
            this.Magia = 100;
            this.Vida1 = 120;
            this.xAtaqueTotal = this.Ataque + this.LibroHechizosPoder(); //ag
            this.xDefensaTotal = this.Defensa; //ag
            
            
        }
        public ArrayList LibroHechizos = new ArrayList();
        public double LibroHechizosPoder()
        {
            double poderHechizo = 30;
            foreach (string hechizo in LibroHechizos)
            {
                poderHechizo += 5;
            }
            return poderHechizo;
        }
        
        private double vida ;
        private double armadura ;
        private Item mano1;
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
                this.Magia += value.Magia;
                this.Defensa += value.Defensa;
                this.Magia += value.Magia;
            }
        }
        //public Item Mano2 {get; set;}
        
        public double Defensa {get; set;}
        public double Ataque {get;set;}
        public string Nombre {get;set;}
        public double Resistencia {get; set;}
        public double Vida1 = 120;
        
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
            double ataqueTotal = this.Ataque + this.Mano1.Ataque + this.LibroHechizosPoder();
            return ataqueTotal;
        }
        public double DefensaTotal()
        {
            double defensaTotal = this.Defensa + this.Mano1.Defensa +  this.Armadura; //Da 80 cuando se tiene 40 base +30 agregegados
            return defensaTotal;            
        }
        public void AtacarMago(Mago otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= this.AtaqueTotal();
            
        }
        public void AtacarEnano(Enano otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= this.AtaqueTotal();
            
        }
        public void AtacarElfo(Elfo otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= this.AtaqueTotal();
            
        }
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
        public void AddCasco(Item casco)
        {
            this.Casco = casco;
        }
        public void RemoveCasco()
        {
            this.Casco = new Item("",0,0,0);
        }
        public void ChangeCasco (Item casco)
        {
            this.Casco = casco;
        }
        public void AddChaleco(Item chaleco)
        {
            this.Chaleco = chaleco;
        }
        public void RemoveChaleco()
        {
            this.Chaleco = new Item("",0,0,0);
        }
        public void ChangeChaleco (Item chaleco)
        {
            this.Chaleco = chaleco;
        }
        public void AddBotas(Item botas)
        {
            this.Botas = botas;
        }
        public void RemoveBotas()
        {
            this.Botas = new Item("",0,0,0);
        }
        public void ChangeBotas (Item botas)
        {
            this.Botas = botas;
        }
        public void AddMano1(Item baculo)
        {
            this.Mano1 = baculo;
        }
        public void RemoveMano1()
        {
            this.Mano1 = new Item("",0,0,0);
        }
        public void ChangeMano1 (Item baculo)
        {
            this.Mano1 = baculo;
        }

        //Cambios abajo

        ArrayList ItemsEquipados = new ArrayList();



        public double xDefensaTotal{get; set;}
       
        public double xAtaqueTotal{get; set;}
      

        /*Haciendo  un AddItem o RemoveItem de un array con items, lo que se logra es poder 
        hacerlo de tal forma que no se repita tanto el código, por que en realidad no necesitamos saber donde se equipan
        esos items, ni hay condiciones de momento, por ende para hacer más sencillo el tema, veo mejor hacer un array que
        contega los items que se le agregan, y cuando se agrega el item, directamente agregar a una Property ya sea DefensaTotal o AtaqueTotal
        su valor base correspondiente + el valor sumado por el item. De forma de no tener que estar llamando a un método por ejemplo "getAtaqueTotal"
        cada vez que vayamos a atacar, sino que se podría usar el valor que contiene la Property.
        */

        public void AddItem(Item ItemParaEquipar)
        {
            ItemsEquipados.Add(ItemParaEquipar);
            xDefensaTotal += ItemParaEquipar.Defensa;
            xAtaqueTotal += ItemParaEquipar.Ataque;
        }

        public void RemoveItem(Item ItemParaRemover)
        {
            ItemsEquipados.Remove(ItemParaRemover);
            xDefensaTotal -= ItemParaRemover.Defensa;
            xAtaqueTotal -= ItemParaRemover.Ataque;
        }


        public void xAtacarMago(Mago otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= xAtaqueTotal;
            
        }
        public void xAtacarEnano(Enano otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= xAtaqueTotal;
            
        }
        public void xAtacarElfo(Elfo otro_pj)
        {   
            this.Resistencia -= 10;
            this.Magia -= 15;
            otro_pj.Vida -= xAtaqueTotal;
            
        }

        





    }
}