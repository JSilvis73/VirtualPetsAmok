using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class RoboticPet : VirtualPet
    {
        public string OilLevel { get; set; }
        public string PerformanceLevel { get; set; }

        public override void CreatePet()
        {
            bool giveValidPetName = false;
            while (giveValidPetName == false)
            {
                Console.WriteLine("Please enter the name of your animal:");
                string petName = Console.ReadLine();
                if (petName == "")
                {
                    Console.WriteLine("You did not enter a valid name. Empty fields are not acceptable.");
                }
                else
                {
                    SetPetName(petName);
                    Console.WriteLine($"Your new pet's name is {petName}.");
                    giveValidPetName = true;
                    break;
                }
            }
            bool giveValidSpecies = false;
            while (giveValidSpecies == false)
            {
                Console.WriteLine("What species would you like your pet to be? (Duck, Dog, Cat, Mouse, etc.)");
                string userAddedPetSpecies = ("Robotic " + Console.ReadLine());
                if (userAddedPetSpecies == "")
                {
                    Console.WriteLine("You did not enter a valid species. Empty fields are not acceptable.");
                }
                else
                {
                    SetPetSpecies(userAddedPetSpecies);
                    Console.WriteLine($"Your new pet is a {PetSpecies}.");
                    giveValidSpecies = true;
                    break;
                }
            }






        }
    }
}
