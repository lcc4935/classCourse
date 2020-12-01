using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classCourse
{
    public partial class AddEditClass : Form
    {
        public AddEditClass()
        {
            InitializeComponent();

            this.newClassCreditComboBox.SelectedIndexChanged += new EventHandler(NewClassCreditComboBox__SelectedIndexChanged);
            this.newClassTypeComboBox.SelectedIndexChanged += new EventHandler(NewClassTypeComboBox__SelectedIndexChanged);

            this.newDepartmentTextBox.TextChanged += new EventHandler(NewDepartmentTextBox__TextChanged);
            this.newCourseCodeTextBox.TextChanged += new EventHandler(NewCourseCodeTextBox__TextChanged);
            this.newClassNameTextBox.TextChanged += new EventHandler(NewClassNameTextBox__TextChanged);

            this.submitButton.Click += new EventHandler(SubmitButton__Click);
        }

        //Comboboxes
        private void NewClassCreditComboBox__SelectedIndexChanged(object sender, EventArgs e) //LC
        {
            ComboBox cb = (ComboBox)sender;
        }

        private void NewClassTypeComboBox__SelectedIndexChanged(object sender, EventArgs e) //LC
        {
            ComboBox cb = (ComboBox)sender;
        }

        //Textboxes
        private void NewDepartmentTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        private void NewCourseCodeTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        private void NewClassNameTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        //Buttons

        private void SubmitButton__Click(object sender, EventArgs e)  //LC
        {
            this.Hide();
        }

        private void gradeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gradeCheckBox.Checked) {
                lblLetterGrade.Show();
                txtGrade.Show();
            }
            else {
                lblLetterGrade.Hide();
                txtGrade.Hide();
            }
        }
    }
}
