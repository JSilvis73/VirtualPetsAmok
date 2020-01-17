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
        public void Can_AddPet_To_Shelter()
        {
            OrganicPet myOrganicPet = new OrganicPet();

            myOrganicPet.InShelter = true;

            Assert.False(myOrganicPet.InShelter);
        }
    }
}
