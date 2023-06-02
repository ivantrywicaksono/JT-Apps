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

        private void tbNewsTitle_TextChanged(object sender, EventArgs e)
        {

        }

        //public Models.Newsletter GetNewsletter()
        //{
        //    Models.Newsletter newNewsletter = new Models.Newsletter
        //    (
        //        null,
        //        tbNewsTitle.Text,
        //        tbNewsDescription.Text,
        //        tbNewsLink.Text
        //    );

        //    return newNewsletter;
        //}
    }
}
