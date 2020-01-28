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
        public OrganicPet ChoosePetFromList()
        {
            Console.WriteLine("Please select the pet number that you would like to interact with.");
            int selectPet = Convert.ToInt32(Console.ReadLine());
            int petNumber = (selectPet - 1);
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
            shelteredPets.Add(pet);
            Console.WriteLine($"You successfully added {pet.Name} to the shelter!");
            //move to OrganicPet.cs
        }
    }
    
}
