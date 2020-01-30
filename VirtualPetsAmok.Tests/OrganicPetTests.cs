using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class OrganicPetTests
    {
        OrganicPet myOrganicPet;

        public OrganicPetTests()
        {
            myOrganicPet = new OrganicPet();
        }
        
        [Fact]
        public void Can_SetPetName()
        {
            
            string petName = "Bob";

            myOrganicPet.SetPetName(petName);

            Assert.Equal("Bob", myOrganicPet.Name);
        }

        [Fact]
        public void Can_Set_PetSpecies()
        {
            
            string species = "Duck";

            myOrganicPet.SetPetSpecies(species);

            Assert.Equal("Duck", myOrganicPet.PetSpecies);
        }

        [Fact]
        public void Does_FeedPetDinner_Reduce_Hunger_To_Zero()
        {
            
            myOrganicPet.HungerLevel = 5;

            myOrganicPet.FeedPetDinner();

            Assert.Equal(0, myOrganicPet.HungerLevel);
        }

        [Fact]
        public void Does_TakePetToDoctor_Increase_Healthlevel_To_Ten()
        {
            
            myOrganicPet.HealthLevel = 5;

            myOrganicPet.TakePetToDoctor();

            Assert.Equal(10, myOrganicPet.HealthLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Decrease_Boredomlevel()
        {
            
            myOrganicPet.BoredomLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(3, myOrganicPet.BoredomLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Increase_Healthlevel()
        {
            
            myOrganicPet.HealthLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(6, myOrganicPet.HealthLevel);
        }

        [Fact]
        public void Does_PlayWithPet_Increase_HungerLevel()
        {
            
            myOrganicPet.HungerLevel = 5;

            myOrganicPet.PlayWithPet();

            Assert.Equal(7, myOrganicPet.HungerLevel);
        }
    }
}
