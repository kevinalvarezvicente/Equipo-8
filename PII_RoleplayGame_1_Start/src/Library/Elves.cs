using System;

namespace Library
{
    public class Elves
    {
        public string Name {get;}
        public int Health {get; private set;}
        public int Attack {get; private set;}
        public int Defense {get; private set;}

        public Elves (string name, int health, int attack, int defense)
        {
            this.Name = name;
            this.Health = health;
            this.Attack = attack;
            this.Defense = defense;
        }

    }
}
