using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class OrganicPet
    {
        public string Name { get; set; }
        public string PetSpecies { get; set; }
        public bool InShelter { get; set; }
        public int HungerLevel { get; set; }
        public int BoredomLevel { get; set; }
        public int HealthLevel { get; set; }
        public void AddPetToShelter()
        {
            this.InShelter = true;
        }
        public OrganicPet()
        {
            HungerLevel = 3;
            BoredomLevel = 3;
            HealthLevel = 10;
        }
        public OrganicPet(string name, string species)
        {
            Name = name;
            PetSpecies = species;
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

        public void FeedPetSnack()
        {
            if (HungerLevel <= 2)
            {
                this.HungerLevel = 0;
            }
            else
            {
                this.HungerLevel -= 2;
            }
        }

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
