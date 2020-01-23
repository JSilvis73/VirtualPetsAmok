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
            foreach (OrganicPet pet in shelteredPets)
            {
                Console.WriteLine($"Pet name: {pet.Name}  Species: {pet.PetSpecies}");
            }
        }

        public void ShowShelteredPetsStatus()
        {
            foreach(OrganicPet pet in shelteredPets)
            {
                Console.WriteLine($"{pet.Name} Hunger Level: {pet.HungerLevel} Boredom Level: {pet.BoredomLevel} Health Level: {pet.HealthLevel}");
            }
        }
            
    }
    
}
