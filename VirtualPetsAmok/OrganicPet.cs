using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class OrganicPet : VirtualPet
    {
        public int HealthLevel { get; set; }
        public int HungerLevel { get; set; }
        public OrganicPet() : base()
        {
            HealthLevel = 7;
            HungerLevel = 3;
        }
        public override void CreatePet()
        {
            base.CreatePet();
        }
        public override void FeedPetDinner()
        {
            this.HungerLevel = 0;
        }
        public override void TakePetToDoctor()
        {
            this.HealthLevel = 10;
        }
        public override void PlayWithPet()
        {

            if (BoredomLevel > 2)
            {
                BoredomLevel -= 2;
            }
            else
            {
                BoredomLevel = 0;
            }

            if (HealthLevel < 10)
            {
                HealthLevel += 1;
            }
            else
            {
                HealthLevel = 10;
            }

            if (HungerLevel < 8)
            {
                HungerLevel += 2;
            }
            else
            {
                HungerLevel = 10;
            }
        }
        public override void TimeLapse()
        {
            if(BoredomLevel < 8)
            {
                BoredomLevel += 2;
            }
            else
            {
                BoredomLevel = 10;
            }

            if (HealthLevel >= 1)
            {
                HealthLevel -= 1;
            }
            else
            {
                HealthLevel = 0;
            }

            if (HungerLevel < 8)
            {
                HungerLevel =+ 2;
            }
            else
            {
                HungerLevel = 10;
            }
        }
    }
}
