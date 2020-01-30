using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPetShelter
    {
        public List<VirtualPet> allShelteredPets = new List<VirtualPet>();
        public List<OrganicPet> shelteredOrganicPets = new List<OrganicPet>();
        public List<RoboticPet> shelteredRoboticPets = new List<RoboticPet>();

        public void ShowOrganicShelteredPetsInfo()
        {
            Console.WriteLine("\nOrganic Pet List:");
            int count = 1;
            foreach (OrganicPet pet in shelteredOrganicPets)
            {
                Console.WriteLine($"{count}. Pet name: {pet.Name}  Species: {pet.PetSpecies}");
                count++;
            }
        }
        public void ShowRoboticShelteredPetsInfo()
        {
            Console.WriteLine("\nRobotic Pet List:");
            int count = 1;
            foreach (RoboticPet pet in shelteredRoboticPets)
            {
                Console.WriteLine($"{count}. Pet name: {pet.Name}  Species: {pet.PetSpecies}");
                count++;
            }
        }
        public void ShowShelteredOrganicPetsStatus()
        {
            Console.WriteLine("\nOrganic Pet Status:");
            int count = 1;
            foreach (OrganicPet pet in shelteredOrganicPets)
            {
                Console.WriteLine($"{count}. {pet.Name}: Hunger Level: {pet.HungerLevel} Boredom Level: {pet.BoredomLevel} Health Level: {pet.HealthLevel}");
                count++;
            }
        }
        public void ShowShelteredRoboticPetsStatus()
        {
            Console.WriteLine("\nRobotic Pet Status:");
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
            foreach (VirtualPet pet in allShelteredPets)
            {
                pet.FeedPetDinner();
            }
        }
        public void TakeAllPetsToDoctor()
        {
            foreach (VirtualPet pet in allShelteredPets)
            {
                pet.TakePetToDoctor();
            }
        }
        public void PlayWithAllPets()
        {
            foreach (VirtualPet pet in allShelteredPets)
            {
                pet.PlayWithPet();
            }
        }
        public void AddOrganicPetToShelter(OrganicPet pet)
        {
            shelteredOrganicPets.Add(pet);
            allShelteredPets.Add(pet);
            Console.WriteLine($"You successfully added {pet.Name} to the shelter!");
            //move to OrganicPet.cs
        }
        public void AddRoboticPetToShelter(RoboticPet pet)
        {
            shelteredRoboticPets.Add(pet);
            allShelteredPets.Add(pet);
            Console.WriteLine($"You successfully added {pet.Name} to the shelter!");
        }
        public void AdoptPet()
        {
            Console.WriteLine("Which pet list do you wish to see?: 1.Organic 2.Robotic");
            string newUserInput = Console.ReadLine();
            if (newUserInput == "1")
            {
                ShowOrganicShelteredPetsInfo();
                Console.WriteLine("Select the number pet you wish to adopt.");
                int selectedPet = Convert.ToInt32(Console.ReadLine());
                int index = (selectedPet - 1);
                Console.WriteLine($"You've adopted {shelteredOrganicPets[index].Name}!");
                shelteredOrganicPets.RemoveAt(index);
            }
            else if (newUserInput == "2")
            {
                ShowRoboticShelteredPetsInfo();
                Console.WriteLine("Select the number pet you wish to adopt.");
                int selectedPet = Convert.ToInt32(Console.ReadLine());
                int index = (selectedPet - 1);
                Console.WriteLine($"You've adopted {shelteredRoboticPets[index].Name}!");
                shelteredRoboticPets.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("You did not enter '1' or '2'. Returning to main menu.");
            }


        }
    }
    
}
