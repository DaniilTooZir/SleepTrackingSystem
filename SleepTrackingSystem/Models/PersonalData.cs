using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepTrackingSystem.Models
{
    public class PersonalData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public User? User { get; set; }
    }
}
