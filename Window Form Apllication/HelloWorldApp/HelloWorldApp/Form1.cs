namespace HelloWorldApp
{
    public partial class HelloAppUI : Form
    {
        public HelloAppUI()
        {
            InitializeComponent();
        }

        private void HelloAppUI_Load(object sender, EventArgs e)
        {

        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            MessageBox.Show("Hello " + name, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
