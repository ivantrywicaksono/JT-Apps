namespace Admin
{
    partial class CreateNewsletterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNewsTitle = new TextBox();
            lbNewsTitle = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            btnAddNews = new Button();
            SuspendLayout();
            // 
            // tbNewsTitle
            // 
            tbNewsTitle.BackColor = SystemColors.Window;
            tbNewsTitle.BorderStyle = BorderStyle.FixedSingle;
            tbNewsTitle.Location = new Point(88, 24);
            tbNewsTitle.Name = "tbNewsTitle";
            tbNewsTitle.Size = new Size(246, 23);
            tbNewsTitle.TabIndex = 0;
            // 
            // lbNewsTitle
            // 
            lbNewsTitle.AutoSize = true;
            lbNewsTitle.Location = new Point(44, 26);
            lbNewsTitle.Name = "lbNewsTitle";
            lbNewsTitle.Size = new Size(35, 15);
            lbNewsTitle.TabIndex = 1;
            lbNewsTitle.Text = "Judul";
            lbNewsTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(88, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 55);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Deskripsi";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(88, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 84);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Link";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddNews
            // 
            btnAddNews.Cursor = Cursors.Hand;
            btnAddNews.Location = new Point(259, 121);
            btnAddNews.Name = "btnAddNews";
            btnAddNews.Size = new Size(75, 23);
            btnAddNews.TabIndex = 2;
            btnAddNews.Text = "Add";
            btnAddNews.UseVisualStyleBackColor = true;
            // 
            // CreateNewsletterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNews);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNewsTitle);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tbNewsTitle);
            Name = "CreateNewsletterForm";
            Text = "Add Newsletter Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNewsTitle;
        private Label lbNewsTitle;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button btnAddNews;
    }
}