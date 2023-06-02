using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Models
{
    internal class Newsletter
    {
        private string? _newsId;
        private string _newsTitle;
        private string _newsDescription;
        private string _newsLink;

        public Newsletter(string newsId, string newsTitle, string newsDescription, string newsLink)
        {
            _newsId = newsId;
            _newsTitle = newsTitle;
            _newsDescription = newsDescription;
            _newsLink = newsLink;
        }
    }
}
