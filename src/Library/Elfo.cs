using System;
using System.Collections;
using System.Text;

namespace Program
{
    public class Elfo
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
        public void CurarMago(Mago otro_pj)
        {   
            this.Resistencia -= 5;
            this.Magia -= 10;
            otro_pj.Vida = otro_pj.Vida1;
        }
        public void CurarEnano(Enano otro_pj)
        {   
            this.Resistencia -= 5;
            this.Magia -= 10;
            otro_pj.Vida = otro_pj.Vida1;
        }
        public void CurarElfo(Elfo otro_pj)
        {   
            this.Resistencia -= 5;
            this.Magia -= 10;
            otro_pj.Vida = otro_pj.Vida1;
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
        public void AddMano1(Item arco)
        {
            this.Mano1 = arco;
        }
        public void RemoveMano1()
        {
            this.Mano1 = new Item("",0,0,0);
        }
        public void ChangeMano1 (Item arco)
        {
            this.Mano1 = arco;
        }
        public void AddMano2(Item flecha)
        {
            this.Mano1 = flecha;
        }
        public void RemoveMano2()
        {
            this.Mano1 = new Item("",0,0,0);
        }
        public void ChangeMano2 (Item flecha)
        {
            this.Mano1 = flecha;
        }




    }
}