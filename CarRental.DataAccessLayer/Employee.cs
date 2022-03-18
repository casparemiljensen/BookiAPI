using System;

namespace BookiAPI.DataAccessLayer.Model
{
    /// <summary>
    /// A class representing a car
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"[{Id}] - {Name} {Phone}";
        }
    }
}