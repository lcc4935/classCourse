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

//classValue = department
//classNumber = courseCode
//in case I forget to switch them all over

namespace classCourse
{
    public partial class classCourse : Form
    {
        public classCourse() //LC
        {
            InitializeComponent();

            this.addClassButton.Click += new EventHandler(AddClassButton__Click);
            this.infoButton.Click += new EventHandler(InfoButton__Click);
            this.adElToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.otherToolStripButton.Click += new EventHandler(classToolStripButton__Click);


            /*
            this.nameTextBox.Text = basicInfo.name;
            this.majorTextBox.Text = basicInfo.major;
            this.minorTextBox.Text = basicInfo.minor;
            this.immersionTextBox.Text = basicInfo.immersion;

            this.newClassValueTextBox.Text = classInfo.department;
            this.newCourseCodeTextBox.Text = classInfo.courseCode;
            this.newClassNameTextBox.Text = classInfo.className;
            this.newClassTypeComboBox.SelectedItem = classInfo.classType;
            this.newClassCreditComboBox.SelectedItem = classInfo.classCredit;

            this.creditTextBox.Text = schedule.creditCount;
            */

            //this.label.Text = department, courseCode, className, creditCount;

        }


        //Buttons

        private void AddClassButton__Click(object sender, EventArgs e)  //LC
        {
            Button b = (Button)sender;
            Panel p = (Panel)b.Tag;

            AddEditClass addEditClass = new AddEditClass((ClassInfo)p.Tag, this);
            addEditClass.ShowDialog();
        }

        private void InfoButton__Click(object sender, EventArgs e)  //LC
        {
            Button b = (Button)sender;

            PersonalInfo personalInfo = new PersonalInfo((BasicInfo)b.Tag, this); //System.NullReferenceException: 'Object reference not set to an instance of an object.'   p was null
            personalInfo.ShowDialog();

            /*
            this.yourNameLabel.Text = BasicInfo.name;
            this.MMILabel.Text = BasicInfo.major, BasicInfo.minor, BasicInfo.immersion;
            this.yourCreditLabel.Text = BasicInfo.credit;
            */
        }

        private void classToolStripButton__Click(object sender, EventArgs e) // different sizes for class
        {
            ToolStripButton tbs = (ToolStripButton)sender;
            Panel p = (Panel)tbs.Tag;

            if (tbs.Checked)
            {
                tbs.Image = global::classCourse.Properties.Resources.plus;
                p.Size = new System.Drawing.Size(330, 27);
                tbs.Checked = false;
            }
            else
            {
                tbs.Image = global::classCourse.Properties.Resources.minus;
                p.Size = new System.Drawing.Size(330, 103); // System.NullReferenceException: 'Object reference not set to an instance of an object.'    p was null 
                tbs.Checked = true;
            }

            p.Refresh();
        }

        private void typesToolStripButton__Click(object sender, EventArgs e) // different sizes for class types - figure out based on number of classes
        {
            ToolStripButton tbs = (ToolStripButton)sender;
            Panel p = (Panel)tbs.Tag;

            if (tbs.Checked)
            {
                tbs.Image = global::classCourse.Properties.Resources.plus;
                p.Size = new System.Drawing.Size(193, 25); //edit size - smaller
                tbs.Checked = false;
            }
            else
            {
                tbs.Image = global::classCourse.Properties.Resources.minus;
                p.Size = new System.Drawing.Size(193, 211); //edit size - bigger
                tbs.Checked = true;
            }

            p.Refresh();
        }


        //labels

        /*
        private void ToolStripLabels__Click(object sender, EventArgs e) // when clicked = edit class  - want to come back to this after library
        {
            ToolStripLabel tsl = (ToolStripLabel)sender;
            Panel p = (Panel)tsl.Tag;

            AddEditClass cef = new AddEditClass((ClassInfo)p.Tag, this);
            cef.Visible = false;

            cef.ShowDialog();

            ClassInfo classInfo = cef.formClass;

            p.Controls.Clear();

            AddClassToPanel(ref p, classInfo);

            p.Refresh();
        }
        */
        

