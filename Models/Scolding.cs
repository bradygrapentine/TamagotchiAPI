using System;
namespace TamagotchiAPI.Models
{
    public class Scolding
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public int PetId { get; set; }
        public Pet pet { get; set; }
    }
}