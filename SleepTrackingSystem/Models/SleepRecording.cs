using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepTrackingSystem.Models
{
    public class SleepRecording
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan SleepStart { get; set; }
        public TimeSpan SleepEnd { get; set; }
        public double SleepDuration {  get; set; }
        public string? SleepQuality { get; set; }

        public  User? User { get; set; }

    }
}
