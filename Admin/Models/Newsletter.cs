using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Newsletter
    {
        private string _newsTitle;
        private string _newsDescription;
        private string _newsLink;
        private int _newsId;

        public Newsletter(string newsTitle, string newsDescription, string newsLink, int newsId = 0)
        {
            _newsTitle = newsTitle;
            _newsDescription = newsDescription;
            _newsLink = newsLink;
            _newsId = newsId;
        }
    }
}
