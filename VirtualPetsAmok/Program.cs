using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganicPet newOrganicPet = new OrganicPet();
            RoboticPet newRoboticPet = new RoboticPet();
            VirtualPetShelter ourPetShelter = new VirtualPetShelter();
            bool playing = true;

            Console.WriteLine("Welcome to VirtualPets! Let's get started by adding your first pet to the shelter.");
            bool validOption = false;
            while (validOption == false)
            {
                Console.WriteLine("What is your pet?: 1.Organic 2.Robotic");
                string userInput = (Console.ReadLine());
                if (userInput == "1")
                {
                    newOrganicPet.CreatePet();
                    ourPetShelter.AddOrganicPetToShelter(newOrganicPet);
                    validOption = true;
                }
                else if (userInput == "2")
                {
                    newRoboticPet.CreatePet();
                    ourPetShelter.AddRoboticPetToShelter(newRoboticPet);
                    validOption = true;
                }
                else
                {
                    Console.WriteLine("Please enter '1' or '2'.");
                }

            }

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
                            Console.WriteLine("What is your pet?: 1.Organic 2.Robotic");
                            string newUserInput = Console.ReadLine();
                            if (newUserInput == "1")
                            {
                                newOrganicPet = new OrganicPet();
                                newOrganicPet.CreatePet();
                                ourPetShelter.AddOrganicPetToShelter(newOrganicPet);
                            }
                            else if (newUserInput == "2")
                            {
                                newRoboticPet = new RoboticPet();
                                newRoboticPet.CreatePet();
                                ourPetShelter.AddRoboticPetToShelter(newRoboticPet);
                            }
                            else
                            {
                                Console.WriteLine("You didn't enter a valid number.");
                            }
                            //Need an else
                            //newOrganicPet = new OrganicPet();
                            //newOrganicPet.CreatePet();
                            //ourPetShelter.AddOrganicPetToShelter(newOrganicPet);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Which pet list do you wish to see?: 1.Organic 2.Robotic");
                            string newUserInput = Console.ReadLine();
                            if (newUserInput == "1")
                            {
                                ourPetShelter.ShowOrganicShelteredPetsInfo();
                                newOrganicPet = ourPetShelter.ChoosePetFromOrganicList();
                                Console.WriteLine($"You've selected {newOrganicPet.Name}. Returning to Main Menu.");
                            }
                            else if (newUserInput == "2")
                            {
                                ourPetShelter.ShowRoboticShelteredPetsInfo();
                                newRoboticPet = ourPetShelter.ChoosePetFromRoboticList();
                                Console.WriteLine($"You've selected {newRoboticPet.Name}. Returning to Main Menu.");
                            }
                            else
                            {
                                Console.WriteLine("You did not enter '1' or '2'. Returning to main menu.");
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Which pet list do you wish to see?: 1.Organic 2.Robotic");
                            int newUserInput = Convert.ToInt32(Console.ReadLine());
                            if (newUserInput == 1)
                            {
                                ourPetShelter.ShowOrganicShelteredPetsInfo();
                            }
                            else if (newUserInput == 2)
                            {
                                ourPetShelter.ShowRoboticShelteredPetsInfo();
                            }
                            //else statement needed
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Which pet list do you wish to see?: 1.Organic 2.Robotic");
                            int newUserInput = Convert.ToInt32(Console.ReadLine());
                            if (newUserInput == 1)
                            {
                                ourPetShelter.ShowShelteredOrganicPetsStatus();
                            }
                            else if (newUserInput == 2)
                            {
                                ourPetShelter.ShowShelteredRoboticPetsStatus();
                            }
                            //else statement
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine($"Press '1' to feed {newOrganicPet.Name} or '2' to feed {newRoboticPet.Name}. \nPress '3' to feed/oil all pets. \nPress any other key to return to main menu.");
                            string mealChoice = Console.ReadLine();
                            switch (mealChoice)
                            {
                                case "1":
                                    {
                                        newOrganicPet.FeedPetDinner();
                                        Console.WriteLine($"You fed {newOrganicPet.Name} dinner. Your pet is now full.");
                                        break;
                                    }
                                case "2":
                                    {
                                        newRoboticPet.FeedPetDinner();
                                        Console.WriteLine($"You oiled {newRoboticPet.Name}. No more squeaks!");
                                        break;
                                    }
                                case "3":
                                    {
                                        ourPetShelter.FeedAllPetsDinner();
                                        Console.WriteLine("You have fed and/or oiled all the pets in the shelter!");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Returning to main menu.");
                                        break;
                                    }
                            }
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine($"Press '1' to take {newOrganicPet.Name} to the doctor or '2' to take {newRoboticPet.Name} to the mechanic. \nPress '3' to take all pets to the doctor/mechanic.\nPress any other key to return to the main menu.");
                            string doctorChoice = Console.ReadLine();
                            switch (doctorChoice)
                            {
                                case "1":
                                    {
                                        newOrganicPet.TakePetToDoctor();
                                        Console.WriteLine($"You took {newOrganicPet.Name} to the doctor. It is now healthy!");
                                        break;
                                    }
                                case "2":
                                    {
                                        newRoboticPet.TakePetToDoctor();
                                        Console.WriteLine($"You took {newRoboticPet.Name} to the mechanic. It is now functioning properly!");
                                        break;
                                    }
                                case "3":
                                    {
                                        ourPetShelter.TakeAllPetsToDoctor();
                                        Console.WriteLine("You took all your pets to the doctor/mechanic. All of them are now healthy!");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Returning to main menu.");
                                        break;
                                    }
                            }
                            //if (doctorChoice == "1")
                            //{
                            //    Console.WriteLine($"You took {newOrganicPet.Name} to the doctor. It is now healthy.");
                            //    newOrganicPet.TakePetToDoctor();
                            //}
                            //else if (doctorChoice == "2")
                            //{
                            //    ourPetShelter.TakeAllPetsToDoctor();
                            //    Console.WriteLine("You took all your pets to the doctor. All of them are now healthy.");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Returning to main menu.");
                            //}
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine($"Press '1' to play with {newOrganicPet.Name} or press '2' to play with {newRoboticPet.Name}. \nPress '3' to play with all of your pets. \nPress any other key to return to the main menu.");
                            string playChoice = Console.ReadLine();
                            switch (playChoice)
                            {
                                case "1":
                                    {
                                        newOrganicPet.PlayWithPet();
                                        Console.WriteLine($"You have played with {newOrganicPet.Name}! It's less bored and healthier, but is more hungry now!");
                                        break;
                                    }
                                case "2":
                                    {
                                        newRoboticPet.PlayWithPet();
                                        Console.WriteLine($"You have played with {newRoboticPet.Name}! It's less bored, but now needs some oil and maintenance!");
                                        break;
                                    }
                                case "3":
                                    {
                                        ourPetShelter.PlayWithAllPets();
                                        Console.WriteLine("You have played with all pets in the shelter! Their statuses have changed.");
                                        break;
                                    }
                            }
                            //if (playChoice == "1")
                            //{
                            //    newOrganicPet.PlayWithPet();
                            //    Console.WriteLine($"You have played with {newOrganicPet.Name}! Its status has changed.");
                            //}
                            //else if (playChoice == "2")
                            //{
                            //    ourPetShelter.PlayWithAllPets();
                            //    Console.WriteLine("You played with all of your pets! Their statuses have changed.");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Returning to main menu.");
                            //}
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
