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
        public void AddPetToShelter()
        {
            this.InShelter = true;
        }
        public OrganicPet(string name = "Bob")
        {
            Name = name;
        }
    }
}
