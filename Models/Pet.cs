using System;
using System.Collections.Generic;
namespace TamagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }
        public DateTime LastInteractedWithDate { get; set; }
        public Boolean IsDead
        {
            get
            {
                if (LastInteractedWithDate.AddDays(3) <= DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
