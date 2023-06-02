namespace Admin
{
    partial class AdminHomepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpanelDashboard = new FlowLayoutPanel();
            panelTitle = new Panel();
            appTitle = new Label();
            btnNewsletter = new Button();
            btnPaket = new Button();
            btnAddNews = new Button();
            addNewsletterForm = new AddNewsletterForm();
            flpanelNewsletters = new FlowLayoutPanel();
            btnNewsLetter1 = new Button();
            btnNewsLetter2 = new Button();
            btnNewsLetter3 = new Button();
            dataGridView1 = new DataGridView();
            flpanelDashboard.SuspendLayout();
            panelTitle.SuspendLayout();
            flpanelNewsletters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flpanelDashboard
            // 
            flpanelDashboard.Controls.Add(panelTitle);
            flpanelDashboard.Controls.Add(btnNewsletter);
            flpanelDashboard.Controls.Add(btnPaket);
            flpanelDashboard.Dock = DockStyle.Left;
            flpanelDashboard.FlowDirection = FlowDirection.TopDown;
            flpanelDashboard.Location = new Point(0, 0);
            flpanelDashboard.Name = "flpanelDashboard";
            flpanelDashboard.Size = new Size(200, 681);
            flpanelDashboard.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(appTitle);
            panelTitle.Location = new Point(3, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(197, 100);
            panelTitle.TabIndex = 3;
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            appTitle.Location = new Point(44, 35);
            appTitle.Margin = new Padding(3, 0, 3, 8);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(99, 34);
            appTitle.TabIndex = 0;
            appTitle.Text = "JT-Apps";
            // 
            // btnNewsletter
            // 
            btnNewsletter.AutoSize = true;
            btnNewsletter.Dock = DockStyle.Top;
            btnNewsletter.FlatAppearance.BorderSize = 0;
            btnNewsletter.FlatStyle = FlatStyle.Flat;
            btnNewsletter.Location = new Point(0, 106);
            btnNewsletter.Margin = new Padding(0);
            btnNewsletter.Name = "btnNewsletter";
            btnNewsletter.Padding = new Padding(0, 12, 0, 12);
            btnNewsletter.Size = new Size(203, 49);
            btnNewsletter.TabIndex = 2;
            btnNewsletter.Text = "Newsletter";
            btnNewsletter.UseVisualStyleBackColor = true;
            btnNewsletter.Click += btnNewsletter_Click;
            // 
            // btnPaket
            // 
            btnPaket.AutoSize = true;
            btnPaket.Dock = DockStyle.Top;
            btnPaket.FlatAppearance.BorderSize = 0;
            btnPaket.FlatStyle = FlatStyle.Flat;
            btnPaket.Location = new Point(0, 155);
            btnPaket.Margin = new Padding(0);
            btnPaket.Name = "btnPaket";
            btnPaket.Padding = new Padding(0, 12, 0, 12);
            btnPaket.Size = new Size(203, 49);
            btnPaket.TabIndex = 4;
            btnPaket.Text = "Paket";
            btnPaket.UseVisualStyleBackColor = true;
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
            btnAddNews.Click += btnAddNews_Click;
            // 
            // addNewsletterForm
            // 
            addNewsletterForm.Anchor = AnchorStyles.Top;
            addNewsletterForm.AutoSize = true;
            addNewsletterForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addNewsletterForm.Location = new Point(361, 65);
            addNewsletterForm.Name = "addNewsletterForm";
            addNewsletterForm.Size = new Size(373, 160);
            addNewsletterForm.TabIndex = 2;
            addNewsletterForm.Visible = false;
            // 
            // flpanelNewsletters
            // 
            flpanelNewsletters.Controls.Add(btnNewsLetter1);
            flpanelNewsletters.Controls.Add(btnNewsLetter2);
            flpanelNewsletters.Controls.Add(btnNewsLetter3);
            flpanelNewsletters.Controls.Add(btnAddNews);
            flpanelNewsletters.Location = new Point(265, 65);
            flpanelNewsletters.Name = "flpanelNewsletters";
            flpanelNewsletters.Size = new Size(774, 214);
            flpanelNewsletters.TabIndex = 3;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(774, 150);
            dataGridView1.TabIndex = 4;
            // 
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(dataGridView1);
            Controls.Add(addNewsletterForm);
            Controls.Add(flpanelNewsletters);
            Controls.Add(flpanelDashboard);
            Name = "AdminHomepage";
            Text = "Admin Homepage";
            Load += AdminHomepage_Load;
            flpanelDashboard.ResumeLayout(false);
            flpanelDashboard.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            flpanelNewsletters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpanelDashboard;
        private Button btnAddNews;
        private Label appTitle;
        private Button btnNewsletter;
        private AddNewsletterForm addNewsletterForm;
        private Panel panelTitle;
        private Button btnPaket;
        private FlowLayoutPanel flpanelNewsletters;
        private Button btnNewsLetter1;
        private Button btnNewsLetter2;
        private Button btnNewsLetter3;
        private DataGridView dataGridView1;
    }
}