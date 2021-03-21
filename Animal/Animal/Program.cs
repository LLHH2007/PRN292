using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        public string Type { get; set; }

        public Animal(string Type)
        {
            this.Type = Type;
        }

        public abstract void Sound();
        public abstract void Information();
    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public string Name { get; set; }

        public Dog() : base(Type: "mammal")
        {
        }

        public Dog(String Name, String Breed): base(Type :"mammal")
        {
            this.Name = Name;
            this.Breed = Breed;
        }

        public override void Sound()
        {
            Console.WriteLine("Sound: Gau gau");
        }

        public override void Information()
        {
            Console.WriteLine("This is a dog");
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Type = "+ Type);
            Console.WriteLine("Breed = " + Breed);
        }
    }

    class Cat : Animal
    {
        public string Name { get; set; }

        public Cat(String Name) : base(Type: "mammal")
        {
            this.Name = Name;
        }

        public override void Sound()
        {
            Console.WriteLine("Sound: Meow Meow");
        }

        public String Climb()
        {
            Console.WriteLine("Hey, what is the cat climbing?   ");
            return Console.ReadLine();
        }

        public override void Information()
        {
            String climb = Climb();
            Console.WriteLine("This is a cat");
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Type = " + Type);
            Console.WriteLine("The cat is climbing " + climb);
        }
    }

    class Duck : Animal
    {
        public string Name { get; set; }

        public Duck(String Name) : base(Type: "bird")
        {
            this.Name = Name;
        }

        public override void Sound()
        {
            Console.WriteLine("Sound: Cap cap");
        }

        public String Swim()
        {
            Console.WriteLine("Hey, where is the duck swimming?   ");
            return Console.ReadLine();
        }

        public override void Information()
        {
            String swim = Swim();
            Console.WriteLine("This is a cat");
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Type = " + Type);
            Console.WriteLine("The cat is swimming in " + swim);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dg = new Dog("Lucky","Chihuahua");
            dg.Information();
            dg.Sound();
            Console.WriteLine();
            Cat c = new Cat("Orange");
            c.Information();
            c.Sound();
            Console.WriteLine();
            Duck dk = new Duck("Black");
            dk.Information();
            dk.Sound();

            Console.ReadKey();
        }
    }
}
