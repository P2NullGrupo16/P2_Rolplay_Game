using System;

namespace Program
{
    public interface IPersonaje
    {
        double Defensa {get; set;}
        double Ataque {get;set;}
        string Nombre {get;set;}
        double Resistencia {get; set;}
        double Vida {get; set;}
        double Magia {get;set;}

        double AtaqueTotal();
        double DefensaTotal();
        void Atacar(IPersonaje otro_pj);
        string GetPersonajeInfo();
        Item Mano1{get; set;}
        Item Casco{get; set;}
        Item Chaleco{get; set;}
        Item Botas{get; set;}

        void AddCasco(Item casco);
        void RemoveCasco();
        void ChangeCasco(Item casco);

        void AddChaleco(Item chaleco);
        void RemoveChaleco();
        void ChangeChaleco(Item chaleco);

        void AddBotas(Item botas);
        void RemoveBotas();
        void ChangeBotas(Item botas);

        void AddMano1(Item baculo);
        void RemoveMano1();
        void ChangeMano1(Item baculo);


    }
}
