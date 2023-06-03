namespace Admin
{
    partial class AddNewsletterForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddNews = new Button();
            lbNewsLink = new Label();
            lbNewsDescription = new Label();
            lbNewsTitle = new Label();
            tbNewsLink = new TextBox();
            tbNewsDescription = new TextBox();
            tbNewsTitle = new TextBox();
            SuspendLayout();
            // 
            // btnAddNews
            // 
            btnAddNews.Cursor = Cursors.Hand;
            btnAddNews.Location = new Point(295, 134);
            btnAddNews.Name = "btnAddNews";
            btnAddNews.Size = new Size(75, 23);
            btnAddNews.TabIndex = 9;
            btnAddNews.Text = "Add";
            btnAddNews.UseVisualStyleBackColor = true;
            // 
            // lbNewsLink
            // 
            lbNewsLink.AutoSize = true;
            lbNewsLink.Location = new Point(86, 97);
            lbNewsLink.Name = "lbNewsLink";
            lbNewsLink.Size = new Size(29, 15);
            lbNewsLink.TabIndex = 6;
            lbNewsLink.Text = "Link";
            lbNewsLink.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbNewsDescription
            // 
            lbNewsDescription.AutoSize = true;
            lbNewsDescription.Location = new Point(61, 68);
            lbNewsDescription.Name = "lbNewsDescription";
            lbNewsDescription.Size = new Size(54, 15);
            lbNewsDescription.TabIndex = 7;
            lbNewsDescription.Text = "Deskripsi";
            lbNewsDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbNewsTitle
            // 
            lbNewsTitle.AutoSize = true;
            lbNewsTitle.Location = new Point(80, 39);
            lbNewsTitle.Name = "lbNewsTitle";
            lbNewsTitle.Size = new Size(35, 15);
            lbNewsTitle.TabIndex = 8;
            lbNewsTitle.Text = "Judul";
            lbNewsTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbNewsLink
            // 
            tbNewsLink.BorderStyle = BorderStyle.FixedSingle;
            tbNewsLink.Location = new Point(124, 95);
            tbNewsLink.Name = "tbNewsLink";
            tbNewsLink.Size = new Size(246, 23);
            tbNewsLink.TabIndex = 3;
            // 
            // tbNewsDescription
            // 
            tbNewsDescription.BorderStyle = BorderStyle.FixedSingle;
            tbNewsDescription.Location = new Point(124, 66);
            tbNewsDescription.Name = "tbNewsDescription";
            tbNewsDescription.Size = new Size(246, 23);
            tbNewsDescription.TabIndex = 4;
            // 
            // tbNewsTitle
            // 
            tbNewsTitle.BackColor = SystemColors.Window;
            tbNewsTitle.BorderStyle = BorderStyle.FixedSingle;
            tbNewsTitle.Location = new Point(124, 37);
            tbNewsTitle.Name = "tbNewsTitle";
            tbNewsTitle.Size = new Size(246, 23);
            tbNewsTitle.TabIndex = 5;
            // 
            // AddNewsletterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddNews);
            Controls.Add(lbNewsLink);
            Controls.Add(lbNewsDescription);
            Controls.Add(lbNewsTitle);
            Controls.Add(tbNewsLink);
            Controls.Add(tbNewsDescription);
            Controls.Add(tbNewsTitle);
            Name = "AddNewsletterForm";
            Size = new Size(783, 319);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNews;
        private Label lbNewsLink;
        private Label lbNewsDescription;
        private Label lbNewsTitle;
        private TextBox tbNewsLink;
        private TextBox tbNewsDescription;
        private TextBox tbNewsTitle;
    }
}
