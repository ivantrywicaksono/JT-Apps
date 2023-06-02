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
            label2 = new Label();
            label1 = new Label();
            lbNewsTitle = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 97);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "Link";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 68);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Deskripsi";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(124, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(124, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 4;
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNewsTitle);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tbNewsTitle);
            Name = "AddNewsletterForm";
            Size = new Size(783, 319);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNews;
        private Label label2;
        private Label label1;
        private Label lbNewsTitle;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox tbNewsTitle;
    }
}
