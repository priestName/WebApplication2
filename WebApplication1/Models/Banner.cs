using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public bool IsShow { get; set; }
        public DateTime Time { get; set; }
    }
}
