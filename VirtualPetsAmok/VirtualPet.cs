using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPet
    {
        public string Name { get; set; }
        public string PetSpecies { get; set; }
        public int BoredomLevel { get; set; }
        public VirtualPet()
        {
            BoredomLevel = 3;
        }

        public VirtualPet(string name, string species)
        {
            Name = name;
            PetSpecies = species;
        }

        public virtual void CreatePet()
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

        public virtual void FeedPetDinner()
        {
            
        }
        public virtual void TakePetToDoctor()
        {
            
        }

        public virtual void PlayWithPet()
        {
            
        }
    }
}
