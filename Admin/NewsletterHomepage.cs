using Admin.Models;
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
        Models.NewsletterContext newsletterContext = new();
        public NewsletterHomepage()
        {
            InitializeComponent();
        }

        private void BtnAddNews_Click(object sender, EventArgs e)
        {
            using AddNewsletterForm addNewsletterForm = new();
            addNewsletterForm.ShowDialog();

            ShowItems();
        }

        private void NewsletterHomepage_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            newsletterContext.ReadAll();
            List<Newsletter> newsletters;
            newsletters = newsletterContext.Newsletters;

            flpanelNewsletters.Controls.Clear();

            foreach (var newsletter in newsletters)
            {
                Button newsItem = new NewsletterItem().createItem();
                newsItem.Text = newsletter.Title;
                flpanelNewsletters.Controls.Add(newsItem);
            }

            flpanelNewsletters.Controls.Add(btnAddNews);
        }
    }
}
