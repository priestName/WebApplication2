using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ContentList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
        public bool? IsShow { get; set; }
        public string Label { get; set; }
        public DateTime Time { get; set; }
        public DateTime? LastTime { get; set; }
        public string Author { get; set; }
    }
}
