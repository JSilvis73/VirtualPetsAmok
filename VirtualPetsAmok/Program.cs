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
                Console.WriteLine("3. Check Status of your Pet");
                Console.WriteLine("4. Feed Your Pet");
                Console.WriteLine("5. Take Pet To Doctor");
                Console.WriteLine("7. Exit");
                Console.Write("\nPlease enter a number 1 through 7: ");
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
                            if (newUserPet.Name == null)
                            {
                                Console.WriteLine("Please type 1 on the Main Menu and name your pet first.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Your pet's health level is: {newUserPet.HealthLevel} \nYour pet's boredom level is: {newUserPet.BoredomLevel} \nYour pet's hunger level is: {newUserPet.HungerLevel}");
                            }
                            break;
                        }
                    case "4":
                        {
                            if (newUserPet.Name == null)
                            {
                                Console.WriteLine("Please type 1 on the Main Menu and name your pet first.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Would you like to feed your pet a snack or dinner?");
                                Console.WriteLine("Press '1' for snack or '2' for dinner.");
                                string mealChoice = Console.ReadLine();

                                if(mealChoice == "1")
                                {
                                    newUserPet.FeedPetSnack();
                                    Console.WriteLine("You fed your pet a snack. They are satisfied.");
                                }
                                else if(mealChoice == "2")
                                {
                                    newUserPet.FeedPetDinner();
                                    Console.WriteLine("You fed your pet dinner. Your pet is now full.");
                                }
                                else
                                {
                                    Console.WriteLine("You did not select 1 or 2. Returning to main menu.");
                                }
                                break;
                            }
                        }
                    case "5":
                        {
                            if (newUserPet.Name == null)
                            {
                                Console.WriteLine("Please type 1 on the Main Menu and name your pet first.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You took your pet to the doctor. It is now healthy.");
                                newUserPet.TakePetToDoctor();
                            }
                            break;
                        }
                    case "7":
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
