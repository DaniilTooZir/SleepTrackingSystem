using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepTrackingSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
        public string? Email { get; set; }
        public byte[]? Photo { get; set; }
        public bool IsGuest { get; set; } = false;
    }
}
