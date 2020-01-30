using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class VirtualPetShelterTests
    {
        OrganicPet newOrganicPet;
        VirtualPetShelter petShelter;

        public VirtualPetShelterTests()
        {
            newOrganicPet = new OrganicPet();
            petShelter = new VirtualPetShelter();
        }
        
        [Fact]
        public void Does_FeedAllPetsDinner_Reduce_All_HungerLevels_To_Zero()
        {
            petShelter.allShelteredPets.Add(newOrganicPet);
            petShelter.allShelteredPets.Add(newOrganicPet);
            petShelter.allShelteredPets.Add(newOrganicPet);


            petShelter.FeedAllPetsDinner();

            Assert.Equal(0, petShelter.shelteredOrganicPets[0].HungerLevel);
            Assert.Equal(0, petShelter.shelteredOrganicPets[1].HungerLevel);
            Assert.Equal(0, petShelter.shelteredOrganicPets[2].HungerLevel);

        }
        [Fact]
        public void Does_TakeAllPetsToDoctor_Increase_All_HealthLevels_To_Ten()
        {

            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);


            petShelter.TakeAllPetsToDoctor();

            Assert.Equal(10, petShelter.shelteredOrganicPets[0].HealthLevel);
            Assert.Equal(10, petShelter.shelteredOrganicPets[1].HealthLevel);
            Assert.Equal(10, petShelter.shelteredOrganicPets[2].HealthLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Increase_All_HungerLevels_By_2()
        {

            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);


            petShelter.PlayWithAllPets();

            Assert.Equal(5, petShelter.shelteredOrganicPets[0].HungerLevel);
            Assert.Equal(5, petShelter.shelteredOrganicPets[1].HungerLevel);
            Assert.Equal(5, petShelter.shelteredOrganicPets[2].HungerLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Increase_All_HealthLevels_By_1()
        {

            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);


            petShelter.PlayWithAllPets();

            Assert.Equal(8, petShelter.shelteredOrganicPets[0].HealthLevel);
            Assert.Equal(8, petShelter.shelteredOrganicPets[1].HealthLevel);
            Assert.Equal(8, petShelter.shelteredOrganicPets[2].HealthLevel);
        }
        [Fact]
        public void Does_PlayWithAllPets_Decrease_All_BoredomLevels_By_2()
        {

            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);

            petShelter.PlayWithAllPets();

            Assert.Equal(1, petShelter.allShelteredPets[0].BoredomLevel);
            Assert.Equal(1, petShelter.allShelteredPets[1].BoredomLevel);
            Assert.Equal(1, petShelter.allShelteredPets[2].BoredomLevel);
        }

        [Fact]
        public void Does_ChoosePetFromList_Return_Correct_Index()
        {

            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            int userInput = 2;
            int index = userInput - 1;

            OrganicPet selectedPet = petShelter.ChoosePetFromOrganicList();

            Assert.Equal(index, petShelter.shelteredOrganicPets.IndexOf(selectedPet));
        }

        [Fact]
        public void Does_AdoptPet_Remove_Pets_From_List()
        {
            //arrange
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            petShelter.shelteredOrganicPets.Add(newOrganicPet);
            //act
            petShelter.AdoptOrganicPet();
            //assert
            Assert.Equal(2, petShelter.shelteredOrganicPets.Count);
        }
        
    }
}
