using System;

namespace MyPets
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDog = new Dog("Rex", "a German Shephard", "John");

            var myPuppy = new Dog("Fluffy", "a Husky", "Nick");

            var myCat = new Cat("Kitty-Kat", "a Persian cat", "Jack");

            myDog.MakeNoise();
            myDog.SayName();
            myDog.OwnerName();

            myPuppy.MakeNoise();
            myPuppy.SayName();
            myPuppy.OwnerName();

            myCat.MakeNoise();
            myCat.SayName();
            myCat.OwnerName();
        }
    }
}
