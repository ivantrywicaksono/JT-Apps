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
            newsletterHomepage = new NewsletterHomepage();
            flpanelDashboard.SuspendLayout();
            panelTitle.SuspendLayout();
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
            flpanelDashboard.Size = new Size(200, 495);
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
            btnNewsletter.Click += BtnNewsletter_Click;
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
            // newsletterHomepage
            // 
            newsletterHomepage.AutoSize = true;
            newsletterHomepage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newsletterHomepage.Location = new Point(206, 3);
            newsletterHomepage.Name = "newsletterHomepage";
            newsletterHomepage.Size = new Size(771, 373);
            newsletterHomepage.TabIndex = 3;
            newsletterHomepage.Visible = false;
            // 
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1011, 495);
            Controls.Add(newsletterHomepage);
            Controls.Add(flpanelDashboard);
            Name = "AdminHomepage";
            Text = "Admin Homepage";
            flpanelDashboard.ResumeLayout(false);
            flpanelDashboard.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpanelDashboard;
        private Label appTitle;
        private Button btnNewsletter;
        private Panel panelTitle;
        private Button btnPaket;
        private NewsletterHomepage newsletterHomepage;
    }
}