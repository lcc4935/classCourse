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

            this.majorToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.minorToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.immersionToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.genEdPerToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.genEdToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.freeToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.adElToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.wellnessToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.coopToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            this.otherToolStripButton.Click += new EventHandler(classToolStripButton__Click);

            this.majorGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.minorGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.immersionGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.genEdPerGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.genEdGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.freeGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.adElGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.wellnessGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.coopGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);
            this.otherGroupBoxToolStripButton.Click += new EventHandler(typesToolStripButton__Click);

            this.majorToolStripButton.Tag = this.majorPanel;
            this.minorToolStripButton.Tag = this.minorPanel;

            this.majorGroupBoxToolStripButton.Tag = this.majorGroupBox;
            //continue these

            //addClassButton - connect button to panels, if statements for type



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

            AddEditClass addEditClass = new AddEditClass((ClassInfo)p.Tag, this); //System.NullReferenceException: 'Object reference not set to an instance of an object.' p was null
            addEditClass.ShowDialog();
        }

        private void InfoButton__Click(object sender, EventArgs e)  //LC
        {
            Button b = (Button)sender;

            PersonalInfo personalInfo = new PersonalInfo((BasicInfo)b.Tag, this);
            personalInfo.ShowDialog();

            /*
            this.yourNameLabel.Text = BasicInfo.name;
            this.MMILabel.Text = BasicInfo.major, BasicInfo.minor, BasicInfo.immersion;
            this.yourCreditLabel.Text = BasicInfo.credit;
            */
        }

        private void classToolStripButton__Click(object sender, EventArgs e) // different sizes for class // initally shrink panels
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            Panel p = (Panel)tsb.Tag;

            if (tsb.Checked)
            {
                tsb.Image = global::classCourse.Properties.Resources.plus;
                p.Size = new System.Drawing.Size(330, 27);
                tsb.Checked = false;
            }
            else
            {
                tsb.Image = global::classCourse.Properties.Resources.minus;
                p.Size = new System.Drawing.Size(330, 103); // System.NullReferenceException: 'Object reference not set to an instance of an object.'    p was null 
                tsb.Checked = true;
            }

            p.Refresh();
        }

        private void typesToolStripButton__Click(object sender, EventArgs e) // different sizes for class types - figure out based on number of classes
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            GroupBox gb = (GroupBox)tsb.Tag;

            if (tsb.Checked)
            {
                tsb.Image = global::classCourse.Properties.Resources.plus;
                gb.Size = new System.Drawing.Size(333, 47); //edit size - smaller
                tsb.Checked = false;
            }
            else
            {
                tsb.Image = global::classCourse.Properties.Resources.minus;
                gb.Size = new System.Drawing.Size(333, 500); //edit size - bigger  System.NullReferenceException: 'Object reference not set to an instance of an object.'
                tsb.Checked = true;
            }

            gb.Refresh();
        }


        //labels

        
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
        
        

        //panels
        
        private void AddPanelToClassType(ClassInfo classInfo)  //LC
        {
            Panel panel = new System.Windows.Forms.Panel();
            //this.otherPanel = new System.Windows.Forms.Panel();

            AddClassToPanel(ref panel, classInfo);
            
            this.otherFlowLayoutPanel.Controls.Add(panel); //flowLayoutPanel depends on class type
            this.otherFlowLayoutPanel.Controls.SetChildIndex(panel, otherFlowLayoutPanel.Controls.Count);
        }

        private void AddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {
            
            Label otherClassTypeLabel = new System.Windows.Forms.Label();
            Label otherClassCreditLabel = new System.Windows.Forms.Label();
            Label otherClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip otherPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel otherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton otherToolStripButton = new System.Windows.Forms.ToolStripButton();

            // edit background based on class type

            // otherPanel
            // 
            otherPanel.Controls.Add(otherClassTypeLabel);
            otherPanel.Controls.Add(otherClassCreditLabel);
            otherPanel.Controls.Add(otherClassNameLabel);
            otherPanel.Controls.Add(otherPanelToolStrip);
            otherPanel.Location = new System.Drawing.Point(3, 3);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new System.Drawing.Size(330, 27);
            otherPanel.TabIndex = 0;
            otherPanel.Tag = classInfo;
            // 
            // otherClassTypeLabel
            // 
            otherClassTypeLabel.AutoSize = true;
            otherClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            otherClassTypeLabel.Name = "otherClassTypeLabel";
            otherClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            otherClassTypeLabel.TabIndex = 3;
            otherClassTypeLabel.Text = "Counts towards: " + classInfo.classType; //library variables
            // 
            // otherClassCreditLabel
            // 
            otherClassCreditLabel.AutoSize = true;
            otherClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            otherClassCreditLabel.Name = "otherClassCreditLabel";
            otherClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            otherClassCreditLabel.TabIndex = 2;
            otherClassCreditLabel.Text = classInfo.classCredit; //library variables
            // 
            // otherClassNameLabel
            // 
            otherClassNameLabel.AutoSize = true;
            otherClassNameLabel.Location = new System.Drawing.Point(4, 29);
            otherClassNameLabel.Name = "otherClassNameLabel";
            otherClassNameLabel.Size = new System.Drawing.Size(60, 13);
            otherClassNameLabel.TabIndex = 1;
            otherClassNameLabel.Text = classInfo.className; //library variables
            // 
            // otherPanelToolStrip
            // 
            otherPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            otherToolStripButton,
            otherToolStripLabel});
            otherPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            otherPanelToolStrip.Name = "otherPanelToolStrip";
            otherPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            otherPanelToolStrip.TabIndex = 0;
            otherPanelToolStrip.Text = "toolStrip1";
            // 
            // otherToolStripLabel
            // 
            otherToolStripLabel.IsLink = true;
            otherToolStripLabel.Name = "otherToolStripLabel";
            otherToolStripLabel.Size = new System.Drawing.Size(134, 22);
            otherToolStripLabel.Text = classInfo.department + classInfo.courseCode; //library variables
            otherToolStripLabel.Click += new EventHandler(ToolStripLabels__Click); //potentially edit name of event after write this
            otherToolStripLabel.Tag = panel;
            //
            // otherToolStripButton
            // 
            otherToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            otherToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            otherToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            otherToolStripButton.Name = "otherToolStripButton";
            otherToolStripButton.Size = new System.Drawing.Size(23, 22);
            otherToolStripButton.Text = "toolStripButton1";
            otherToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            otherToolStripButton.Tag = panel;
            
        }



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