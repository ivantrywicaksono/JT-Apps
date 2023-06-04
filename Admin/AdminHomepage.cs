namespace Admin
{
    public partial class AdminHomepage : Form
    {
        public AdminHomepage()
        {
            InitializeComponent();
        }

        private void BtnNewsletter_Click(object sender, EventArgs e)
        {
            newsletterHomepage.Show();
        }
    }
}