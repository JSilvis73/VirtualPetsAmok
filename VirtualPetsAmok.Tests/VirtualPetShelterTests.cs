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
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());


            petShelter.FeedAllPetsDinner();

            Assert.Equal(0, petShelter.shelteredPets[0].HungerLevel);
            Assert.Equal(0, petShelter.shelteredPets[1].HungerLevel);
            Assert.Equal(0, petShelter.shelteredPets[2].HungerLevel);

        }
        [Fact]
        public void Does_TakeAllPetsToDoctor_Increase_All_HealthLevels_To_Ten()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());


            petShelter.TakeAllPetsToDoctor();

            Assert.Equal(10, petShelter.shelteredPets[0].HealthLevel);
            Assert.Equal(10, petShelter.shelteredPets[1].HealthLevel);
            Assert.Equal(10, petShelter.shelteredPets[2].HealthLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Increase_All_HungerLevels_By_2()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());


            petShelter.PlayWithAllPets();

            Assert.Equal(5, petShelter.shelteredPets[0].HungerLevel);
            Assert.Equal(5, petShelter.shelteredPets[1].HungerLevel);
            Assert.Equal(5, petShelter.shelteredPets[2].HungerLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Increase_All_HealthLevels_By_1()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());


            petShelter.PlayWithAllPets();

            Assert.Equal(8, petShelter.shelteredPets[0].HealthLevel);
            Assert.Equal(8, petShelter.shelteredPets[1].HealthLevel);
            Assert.Equal(8, petShelter.shelteredPets[2].HealthLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Decrease_All_BoredomLevels_By_2()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());

            petShelter.PlayWithAllPets();

            Assert.Equal(1, petShelter.shelteredPets[0].BoredomLevel);
            Assert.Equal(1, petShelter.shelteredPets[1].BoredomLevel);
            Assert.Equal(1, petShelter.shelteredPets[2].BoredomLevel);
        }

        [Fact]
        public void Does_ChoosePetFromList_Return_Correct_Index()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());
            petShelter.shelteredPets.Add(new VirtualPet());
            int userInput = 2;
            int index = userInput - 1;

            VirtualPet selectedPet = petShelter.ChoosePetFromList(userInput);

            Assert.Equal(index, petShelter.shelteredPets.IndexOf(selectedPet));
        }
    }
}
