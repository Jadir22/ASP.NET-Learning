using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Define_Type_In_C_
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Person> names = new List<Person>();

            Person p1 = new Person();
            p1.firstName = firstNameTextBox.Text;
            p1.middleName = middleNameTextBox.Text;
            p1.lastName = lastNameTextBox.Text;

            if (ViewState["Person"] != null)
            {
                names = (List<Person>)ViewState["Person"];
            }
            names.Add(p1);
            ViewState["Person"] = names;

            firstNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty; 
            lastNameTextBox.Text = string.Empty;
        }

        protected void getFullButton_Click(object sender, EventArgs e)
        {
            //Person p1 = (Person)ViewState["Person"];

            List<Person> names = new List<Person>();
            names = (List<Person>)ViewState["Person"];

            foreach(var data in names)
            {
                string fullName = data.GetFullName();
                fullNameListBox.Items.Add(fullName);
            }
        }
    }
}