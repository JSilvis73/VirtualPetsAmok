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
        /*[Fact]
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
        }*/
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
        /*[Fact]
        public void Does_FeedPetSnack_Reduce_Hunger_By_Two()
        {
            OrganicPet myOrganicPet = new OrganicPet();
            myOrganicPet.HungerLevel = 5;

            myOrganicPet.FeedPetSnack();

            Assert.Equal(3, myOrganicPet.HungerLevel);
        }*/
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
        /*[Fact]
        public void Does_ChoosePetFromList_Return_Correct_Index()
        {
            VirtualPetShelter petShelter = new VirtualPetShelter();
            int userInput = 2;

            petShelter.ChoosePetFromList(userInput);

            Assert.Equal(1, userInput);
        }*/
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
    }
}
