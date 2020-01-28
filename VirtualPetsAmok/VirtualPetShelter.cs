using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPetShelter
    {
        public List<OrganicPet> shelteredPets = new List<OrganicPet>();

        public void ShowShelteredPetsInfo()
        {
            int count = 1;
            foreach (OrganicPet pet in shelteredPets)
            {
                Console.WriteLine($"{count}. Pet name: {pet.Name}  Species: {pet.PetSpecies}");
                count++;
            }
        }
        public OrganicPet ChoosePetFromList(int input)
        {
            int petNumber = (input - 1);
            return shelteredPets[petNumber];
        }


        public void ShowShelteredPetsStatus()
        {
            int count = 1;
            foreach (OrganicPet pet in shelteredPets)
            {
                Console.WriteLine($"{count}. {pet.Name}: Hunger Level: {pet.HungerLevel} Boredom Level: {pet.BoredomLevel} Health Level: {pet.HealthLevel}");
                count++;
            }
        }
        public void FeedAllPetsDinner()
        {
            foreach (OrganicPet pet in shelteredPets)
            {
                pet.FeedPetDinner();
            }
        }
        /*public void FeedAllPetsSnack()
        {
            foreach(OrganicPet pet in shelteredPets)
            {
                pet.HungerLevel -= 2;
            }
        }*/

        public void TakeAllPetsToDoctor()
        {
            foreach (OrganicPet pet in shelteredPets)
            {
                pet.TakePetToDoctor();
            }
        }
        public void PlayWithAllPets()
        {
            foreach (OrganicPet pet in shelteredPets)
            {
                pet.PlayWithPet();
            }
        }
        public void AddPetToShelter(OrganicPet pet)
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
                    pet.SetPetName(petName);
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
                    pet.SetPetSpecies(userAddedPetSpecies);
                    Console.WriteLine($"Your new pet is a {pet.PetSpecies}.");
                    giveValidSpecies = true;
                    break;
                }
            }
            Console.WriteLine($"You successfully added {pet.Name} to the shelter!");
        }
    }
    
}
