using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class OrganicPet
    {
        public string Name { get; set; }
        public string PetSpecies { get; set; }
        public int HungerLevel { get; set; }
        public int BoredomLevel { get; set; }
        public int HealthLevel { get; set; }
        public OrganicPet()
        {
            HungerLevel = 3;
            BoredomLevel = 3;
            //leave health at 7 for sake of testing?
            HealthLevel = 7;
        }

        public OrganicPet(string name, string species)
        {
            Name = name;
            PetSpecies = species;
        }

        public void CreatePet()
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
                string userAddedPetSpecies = Console.ReadLine();
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

        public void SetPetSpecies(string petSpecies)
        {
            PetSpecies = petSpecies;
        }

        public void SetPetName(string petName)
        {
            Name = petName;
        }

        public void FeedPetDinner()
        {
            this.HungerLevel = 0;
        }

        /*public void FeedPetSnack()
        {
            if (HungerLevel <= 2)
            {
                this.HungerLevel = 0;
            }
            else
            {
                this.HungerLevel -= 2;
            }
        }*/

        public void TakePetToDoctor()
        {
            this.HealthLevel = 10;
        }

        public void PlayWithPet()
        {
            
            if(this.BoredomLevel > 2)
            {
                this.BoredomLevel -= 2;
            }
            else
            {
                this.BoredomLevel = 0;
            }
            
            if(this.HealthLevel <= 9)
            {
                this.HealthLevel += 1;
            }
            else
            {
                this.HealthLevel = 10;
            }

            if(this.HungerLevel < 8)
            {
                this.HungerLevel += 2;
            }
            else
            {
                this.HungerLevel = 10;
            }
        }
    }
}
