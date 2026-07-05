namespace UI_Control_Desktop_App__Registration_Form_
{
    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string department = departmentComboBox.Text;
            string gender = "";
            if (maleRadioButton.Checked) { gender = maleRadioButton.Text; }
            else if (femaleRadioButton.Checked) { gender = femaleRadioButton.Text; }
            List<string> skills = new List<string>();
            if (cppCheckBox.Checked) skills.Add("C++");
            if (pythonCheckBox.Checked) skills.Add("Python");
            if (csharpCheckBox.Checked) skills.Add("C#");

            if (name == "")
            {
                MessageBox.Show("Please enter the name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (department == "---Select---")
            {
                MessageBox.Show("Please select the department", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (gender == "")
            {
                MessageBox.Show("Please select the gender", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(skills.Count == 0)
            {
                MessageBox.Show("Please select at least one skills", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Registration Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameTextBox.Clear();
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = false;
                cppCheckBox.Checked = false;
                pythonCheckBox.Checked = false;
                csharpCheckBox.Checked = false;

                CourseForm cf = new CourseForm();
                cf.Show();

                this.Hide();
            }

        }

        private void Registration_form_Load(object sender, EventArgs e)
        {
            List<string> department = new List<string>();
            department.Add("---Select---");
            department.Add("CSE");
            department.Add("EEE");
            department.Add("IPE");
            department.Add("BBA");

            departmentComboBox.DataSource = department;
        }
    }
}
