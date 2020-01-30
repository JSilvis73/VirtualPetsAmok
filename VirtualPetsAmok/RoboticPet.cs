using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class RoboticPet : VirtualPet
    {
        public int OilNeed { get; set; }
        public int PerformanceLevel { get; set; }
        public RoboticPet() : base()
        {
            OilNeed = 5;
            PerformanceLevel = 8;
        }

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
        public override void FeedPetDinner()
        {
            if (OilNeed < 5)
            {
                OilNeed = 0;
            }
            else
            {
                OilNeed -= 5;
            }
        }
        public override void TakePetToDoctor()
        {
            if (PerformanceLevel > 5)
            {
                PerformanceLevel = 10;
            }
            else
            {
                PerformanceLevel += 5;
            }
        }
        public override void PlayWithPet()
        {

            if (this.BoredomLevel > 3)
            {
                this.BoredomLevel -= 3;
            }
            else
            {
                this.BoredomLevel = 0;
            }

            if (this.PerformanceLevel > 0)
            {
                this.PerformanceLevel -= 1;
            }
            else
            {
                this.PerformanceLevel = 0;
            }

            if (this.OilNeed < 7)
            {
                this.OilNeed += 3;
            }
            else
            {
                this.OilNeed = 10;
            }
        }
    }
}
