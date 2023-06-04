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
    public partial class AddNewsletterForm : Form
    {
        readonly Models.NewsletterContext newsletterContext = new();
        public AddNewsletterForm()
        {
            InitializeComponent();
        }

        public Models.Newsletter GetNewsletter()
        {
            string description = tbNewsDescription.Text;

            if (string.IsNullOrWhiteSpace(description))
            {
                description = null;
            }

            Models.Newsletter newNewsletter = new(
                tbNewsTitle.Text,
                description,
                tbNewsLink.Text
            );

            return newNewsletter;
        }

        private void ResetForm()
        {
            tbNewsTitle.Text = null;
            tbNewsDescription.Text = null;
            tbNewsLink.Text = null;
        }

        private void BtnCancelNews_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAddNews_Click(object sender, EventArgs e)
        {
            Models.Newsletter newsletter = GetNewsletter();

            if (string.IsNullOrWhiteSpace(tbNewsTitle.Text))
            {
                MessageBox.Show("Mohon isi judul");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNewsLink.Text))
            {
                MessageBox.Show("Mohon isi link");
                return;
            }

            if (newsletterContext.Insert(newsletter))
            {
                ResetForm();
                newsletterContext.ReadAll();
                MessageBox.Show(
                    "Title: " + newsletterContext.Newsletters.Last().Title +
                    "\nDescription: " + newsletterContext.Newsletters.Last().Description +
                    "\nLink: " + newsletterContext.Newsletters.Last().Link +
                    "\nID: " + newsletterContext.Newsletters.Last().Id
                );
            }
            else
                MessageBox.Show("Gagal");

            this.Close();
        }
    }
}
