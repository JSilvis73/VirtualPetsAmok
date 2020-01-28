using System;
using VirtualPetsAmok;
using Xunit;

namespace VirtualPet.Tests
{
    public class VirtualPetTests
    {
        [Fact]
        public void Can_Create_Pet_Instance()
        {
            new VirtualPet();
        }

        [Fact]
        public void Can_SetPetName()
        {
            VirtualPet myOrganicPet = new VirtualPet();
            string petName = "Bob";

            myOrganicPet.SetPetName(petName);

            Assert.Equal("Bob", myOrganicPet.Name);
        }

        [Fact]
        public void Can_Set_PetSpecies()
        {
            VirtualPet myOrganicPet = new VirtualPet();
            string species = "Duck";

            myOrganicPet.SetPetSpecies(species);

            Assert.Equal("Duck", myOrganicPet.PetSpecies);
        }

        [Fact]
        public void Does_FeedPetDinner_Reduce_Hunger_To_Zero()
        {
            VirtualPet myOrganicPet = new VirtualPet();
            myOrganicPet.HungerLevel = 5;

            myOrganicPet.FeedPetDinner();

            Assert.Equal(0, myOrganicPet.HungerLevel);
        }

        [Fact]
        public void Does_TakePetToDoctor_Increase_Healthlevel_To_Ten()
        {
            VirtualPet myOrganicPet = new VirtualPet();
            myOrganicPet.HealthLevel = 5;

            myOrganicPet.TakePetToDoctor();

            Assert.Equal(10, myOrganicPet.HealthLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Decrease_Boredomlevel()
        {
            VirtualPet myOrganicPet = new VirtualPet();
            myOrganicPet.BoredomLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(3, myOrganicPet.BoredomLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Increase_Healthlevel()
        {
            VirtualPet myOrganicPet = new VirtualPet();
            myOrganicPet.HealthLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(6, myOrganicPet.HealthLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Increase_HungerLevel()
        {
            VirtualPet myOrganicPet = new VirtualPet();
            myOrganicPet.HungerLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(7, myOrganicPet.HungerLevel);
        }
    }
}
