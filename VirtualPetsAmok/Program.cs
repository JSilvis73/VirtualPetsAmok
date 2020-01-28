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

            Console.WriteLine("Welcome to VirtualPets! Let's get started by adding your first pet to the shelter.");
            ourPetShelter.AddPetToShelter(newUserPet);
            ourPetShelter.shelteredPets.Add(newUserPet);

            do
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Add Pet to Shelter");
                Console.WriteLine("2. Select Pet");
                Console.WriteLine("3. Check Info (Name and Species) of Pet");
                Console.WriteLine("4. Check Status of your Pets");
                Console.WriteLine("5. Feed Your Pet(s)");
                Console.WriteLine("6. Take Pet(s) To Doctor");
                Console.WriteLine("7. Play With Pet(s)");
                Console.WriteLine("8. Exit");
                Console.Write("\nPlease enter a number 1 through 8: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        {
                            newUserPet = new OrganicPet();
                            ourPetShelter.AddPetToShelter(newUserPet);
                            ourPetShelter.shelteredPets.Add(newUserPet);
                            break;
                        }
                    case "2":
                        {

                            ourPetShelter.ShowShelteredPetsInfo();
                            Console.WriteLine("Please select the pet number that you would like to interact with.");
                            int selectPet = Convert.ToInt32(Console.ReadLine());
                            newUserPet = ourPetShelter.ChoosePetFromList(selectPet);
                            Console.WriteLine($"You've selected {newUserPet.Name}.");
                            break;
                        }
                    case "3":
                        {
                            ourPetShelter.ShowShelteredPetsInfo();
                            break;
                        }
                    case "4":
                        {
                            ourPetShelter.ShowShelteredPetsStatus();

                            break;
                        }
                    case "5":
                        {
                            //Console.WriteLine("Would you like to feed your pet a snack or dinner?");
                            //Console.WriteLine("Press '1' for snack or '2' for dinner.");
                            Console.WriteLine($"Press '1' to feed {newUserPet.Name} or '2' to feed all pets. Press any other key to return to the main menu.");
                            string mealChoice = Console.ReadLine();

                            if (mealChoice == "1")
                            {
                                //newUserPet.FeedPetSnack();
                                newUserPet.FeedPetDinner();
                                Console.WriteLine($"You fed {newUserPet.Name} dinner. Your pet is now full.");
                            }
                            else if (mealChoice == "2")
                            {
                                ourPetShelter.FeedAllPetsDinner();
                                Console.WriteLine("You fed all of your pets dinner. All pets are full.");
                            }
                            else
                            {
                                Console.WriteLine("Returning to main menu.");
                            }
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine($"Press '1' to take {newUserPet.Name} to the doctor or '2' to take all pets to the doctor. Press any other key to return to the main menu.");
                            string doctorChoice = Console.ReadLine();
                            if (doctorChoice == "1")
                            {
                                Console.WriteLine($"You took {newUserPet.Name} to the doctor. It is now healthy.");
                                newUserPet.TakePetToDoctor();
                            }
                            else if (doctorChoice == "2")
                            {
                                ourPetShelter.TakeAllPetsToDoctor();
                                Console.WriteLine("You took all your pets to the doctor. All of them are now healthy.");
                            }
                            else
                            {
                                Console.WriteLine("Returning to main menu.");
                            }
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine($"Press '1' to play with {newUserPet.Name} or '2' to play with all of your pets. Press any other key to return to the main menu.");
                            string playChoice = Console.ReadLine();
                            if (playChoice == "1")
                            {
                                Console.WriteLine($"You have played with {newUserPet.Name}! Its status has changed.");
                                newUserPet.PlayWithPet();
                            }
                            else if (playChoice == "2")
                            {
                                ourPetShelter.PlayWithAllPets();
                                Console.WriteLine("You played with all of your pets! Their statuses have changed.");
                            }
                            else
                            {
                                Console.WriteLine("Returning to main menu.");
                            }
                            break;
                        }
                    case "8":
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
