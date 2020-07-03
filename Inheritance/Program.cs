using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var johnsBird = new Bird();
            johnsBird.CanFly = true;
            johnsBird.BirdColor = "blue";
            johnsBird.NumOfWings = 2;
            johnsBird.BeakLength = 6;





            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            // ****** Using Object initialize syntax for Reptiles*******
            var myReptile = new Reptile()
            {
                NumOfLegs = 4,
                HasClaws = true,
                NativeTo = "North America",
                HasTeeth = true,
            };

            var myAnimals = new Animal[] { johnsBird, myReptile };

            var myBird = new Bird[] { johnsBird };

            var johnsReptile = new Reptile[] { myReptile };

            foreach (var bird in myBird)
            {
                Console.WriteLine("Bird qualities:");
                Console.WriteLine($"The bird can fly: {johnsBird.CanFly}");
                Console.WriteLine($"The bird is {johnsBird.BirdColor}");
                Console.WriteLine($"The bird has {johnsBird.NumOfWings} wings.");
                Console.WriteLine($"The birds beak is {johnsBird.BeakLength} inches.");
                Console.WriteLine("");

            }

            foreach (var reptile in johnsReptile)
            {
                Console.WriteLine("Reptile qualities:");
                Console.WriteLine($"The reptile has {myReptile.NumOfLegs} legs.");
                Console.WriteLine($"The repile has claws: {myReptile.HasClaws}.");
                Console.WriteLine($"The reptiles is indigenous to {myReptile.NativeTo}.");
                Console.WriteLine($"The reptile has teeth: {myReptile.HasTeeth}.");
                Console.WriteLine("");
            }


            foreach (var animal in myAnimals)
            {
                Console.WriteLine("Animal qualities:");
                Console.WriteLine($"The animal is alive: {animal.IsAlive}");
                Console.WriteLine($"The animal lives outdoors: {animal.LivesOutdoors}");
                Console.WriteLine($"The animal has fur: {animal.HasFur}");
                Console.WriteLine($"The animal is {animal.Age} years old.");
            }

        }
    }
}
