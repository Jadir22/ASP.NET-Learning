namespace User_Input_From_TextBox_In_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnShowFullName_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string middleName = middleNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();

            if(firstName == "")
            {
                MessageBox.Show("Please Enter the First Name");
                firstNameTextBox.Focus();
                return;
            }
            else if(middleName == "")
            {
                MessageBox.Show("Please Enter the middle Name");
                middleNameTextBox.Focus();
                return;
            }
            else if(lastName == "")
            {
                MessageBox.Show("Please Enter the last Name");
                lastNameTextBox.Focus();
                return;
            }
            else
            {
                string fullName = firstName + " " + middleName + " " + lastName;

                fullNameTextBox.Text = fullName;

                firstNameTextBox.Text = "";
                middleNameTextBox.Clear();
                lastNameTextBox.Clear();
            }
        }
    }
}
