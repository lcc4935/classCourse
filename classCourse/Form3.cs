using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classCourseLibrary;

namespace classCourse
{
    public partial class PersonalInfo : Form
    {
        BasicInfo formInfo;
        public PersonalInfo(BasicInfo basicInfo, Form parentForm)
        {
            InitializeComponent();

            this.formInfo = basicInfo;


            this.minorCheckBox.CheckedChanged += new EventHandler(this.minorCheckBox__CheckedChanged);

            this.nameTextBox.TextChanged += new EventHandler(NameTextBox__TextChanged);
            this.majorTextBox.TextChanged += new EventHandler(MajorTextBox__TextChanged);
            this.immersionTextBox.TextChanged += new EventHandler(ImmersionTextBox__TextChanged);
            this.minorTextBox.TextChanged += new EventHandler(MinorTextBox__TextChanged);
            this.creditTextBox.TextChanged += new EventHandler(CreditTextBox__TextChanged);

            this.okButton.Click += new EventHandler(OkButton__Click);

            this.minorLabel.Visible = false;
            this.minorTextBox.Visible = false;

            
            this.nameTextBox.Text = basicInfo.name; //System.NullReferenceException: 'Object reference not set to an instance of an object.'  basicInfo was null.
            this.majorTextBox.Text = basicInfo.major;
            this.immersionTextBox.Text = basicInfo.immersion;
            this.minorTextBox.Text = basicInfo.minor;
            this.creditTextBox.Text = basicInfo.credit;

            this.Show();

        }

        //Checkboxes
        private void minorCheckBox__CheckedChanged(object sender, EventArgs e) //LC
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                this.minorLabel.Visible = true;
                this.minorTextBox.Visible = true;
            }
            else
            {
                this.minorLabel.Visible = false;
                this.minorTextBox.Visible = false;
            }

        }


        //Text Boxes
        private void NameTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        private void MajorTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        private void ImmersionTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        private void MinorTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        private void CreditTextBox__TextChanged(object sender, EventArgs e)  //LC
        {
            TextBox tb = (TextBox)sender;
        }

        //Buttons

        private void OkButton__Click(object sender, EventArgs e)  //LC
        {
            this.Hide();

        }

    }
}
