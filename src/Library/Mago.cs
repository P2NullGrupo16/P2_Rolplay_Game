using System;
using System.Collections;

namespace Program
{
    public class Mago
    {
        public Mago(string nombre)
        {
            this.Nombre = nombre;
            
            this.Vida = 80;
            this.Defensa = 40;
            this.Ataque = 10;
            this.Resistencia = 60;
            //this.Magia = 100;
            this.Vida1 = 80;
        }
        public ArrayList LibroHechizos = new ArrayList();
        public int LibroHechizosPoder()
        {
            int poderHechizo = 30;
            foreach (string hechizo in LibroHechizos)
            {
                poderHechizo += 5;
            }
            return poderHechizo;
        }
        private int magia;
        private int ataqueTotal;
        private int defensaTotal;
        private int vida ;
        private int armadura ;

        public Item Casco {get;set;}
        public Item Chaleco {get; set;}
        public Item Botas {get; set;}
        public Item Mano1 {get; set;}
        
        //public Item Mano2 {get; set;}
        public int Defensa {get; set;}
        public int Ataque {get; set;}
        public string Nombre {get;set;}
        public int Resistencia {get; set;}
        public int Vida1 = 80;
        
        public int Armadura
        {
            get
            {
                return this.armadura;
            }
            set
            {
                this.armadura = (this.Casco.Defensa + this.Chaleco.Defensa + this.Botas.Defensa);
            }
        }
        public int Vida 
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
        public int Magia 
        {
            get 
            {
                return this.magia;
            }
            set
            {
                this.magia = 100 + this.Mano1.Magia ;

            }
        }
        public int AtaqueTotal 
        {
            get
            {
                return this.ataqueTotal;
            }
            set
            {
                int result = (this.Ataque + this.Mano1.Ataque + this.LibroHechizosPoder());
                this.ataqueTotal = result ;
            }
        }
        public int DefensaTotal
        {
            get
            {
                return this.defensaTotal;
            }
            set
            {
                this.defensaTotal = this.Defensa + this.Mano1.Defensa +  this.Armadura;
            }
        }
        public void Atacar(Mago otro_pj)
        {
            otro_pj.vida -= this.AtaqueTotal;
            this.Resistencia -= 10;
            this.Magia -= 15;
        }
        public void EstudiarHechizo(string hechizo)
        {
            this.LibroHechizos.Add(hechizo);
        }
        public void AddCasco(Item casco)
        {
            this.Casco = casco;
        }
        public void RemoveCasco()
        {
            this.Casco = null;
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
            this.Chaleco = null;
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
            this.Botas = null;
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
            this.Mano1 = null;
        }
        public void ChangeMano1 (Item baculo)
        {
            this.Mano1 = baculo;
        }




    }
}