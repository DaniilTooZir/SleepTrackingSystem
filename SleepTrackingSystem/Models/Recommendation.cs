using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepTrackingSystem.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string? RecommendText { get; set; }
        public string? RecommendType { get; set; }
    }
}
