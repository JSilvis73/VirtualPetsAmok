using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to VirtualPets!");
            Console.WriteLine("Please enter the name of your animal:");
            string petName = Console.ReadLine();
            OrganicPet newUserPet = new OrganicPet(petName);
            Console.WriteLine("Your pet's name is " + newUserPet.Name + ".");
            Console.WriteLine("Would you like to add " + newUserPet.Name + "to the shelter?");
            string wantToShelter = (Console.ReadLine().ToLower());
            if (wantToShelter == "yes")
            {
                newUserPet.AddPetToShelter();
                Console.WriteLine("You successfully added your pet to the shelter.");
            }
            else if (wantToShelter == "no")
            {
                Console.WriteLine("You did not add pet to shelter.");
            }
            else
            {
                Console.WriteLine("You did not answer yes or no.");
            }

        }
    }
}
