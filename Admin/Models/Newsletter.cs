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

        public Newsletter(string title, string description, string link)
        {
            Title = title;
            Description = description;
            Link = link;
        }

        public Newsletter(string title, string description, string link, int id) : this(title, description, link)
            => this.Id = id;

    }
}
