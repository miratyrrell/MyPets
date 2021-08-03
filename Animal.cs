using System;

namespace MyPets
{
    abstract class Animal
    {
        private readonly string name;
        private string breed;
        private string owner;

        public Animal(string name, string breed, string owner) 
        {
            this.name = name;
            this.breed = breed;
            this.owner = owner;
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        //void does not return value
        public abstract void MakeNoise();

        public void SayName()
        {
            Console.WriteLine($"Hello, my name is {name} and I am {breed}.");
        }

        //add \n to add an empty line after the sentence.
        public void OwnerName()
        {
            Console.WriteLine($"My owner's name is {owner}.\n");
        }
    }

    //in here the new class Dog is sub-class to class Animal.
    class Dog : Animal
    {
        public Dog(string name, string breed, string owner) : base(name, breed, owner)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, string breed, string owner) : base(name, breed, owner)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
    }
}