using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Exhibition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Src { get; set; }
        public string Synopsis { get; set; }
        public DateTime Time { get; set; }
        public bool? IsShow { get; set; }
    }
}
