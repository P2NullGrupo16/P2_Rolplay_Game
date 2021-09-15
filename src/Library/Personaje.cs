using System;

namespace P2_Rolplay_Game
{
    public class Personaje 
    {
        public void Heal( Raza pjx int vida int curacion int stamina)
        {   // va en el constructor de la clase en la cual se vaya a aplicar
           // this.Vida =  100; // vida del personaje a curar 
            //this.Curacion = 30;//bono de curación del elfo
            //this.stamina = 50;
            //this.magia =100;
            //this.Vida1 = 100;
            
            this.stamina -= 10;
            this.magia -= 20;
            pjx.vida = this.Vida1 // restablece la vida del personaje al valor inicial

        }
        
    
    }
}
