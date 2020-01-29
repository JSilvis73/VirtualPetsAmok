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
    }
}