        //panels
        /*
        private void AddPanelToClassType(class class)  //LC
        {
            Panel panel = new System.Windows.Forms.Panel();
            //this.otherPanel = new System.Windows.Forms.Panel();

            AddClassToPanel(ref panel, class);
            
            this.FlowLayoutPanel.Controls.Add(panel); //flowLayoutPanel depends on class type
            this.FlowLayoutPanel.Controls.SetChildIndex(panel, flowLayourPanel.Controls.Count);
        }

        private void AddClassToPanel(ref Panel panel, Class class)  //LC
        {
            Label ClassTypeLabel = new System.Windows.Forms.Label();
            Label ClassCreditLabel = new System.Windows.Forms.Label();
            Label ClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip PanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton ToolStripButton = new System.Windows.Forms.ToolStripButton();

            // edit background based on class type

            // otherPanel
            // 
            Panel.Controls.Add(ClassTypeLabel);
            Panel.Controls.Add(ClassCreditLabel);
            Panel.Controls.Add(ClassNameLabel);
            Panel.Controls.Add(PanelToolStrip);
            Panel.Location = new System.Drawing.Point(3, 3);
            Panel.Name = "otherPanel";
            Panel.Size = new System.Drawing.Size(330, 27);
            Panel.TabIndex = 0;
            Panel.Tag = class;
            // 
            // otherClassTypeLabel
            // 
            ClassTypeLabel.AutoSize = true;
            ClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            ClassTypeLabel.Name = "otherClassTypeLabel";
            ClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            ClassTypeLabel.TabIndex = 3;
            ClassTypeLabel.Text = "Counts towards: " + class.classType; //library variables
            // 
            // otherClassCreditLabel
            // 
            ClassCreditLabel.AutoSize = true;
            ClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            ClassCreditLabel.Name = "otherClassCreditLabel";
            ClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            ClassCreditLabel.TabIndex = 2;
            ClassCreditLabel.Text = class.Credits; //library variables
            // 
            // otherClassNameLabel
            // 
            ClassNameLabel.AutoSize = true;
            ClassNameLabel.Location = new System.Drawing.Point(4, 29);
            ClassNameLabel.Name = "otherClassNameLabel";
            ClassNameLabel.Size = new System.Drawing.Size(60, 13);
            ClassNameLabel.TabIndex = 1;
            ClassNameLabel.Text = class.className; //library variables
            // 
            // otherPanelToolStrip
            // 
            PanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripButton,
            ToolStripLabel});
            PanelToolStrip.Location = new System.Drawing.Point(0, 0);
            PanelToolStrip.Name = "otherPanelToolStrip";
            PanelToolStrip.Size = new System.Drawing.Size(330, 25);
            PanelToolStrip.TabIndex = 0;
            PanelToolStrip.Text = "toolStrip1";
            // 
            // otherToolStripLabel
            // 
            ToolStripLabel.IsLink = true;
            ToolStripLabel.Name = "otherToolStripLabel";
            ToolStripLabel.Size = new System.Drawing.Size(134, 22);
            ToolStripLabel.Text = class.department, class.couseCode; //library variables
            ToolStripLabel.Click += new EventHandler(ToolStripLabel__Click); //potentially edit name of event after write this
            ToolStripLabel.Tag = panel;
            //
            // otherToolStripButton
            // 
            ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripButton.Name = "otherToolStripButton";
            ToolStripButton.Size = new System.Drawing.Size(23, 22);
            ToolStripButton.Text = "toolStripButton1";
            ToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            ToolStripButton.Tag = panel;
        }

        */

        /*
         * this.FlowLayoutPanel.Controls.Clear();
            foreach(KeyValuePair<string,Class> keyValuePair in Globals.people.sortedList)
            {
                if (keyValuePair.Value.GetType() == typeof("type"))
                {
                    AddPanel(keyValuePair.Value);
                }
            }

            teacherButton.Text = this.flowLayoutPanel1.Controls.Count.ToString(); -- ?
         */

    }
}