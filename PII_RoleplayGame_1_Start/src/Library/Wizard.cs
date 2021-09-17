using System;

namespace Library
{
    public class Wizards
    {
        public string Name {get;}
        public int Attack {get; set;}
        public int Health {get; set;}
        public int Defense {get; set;}
        public string Item {get;set;}

        public Wizards (string name)
        {
            this.Name = name;
            this.Attack = 50;
            this.Health = 100;
            this.Defense = 90;
        }

        public void AddStaff()
        {
            this.staff = Staff.GetName();
            this.Attack = Attack + Staff.GetDamage();
        }

        public void AddSpellBook()
        {
            this.Item = SpellBook.GetName();
            this.Attack = Attack + SpellBook.GetDamage();
        }

        if (Item == SpellBook)
        {
            public class Fireball
            {
                this.Damage = 50
            }
        }


    }
}