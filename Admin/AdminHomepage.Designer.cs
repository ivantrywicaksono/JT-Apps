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
            appTitle = new Label();
            btnNewsletter = new Button();
            button1 = new Button();
            addNewsletterForm1 = new AddNewsletterForm();
            panelTitle = new Panel();
            btnPaket = new Button();
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
            flpanelDashboard.Size = new Size(200, 681);
            flpanelDashboard.TabIndex = 0;
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(832, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // addNewsletterForm1
            // 
            addNewsletterForm1.AutoSize = true;
            addNewsletterForm1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addNewsletterForm1.Location = new Point(328, 126);
            addNewsletterForm1.Name = "addNewsletterForm1";
            addNewsletterForm1.Size = new Size(373, 160);
            addNewsletterForm1.TabIndex = 2;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(appTitle);
            panelTitle.Location = new Point(3, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(197, 100);
            panelTitle.TabIndex = 3;
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
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 681);
            Controls.Add(addNewsletterForm1);
            Controls.Add(button1);
            Controls.Add(flpanelDashboard);
            Name = "AdminHomepage";
            Text = "Form1";
            Load += AdminHomepage_Load;
            flpanelDashboard.ResumeLayout(false);
            flpanelDashboard.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpanelDashboard;
        private Button button1;
        private Label appTitle;
        private Button btnNewsletter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AddNewsletterForm addNewsletterForm1;
        private Panel panelTitle;
        private Button btnPaket;
    }
}