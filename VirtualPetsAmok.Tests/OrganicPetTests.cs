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
        public void Can_SetPetName()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            string petName = "Bob";

            myOrganicPet.SetPetName(petName);

            Assert.Equal("Bob", myOrganicPet.Name);
        }

        [Fact]
        public void Can_Set_PetSpecies()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            string species = "Duck";

            myOrganicPet.SetPetSpecies(species);

            Assert.Equal("Duck", myOrganicPet.PetSpecies);
        }

        [Fact]
        public void Does_FeedPetDinner_Reduce_Hunger_To_Zero()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            myOrganicPet.HungerLevel = 5;

            myOrganicPet.FeedPetDinner();

            Assert.Equal(0, myOrganicPet.HungerLevel);
        }

        [Fact]
        public void Does_TakePetToDoctor_Increase_Healthlevel_To_Ten()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            myOrganicPet.HealthLevel = 5;

            myOrganicPet.TakePetToDoctor();

            Assert.Equal(10, myOrganicPet.HealthLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Decrease_Boredomlevel()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            myOrganicPet.BoredomLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(3, myOrganicPet.BoredomLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Increase_Healthlevel()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            myOrganicPet.HealthLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(6, myOrganicPet.HealthLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Increase_HungerLevel()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            myOrganicPet.HungerLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(7, myOrganicPet.HungerLevel);
        }
    }
}
