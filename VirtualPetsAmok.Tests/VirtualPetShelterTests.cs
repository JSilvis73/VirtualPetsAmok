using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class VirtualPetShelterTests
    {
        [Fact]
        public void Does_FeedAllPetsDinner_Reduce_All_HungerLevels_To_Zero()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());


            petShelter.FeedAllPetsDinner();

            Assert.Equal(0, petShelter.shelteredPets[0].HungerLevel);
            Assert.Equal(0, petShelter.shelteredPets[1].HungerLevel);
            Assert.Equal(0, petShelter.shelteredPets[2].HungerLevel);

        }
        [Fact]
        public void Does_TakeAllPetsToDoctor_Increase_All_HealthLevels_To_Ten()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());


            petShelter.TakeAllPetsToDoctor();

            Assert.Equal(10, petShelter.shelteredPets[0].HealthLevel);
            Assert.Equal(10, petShelter.shelteredPets[1].HealthLevel);
            Assert.Equal(10, petShelter.shelteredPets[2].HealthLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Increase_All_HungerLevels_By_2()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());


            petShelter.PlayWithAllPets();

            Assert.Equal(5, petShelter.shelteredPets[0].HungerLevel);
            Assert.Equal(5, petShelter.shelteredPets[1].HungerLevel);
            Assert.Equal(5, petShelter.shelteredPets[2].HungerLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Increase_All_HealthLevels_By_1()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());


            petShelter.PlayWithAllPets();

            Assert.Equal(8, petShelter.shelteredPets[0].HealthLevel);
            Assert.Equal(8, petShelter.shelteredPets[1].HealthLevel);
            Assert.Equal(8, petShelter.shelteredPets[2].HealthLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Decrease_All_BoredomLevels_By_2()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());
            petShelter.shelteredPets.Add(new OrganicPet());

            petShelter.PlayWithAllPets();

            Assert.Equal(1, petShelter.shelteredPets[0].BoredomLevel);
            Assert.Equal(1, petShelter.shelteredPets[1].BoredomLevel);
            Assert.Equal(1, petShelter.shelteredPets[2].BoredomLevel);
        }
        /*[Fact]
        public void Does_AddPetToShelter_Change_Name()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();

            petShelter.AddPetToShelter();

            Assert.Equal()
        }*/
    }
}
