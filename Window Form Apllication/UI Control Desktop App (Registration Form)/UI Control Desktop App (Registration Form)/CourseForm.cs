using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Control_Desktop_App__Registration_Form_
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            string course = courseComboBox.Text;
            bool selected = false;

            foreach (ListViewItem item in courseListView.Items)
            {
                if(course == item.Text)
                {
                    MessageBox.Show(course + " is already selected!");
                    selected = true;
                    break;
                }
            }
            if (!selected) { courseListView.Items.Add(course); };
        }
    }
}
