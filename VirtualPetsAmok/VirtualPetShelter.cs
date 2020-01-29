using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPetShelter
    {
        public List<OrganicPet> shelteredOrganicPets = new List<OrganicPet>();
        public List<RoboticPet> shelteredRoboticPets = new List<RoboticPet>();

        public void ShowOrganicShelteredPetsInfo()
        {
            int count = 1;
            foreach (OrganicPet pet in shelteredOrganicPets)
            {
                Console.WriteLine($"{count}. Pet name: {pet.Name}  Species: {pet.PetSpecies}");
                count++;
            }
        }
        public void ShowRoboticShelteredPetsInfo()
        {
            int count = 1;
            foreach (RoboticPet pet in shelteredRoboticPets)
            {
                Console.WriteLine($"{count}. Pet name: {pet.Name}  Species: {pet.PetSpecies}");
                count++;
            }
        }
        public void ShowShelteredOrganicPetsStatus()
        {
            int count = 1;
            foreach (OrganicPet pet in shelteredOrganicPets)
            {
                Console.WriteLine($"{count}. {pet.Name}: Hunger Level: {pet.HungerLevel} Boredom Level: {pet.BoredomLevel} Health Level: {pet.HealthLevel}");
                count++;
            }
        }
        public void ShowShelteredRoboticPetsStatus()
        {
            int count = 1;
            foreach (RoboticPet pet in shelteredRoboticPets)
            {
                Console.WriteLine($"{count}. {pet.Name}: Oil Need: {pet.OilNeed} Boredom Level: {pet.BoredomLevel} Performance Level: {pet.PerformanceLevel}");
                count++;
            }
        }
        public OrganicPet ChoosePetFromOrganicList()
        {
            Console.WriteLine("Please select the organic pet number that you would like to interact with.");
            int selectPet = Convert.ToInt32(Console.ReadLine());
            int petNumber = (selectPet - 1);
            return shelteredOrganicPets[petNumber];
        }
        public RoboticPet ChoosePetFromRoboticList()
        {
            Console.WriteLine("Please select the robotic pet number that you would like to interact with.");
            int selectPet = Convert.ToInt32(Console.ReadLine());
            int petNumber = (selectPet - 1);
            return shelteredRoboticPets[petNumber];
        }



        public void FeedAllPetsDinner()
        {
            foreach (OrganicPet pet in shelteredOrganicPets)
            {
                pet.FeedPetDinner();
            }
            foreach (RoboticPet pet in shelteredRoboticPets)
            {
                pet.FeedPetDinner();
            }
        }
        public void TakeAllPetsToDoctor()
        {
            foreach (OrganicPet pet in shelteredOrganicPets)
            {
                pet.TakePetToDoctor();
            }
            foreach (RoboticPet pet in shelteredRoboticPets)
            {
                pet.TakePetToDoctor();
            }
        }
        public void PlayWithAllPets()
        {
            foreach (OrganicPet pet in shelteredOrganicPets)
            {
                pet.PlayWithPet();
            }
            foreach (RoboticPet pet in shelteredRoboticPets)
            {
                pet.PlayWithPet();
            }
        }
        public void AddOrganicPetToShelter(OrganicPet pet)
        {
            shelteredOrganicPets.Add(pet);
            Console.WriteLine($"You successfully added {pet.Name} to the shelter!");
            //move to OrganicPet.cs
        }
        public void AddRoboticPetToShelter(RoboticPet pet)
        {
            shelteredRoboticPets.Add(pet);
            Console.WriteLine($"You successfully added {pet.Name} to the shelter!");
        }
    }
    
}
