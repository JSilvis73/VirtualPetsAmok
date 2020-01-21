using System;
using VirtualPetsAmok;
using Xunit;

namespace OrganicPets.Tests
{
    public class OrganicPetTests
    {
        [Fact]
        public void Can_Create_Pet_Instance()
        {
            new OrganicPet();
        }
        [Fact]
        public void Can_Set_petName()
        {
            OrganicPet myOrganicPet = new OrganicPet();

            myOrganicPet.Name = "Frank";

            Assert.Equal("Frank", myOrganicPet.Name);
        }
        [Fact]
        public void Is_Pet_In_Shelter()
        {
            OrganicPet myOrganicPet = new OrganicPet();

            myOrganicPet.InShelter = false;

            Assert.False(myOrganicPet.InShelter);
        }
        [Fact]
        public void Can_AddPetToShelter()
        {
            OrganicPet myOrganicPet = new OrganicPet();

            myOrganicPet.AddPetToShelter();

            Assert.True(myOrganicPet.InShelter);
        }
        [Fact]
        public void Can_Set_PetSpecies()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            string species = "Duck";
             
            myOrganicPet.SetPetSpecies(species);

            Assert.Equal("Duck", myOrganicPet.PetSpecies);
        }
    }
}
