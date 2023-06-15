using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Admin.Models
{
    public class NewsletterItem
    {
        Button newsItem = new();

        public NewsletterItem()
        {
            newsItem.BackColor = SystemColors.GrayText;
            newsItem.BackgroundImageLayout = ImageLayout.None;
            newsItem.FlatAppearance.MouseDownBackColor = Color.DimGray;
            newsItem.FlatAppearance.MouseOverBackColor = Color.Silver;
            newsItem.FlatStyle = FlatStyle.Flat;
            newsItem.Size = new Size(250, 100);
            newsItem.UseVisualStyleBackColor = false;
            newsItem.Click += NewsItemClick;
        }
        
        public Button CreateItem()
        {
            return newsItem;
        }

        public void NewsItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Haloooo");
        }
    }
}
