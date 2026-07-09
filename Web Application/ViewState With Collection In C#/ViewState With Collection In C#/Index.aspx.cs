using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_With_Collection_In_C_
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        List<string>names = new List<string>();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (ViewState["name"] != null)
            {
                names = (List<string>)ViewState["name"];
            }
            names.Add(name);
            ViewState["name"] = names;

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            names = (List<string>)ViewState["name"];
            nameListBox.Items.Clear();

            foreach(var data in names)
            {
                nameListBox.Items.Add(data);
            }
        }
    }
}