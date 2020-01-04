using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class LoginLog
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public string Chrome { get; set; }
    }
}
