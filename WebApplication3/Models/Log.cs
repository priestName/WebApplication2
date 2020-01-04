using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Count { get; set; }
        public DateTime Time { get; set; }
    }
}
