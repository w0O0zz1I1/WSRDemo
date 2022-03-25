using System;

namespace WSRDemo.Models
{
    public class CardClient
    {
        public DateTime DateCreated { get; set; }
        public decimal Price { get; set; }
        public int WorkoutsAmount { get; set; }
        public int PassedWorkouts { get; set; }
        public DateTime LastWorkoutDateTime { get; set; }
    }
}
