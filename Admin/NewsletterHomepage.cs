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
    public partial class NewsletterHomepage : UserControl
    {
        public NewsletterHomepage()
        {
            InitializeComponent();
        }

        private void BtnAddNews_Click(object sender, EventArgs e)
        {
            using AddNewsletterForm addNewsletterForm = new();
            addNewsletterForm.ShowDialog();
        }

        private void NewsletterHomepage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
