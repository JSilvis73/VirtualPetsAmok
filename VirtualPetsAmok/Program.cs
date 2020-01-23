using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganicPet newUserPet = new OrganicPet();
            VirtualPetShelter ourPetShelter = new VirtualPetShelter();
            bool playing = true;
            
            Console.WriteLine("Welcome to VirtualPets!");

            do
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Add Pet to Shelter");
                Console.WriteLine("2. Check Info (Name and Species) of Pet");
                Console.WriteLine("3. Check Status of your Pets");
                Console.WriteLine("4. Feed Your Pet(s)");
                Console.WriteLine("5. Take Pet(s) To Doctor");
                Console.WriteLine("6. Play With Pet(s)");
                Console.WriteLine("7. Exit");
                Console.Write("\nPlease enter a number 1 through 7: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        {
                            newUserPet = new OrganicPet();
                            Console.WriteLine("Please enter the name of your animal:");
                            string petName = Console.ReadLine();
                            if (petName == "")
                            {
                                Console.WriteLine("You did not enter a valid name. Empty fields are not acceptable.");
                                break;
                            }
                            else
                            {
                                newUserPet.SetPetName(petName);
                                Console.WriteLine($"Your new pet's name is {petName}.");

                            }
                            bool giveValidSpecies = false;
                            while (giveValidSpecies == false)
                            {
                                Console.WriteLine("What species would you like your pet to be? (Duck, Dog, Cat, Mouse, etc.)");
                                string userAddedPetSpecies = Console.ReadLine();
                                if (userAddedPetSpecies == "")
                                {
                                    Console.WriteLine("You did not enter a valid species. Empty fields are not acceptable.");
                                }
                                else
                                {
                                    newUserPet.SetPetSpecies(userAddedPetSpecies);
                                    Console.WriteLine($"Your new pet is a {newUserPet.PetSpecies}.");
                                    giveValidSpecies = true;
                                    break;
                                }
                            }
                            //newUserPet.AddPetToShelter();
                            Console.WriteLine($"You successfully added {newUserPet.Name} to the shelter!");
                            ourPetShelter.shelteredPets.Add(newUserPet);
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
                                ourPetShelter.ShowShelteredPetsInfo();
                            }
                            break;
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
                                //Console.WriteLine($"Your pet's health level is: {newUserPet.HealthLevel} \nYour pet's boredom level is: {newUserPet.BoredomLevel} \nYour pet's hunger level is: {newUserPet.HungerLevel}");
                                ourPetShelter.ShowShelteredPetsStatus();
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
                    case "6":
                        {
                            if (newUserPet.Name == null)
                            {
                                Console.WriteLine("Please type 1 on the Main Menu and name your pet first.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have played with your pet! Its status has changed.");
                                newUserPet.PlayWithPet();
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
