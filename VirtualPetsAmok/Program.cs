using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganicPet newUserPet = new OrganicPet();
            Console.WriteLine("Welcome to VirtualPets!");
            Console.WriteLine("Would you like to add a pet to the shelter?");
            string wantToShelter = (Console.ReadLine().ToLower());
            // add loop later

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
            Console.WriteLine("Please enter the name of your animal:");
            string petName = Console.ReadLine();
            newUserPet.Name = petName;
            Console.WriteLine("What species would you like your pet to be? (Duck, Dog, Cat, Mouse)");
            string userAddedPetSpecies = Console.ReadLine();
            //switch case

            newUserPet.PetSpecies = userAddedPetSpecies;
            Console.WriteLine("Your new pet is a " + userAddedPetSpecies + ".");
        }
    }
}
