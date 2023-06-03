using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class AddNewsletterForm : UserControl
    {
        public AddNewsletterForm()
        {
            InitializeComponent();
        }

        public Models.Newsletter GetNewsletter()
        {
            Models.Newsletter newNewsletter = new Models.Newsletter
            (
                tbNewsTitle.Text,
                tbNewsDescription.Text,
                tbNewsLink.Text
            );

            return newNewsletter;
        }
    }
}
