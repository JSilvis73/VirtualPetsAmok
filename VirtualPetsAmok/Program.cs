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
                Console.WriteLine("2. Check Name and Species of Pet");
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
                            newUserPet.SetPetName(petName);
                            Console.WriteLine($"Your new pet's name is {petName}.");
                            Console.WriteLine("What species would you like your pet to be? (Duck, Dog, Cat, Mouse, etc.)");
                            string userAddedPetSpecies = Console.ReadLine();
                            newUserPet.SetPetSpecies(userAddedPetSpecies);
                            Console.WriteLine($"Your new pet is a {newUserPet.PetSpecies}.");
                            break;
                        }
                    case "2":
                        {
                            if (newUserPet.Name == null)
                            {
                                Console.WriteLine("Please type 1 on the Main Menu and name your pet first.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{newUserPet.Name} is a {newUserPet.PetSpecies}.");
                                break;
                            }
                        }
                    case "3":
                        {
                            playing = false;
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid number.");
                            break;
                        }
                }
            } while (playing);
        }
    }
}
