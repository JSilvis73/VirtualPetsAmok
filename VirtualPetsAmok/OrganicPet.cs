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

            if (this.BoredomLevel > 2)
            {
                this.BoredomLevel -= 2;
            }
            else
            {
                this.BoredomLevel = 0;
            }

            if (this.HealthLevel <= 9)
            {
                this.HealthLevel += 1;
            }
            else
            {
                this.HealthLevel = 10;
            }

            if (this.HungerLevel < 8)
            {
                this.HungerLevel += 2;
            }
            else
            {
                this.HungerLevel = 10;
            }
        }
        public override void TimeLapse()
        {
            if(this.BoredomLevel < 8)
            {
                this.BoredomLevel += 2;
            }
            else
            {
                this.BoredomLevel = 10;
            }

            if (this.HealthLevel >= 1)
            {
                this.HealthLevel -= 1;
            }
            else
            {
                this.HealthLevel = 0;
            }

            if (this.HungerLevel < 8)
            {
                this.HungerLevel =+ 2;
            }
            else
            {
                this.HungerLevel = 10;
            }
        }
    }
}
