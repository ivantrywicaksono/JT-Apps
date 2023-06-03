using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Newsletter
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Link { get; set; }
        public int Id { get; set; }

        public Newsletter(string title, string link)
        {
            Title = title;
            Link = link;
        }

        public Newsletter(string title, string description, string link) : this(title, link)
            => Description = description;
    }
}
