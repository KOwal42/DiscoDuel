using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;


       enum specjal
       {
           nic=1,
           heal=2,
           stun=3
       }

    class Bohater
    {
        public Bohater(int hp, int atak, int obrona, int wartosc, specjal specjalny)
        {
            HP = hp;
            Atak = atak;
            Obrona = obrona;
            Wartosc = wartosc;
            Specjalny = specjalny;
        }
        public int podajHp()
        {
         return HP   ;
        }
        public void ustawHp(int hp)
        {
            HP = hp;
        }
        public int podajAtak()
        {
        return Atak;
        }
        public int podajObrone()
        {
            return Obrona;
        }
        public specjal podajSpecjal()
        {
           return Specjalny;
        }
        public int podajWartosc()
        {
            return Wartosc;
        }
        private int Atak;
        private int HP;
        private int Obrona;
        private int Wartosc;
        private specjal Specjalny;

    }
