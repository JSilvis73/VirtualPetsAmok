using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganicPet newUserPet = new OrganicPet();
            bool playing = true;
            Console.WriteLine("Welcome to VirtualPets!");

            do
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Add Pet to Shelter");
                Console.WriteLine("2. Check Status of Pet");
                Console.WriteLine("3. Exit");
                Console.Write("\nPlease enter a number 1 through 3: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        {
                            newUserPet.AddPetToShelter();
                            Console.WriteLine("You successfully added your pet to the shelter.");
                            Console.WriteLine("Please enter the name of your animal:");
                            string petName = Console.ReadLine();
                            newUserPet.Name = petName;
                            Console.WriteLine("What species would you like your pet to be? (Duck, Dog, Cat, Mouse)");
                            string userAddedPetSpecies = Console.ReadLine();
                            newUserPet.PetSpecies = userAddedPetSpecies;
                            Console.WriteLine($"Your new pet is a {newUserPet.PetSpecies}.");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine($"{newUserPet.Name} is a {newUserPet.PetSpecies}.");
                            break;
                        }
                    case "3":
                        {
                            playing = false;
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (playing);
        }
    }
}
