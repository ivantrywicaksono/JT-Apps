namespace Admin
{
    partial class NewsletterHomepage
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
            dataGridView1 = new DataGridView();
            flpanelNewsletters = new FlowLayoutPanel();
            btnNewsLetter1 = new Button();
            btnNewsLetter2 = new Button();
            btnNewsLetter3 = new Button();
            btnAddNews = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flpanelNewsletters.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(768, 150);
            dataGridView1.TabIndex = 6;
            // 
            // flpanelNewsletters
            // 
            flpanelNewsletters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpanelNewsletters.Controls.Add(btnNewsLetter1);
            flpanelNewsletters.Controls.Add(btnNewsLetter2);
            flpanelNewsletters.Controls.Add(btnNewsLetter3);
            flpanelNewsletters.Controls.Add(btnAddNews);
            flpanelNewsletters.Location = new Point(0, 0);
            flpanelNewsletters.Name = "flpanelNewsletters";
            flpanelNewsletters.Size = new Size(768, 214);
            flpanelNewsletters.TabIndex = 5;
            // 
            // btnNewsLetter1
            // 
            btnNewsLetter1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewsLetter1.BackColor = SystemColors.GrayText;
            btnNewsLetter1.BackgroundImageLayout = ImageLayout.None;
            btnNewsLetter1.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNewsLetter1.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnNewsLetter1.FlatStyle = FlatStyle.Flat;
            btnNewsLetter1.Location = new Point(3, 3);
            btnNewsLetter1.Name = "btnNewsLetter1";
            btnNewsLetter1.Size = new Size(250, 100);
            btnNewsLetter1.TabIndex = 2;
            btnNewsLetter1.Text = "Newsletter Thumbnail";
            btnNewsLetter1.UseVisualStyleBackColor = false;
            // 
            // btnNewsLetter2
            // 
            btnNewsLetter2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewsLetter2.BackColor = SystemColors.GrayText;
            btnNewsLetter2.BackgroundImageLayout = ImageLayout.None;
            btnNewsLetter2.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNewsLetter2.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnNewsLetter2.FlatStyle = FlatStyle.Flat;
            btnNewsLetter2.Location = new Point(259, 3);
            btnNewsLetter2.Name = "btnNewsLetter2";
            btnNewsLetter2.Size = new Size(250, 100);
            btnNewsLetter2.TabIndex = 3;
            btnNewsLetter2.Text = "Newsletter Thumbnail";
            btnNewsLetter2.UseVisualStyleBackColor = false;
            // 
            // btnNewsLetter3
            // 
            btnNewsLetter3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewsLetter3.BackColor = SystemColors.GrayText;
            btnNewsLetter3.BackgroundImageLayout = ImageLayout.None;
            btnNewsLetter3.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNewsLetter3.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnNewsLetter3.FlatStyle = FlatStyle.Flat;
            btnNewsLetter3.Location = new Point(515, 3);
            btnNewsLetter3.Name = "btnNewsLetter3";
            btnNewsLetter3.Size = new Size(250, 100);
            btnNewsLetter3.TabIndex = 4;
            btnNewsLetter3.Text = "Newsletter Thumbnail";
            btnNewsLetter3.UseVisualStyleBackColor = false;
            // 
            // btnAddNews
            // 
            btnAddNews.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNews.BackColor = Color.Transparent;
            btnAddNews.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnAddNews.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAddNews.FlatStyle = FlatStyle.Flat;
            btnAddNews.Location = new Point(3, 109);
            btnAddNews.Name = "btnAddNews";
            btnAddNews.Size = new Size(250, 100);
            btnAddNews.TabIndex = 1;
            btnAddNews.Text = "New +";
            btnAddNews.UseVisualStyleBackColor = false;
            btnAddNews.Click += BtnAddNews_Click;
            // 
            // NewsletterHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(dataGridView1);
            Controls.Add(flpanelNewsletters);
            Name = "NewsletterHomepage";
            Size = new Size(771, 373);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flpanelNewsletters.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel flpanelNewsletters;
        private Button btnNewsLetter1;
        private Button btnNewsLetter2;
        private Button btnNewsLetter3;
        private Button btnAddNews;
    }
}
