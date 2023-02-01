using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest5
{
    public delegate void ActionDelegate();

    internal class Player : IPlayer
    {
        private string name;
        private int age;
        private int attack;
        private int defense;
        private int stamina;
        private int speed;
        private int power;

        public Player()
        {
        }

        public Player(string name, int age, int attack, int defense, int stamina, int speed, int power)
        {
            this.name = name;
            this.age = age;
            this.attack = attack;
            this.defense = defense;
            this.stamina = stamina;
            this.speed = speed;
            this.power = power;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 40)
                {
                    age = value;
                }
            }
        }

        public int Attack
        {
            get { return attack; }
            set
            {
                if (value > 0 && value < 100)
                {
                    attack = value;
                }
            }
        }

        public int Defense
        {
            get { return defense; }
            set
            {
                if (value > 0 && value < 100)
                {
                    defense = value;
                }
            }
        }

        public int Stamina
        {
            get { return stamina; }
            set
            {
                if (value > 0 && value < 100)
                {
                    stamina = value;
                }
            }
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 0 && value < 100)
                {
                    speed = value;
                }
            }
        }

        public int Power
        {
            get { return power; }
            set
            {
                if (value > 0 && value < 100)
                {
                    power = value;
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Player's name: {0}", name);
            Console.WriteLine("Player's age: {0}", age);
            Console.WriteLine("Player average point: {0}", (attack + defense + stamina + speed + power) / 5);
        }
    }
}
