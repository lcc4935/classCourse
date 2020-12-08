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


/*
 * All the errors have comments sticking out so they should be easy to locate,
 * I also have null in all the error comments and questions if that makes it easier to search
 * 
 * Issues/ Questions:
 * 
 * 1) Don't know how to select the type (functions: ToolStripLabels__Click and AddPanelToClassType)
 * I tried using .Tag, but I don't think thats right, but I didn't know how else to call it
 * 
 * 2) In forms 2 and 3 I tried loading the reference variables into the form fields and it's coming up as an error
 * 
 * 3) I am getting an error in program.cs, don't know if that will go away when the other errors do, just thought I'd mention it in case that's not the case
 * 
 * 4) in the function AddClassButton__Click (~line 194) is saying classInfo isn't correct and
 * I am getting that same error in the multipe AddClassToPanel functions
 * (well I am getting them in one, but that is because I didn't do the if else statement correctly earlier in the code)
 * 
 * 5) in the function AddClassButton__Click, I am trying to add another panel to the semester slots
 *  I phrased an if statement not as intended and don't know if there is a better way to say what I am trying to do
 *  (more clear of a question when you see it)
 *  
 *  6) in the function UndecidedRemoveClassToPanel, I didn't know if I ued the right method to do what I want it to do
 *  (again, more clear when you'll see the code)
 *  
 *  7) Not really a question, but I can't determine if I have an issues on the panels being added to the semester slots as
 *  they wouldn't show up until the first panels show up, so I might be asking for more help later if I run into issues there once the rest works
 *  (just as a heads up as I also might've just forgotten some questions as well)
 */


namespace classCourse
{
    public partial class classCourse : Form
    {
        public classCourse() //LC
        {
            InitializeComponent();

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

            this.majorToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.minorToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.immersionToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.genEdPerToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.genEdToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.freeToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.adElToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.wellnessToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.coopToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            this.otherToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);

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
            this.immersionToolStripButton.Tag = this.immersionPanel;
            this.genEdPerToolStripButton.Tag = this.genEdPerPanel;
            this.genEdToolStripButton.Tag = this.genEdPanel;
            this.freeToolStripButton.Tag = this.freePanel;
            this.adElToolStripButton.Tag = this.adElPanel;
            this.wellnessToolStripButton.Tag = this.wellnessPanel;
            this.coopToolStripButton.Tag = this.coopPanel;
            this.otherToolStripButton.Tag = this.otherPanel;

            this.majorToolStripLabel.Tag = this.majorPanel;
            this.minorToolStripLabel.Tag = this.minorPanel;
            this.immersionToolStripLabel.Tag = this.immersionPanel;
            this.genEdPerToolStripLabel.Tag = this.genEdPerPanel;
            this.genEdToolStripLabel.Tag = this.genEdPanel;
            this.freeToolStripLabel.Tag = this.freePanel;
            this.adElToolStripLabel.Tag = this.adElPanel;
            this.wellnessToolStripLabel.Tag = this.wellnessPanel;
            this.coopToolStripLabel.Tag = this.coopPanel;
            this.otherToolStripLabel.Tag = this.otherPanel;

            this.freshFallLabel.Tag = this.freshFallPanel;
            this.freshSpringLabel.Tag = this.freshSpringPanel;
            this.sophFallLabel.Tag = this.sophFallPanel;
            this.sophSpringLabel.Tag = this.sophSpringPanel;
            this.juniorFallLabel.Tag = this.juniorFallPanel;
            this.juniorSpringLabel.Tag = this.juniorSpringPanel;
            this.seniorFallLabel.Tag = this.seniorFallPanel;
            this.seniorSpringLabel.Tag = this.seniorSpringPanel;

            this.majorGroupBoxToolStripButton.Tag = this.majorGroupBox;
            this.minorGroupBoxToolStripButton.Tag = this.minorGroupBox;
            this.immersionGroupBoxToolStripButton.Tag = this.immersionGroupBox;
            this.genEdPerGroupBoxToolStripButton.Tag = this.genEdPerGroupBox;
            this.genEdGroupBoxToolStripButton.Tag = this.genEdGroupBox;
            this.freeGroupBoxToolStripButton.Tag = this.freeGroupBox;
            this.adElGroupBoxToolStripButton.Tag = this.adElGroupBox;
            this.wellnessGroupBoxToolStripButton.Tag = this.wellnessGroupBox;
            this.coopGroupBoxToolStripButton.Tag = this.coopGroupBox;
            this.otherGroupBoxToolStripButton.Tag = this.otherGroupBox;

            this.majorAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.minorAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.immersionAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.genEdPerAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.genEdAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.freeAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.adElAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.wellnessAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.coopAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);
            this.otherAddClassToolStripButton.Click += new EventHandler(AddClassButton__Click);

            this.majorAddClassToolStripButton.Tag = this.majorPanel;
            this.minorAddClassToolStripButton.Tag = this.minorPanel;
            this.immersionAddClassToolStripButton.Tag = this.immersionPanel;
            this.genEdPerAddClassToolStripButton.Tag = this.genEdPerPanel;
            this.genEdAddClassToolStripButton.Tag = this.genEdPanel;
            this.freeAddClassToolStripButton.Tag = this.freePanel;
            this.adElAddClassToolStripButton.Tag = this.adElPanel;
            this.wellnessAddClassToolStripButton.Tag = this.wellnessPanel;
            this.coopAddClassToolStripButton.Tag = this.coopPanel;
            this.otherAddClassToolStripButton.Tag = this.otherPanel;

            /*
             * uncomment after everything works
             * 
            majorPanel.Visible = false;
            minorPanel.Visible = false;
            immersionPanel.Visible = false;
            genEdPerPanel.Visible = false;
            genEdPanel.Visible = false;
            freePanel.Visible = false;
            adElPanel.Visible = false;
            wellnessPanel.Visible = false;
            coopPanel.Visible = false;
            otherPanel.Visible = false;
            //------------------------
            freshFallPanel.Visible = false;
            freshSpringPanel.Visible = false;
            sophFallPanel.Visible = false;
            sophSpringPanel.Visible = false;
            juniorFallPanel.Visible = false;
            juniorSpringPanel.Visible = false;
            seniorFallPanel.Visible = false;
            seniorSpringPanel.Visible = false;
            */

        }


        //Buttons

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

        private void classToolStripButton__Click(object sender, EventArgs e)  //LC
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
                p.Size = new System.Drawing.Size(330, 103);
                tsb.Checked = true;
            }

            p.Refresh();
        }

        private void typesToolStripButton__Click(object sender, EventArgs e)  //LC
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            GroupBox gb = (GroupBox)tsb.Tag;

            if (tsb.Checked)
            {
                tsb.Image = global::classCourse.Properties.Resources.plus;
                gb.Size = new System.Drawing.Size(333, 47);
                tsb.Checked = false;
            }
            else
            {
                tsb.Image = global::classCourse.Properties.Resources.minus;
                gb.Size = new System.Drawing.Size(333, 500);
                tsb.Checked = true;
            }

            gb.Refresh();
        }

        private void AddClassButton__Click(object sender, EventArgs e)  //LC
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            Panel p = (Panel)tsb.Tag;

            AddEditClass addEditClass = new AddEditClass((ClassInfo)p.Tag, this); //System.NullReferenceException: 'Object reference not set to an instance of an object.'
            addEditClass.Visible = false;

            addEditClass.ShowDialog();

            ClassInfo classInfo = addEditClass.formClass;

            AddPanelToClassType(sender, e, classInfo);

            if (classInfo.semester != semesters.undecided) // (null - actually just a question, just helping find said question) insead of phrasing it like this
                                                            //is there a way to basically say that if the radio button has been changed or if the classInfo.semester has changed
            {
                AddPanelToSemesters(classInfo);
            }

            p.Refresh();
        }


        //labels


        private void ToolStripLabels__Click(object sender, EventArgs e)  //LC  If/else statements aren't working as intended (null- to help find error)
        {
            ToolStripLabel tsl = (ToolStripLabel)sender;
            Panel p = (Panel)tsl.Tag;

            AddEditClass addEditClass = new AddEditClass((ClassInfo)p.Tag, this);
            addEditClass.Visible = false;

            addEditClass.ShowDialog();

            ClassInfo classInfo = addEditClass.formClass;

            p.Controls.Clear();

            if (tsl.Tag == majorToolStripLabel)
            {
                MajorAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == minorToolStripLabel)
            {
                MinorAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == immersionToolStripLabel)
            {
                ImmersionAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == genEdPerToolStripLabel)
            {
                GenEdPerAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == genEdToolStripLabel)
            {
                GenEdAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == freeToolStripLabel)
            {
                FreeAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == adElToolStripLabel)
            {
                AdElAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == wellnessToolStripLabel)
            {
                WellnessAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Tag == coopToolStripLabel)
            {
                CoopAddClassToPanel(ref p, classInfo);
            }
            else //if (tsl.Tag == otherToolStripLabel)
            {
                OtherAddClassToPanel(ref p, classInfo);
            }

            p.Refresh();
        }
        
        

        //panels
        
        private void AddPanelToClassType(object sender, EventArgs e, ClassInfo classInfo)  //LC  If/else statements aren't working as intended (null- to help find error)
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            Panel panel = new System.Windows.Forms.Panel();

            if (tsb.Tag == majorAddClassToolStripButton)
            {
                MajorAddClassToPanel(ref panel, classInfo);

                this.majorFlowLayoutPanel.Controls.Add(panel);
                this.majorFlowLayoutPanel.Controls.SetChildIndex(panel, majorFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == minorAddClassToolStripButton)
            {
                MinorAddClassToPanel(ref panel, classInfo);

                this.minorFlowLayoutPanel.Controls.Add(panel);
                this.minorFlowLayoutPanel.Controls.SetChildIndex(panel, minorFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == immersionAddClassToolStripButton)
            {
                ImmersionAddClassToPanel(ref panel, classInfo);

                this.immersionFlowLayoutPanel.Controls.Add(panel);
                this.immersionFlowLayoutPanel.Controls.SetChildIndex(panel, immersionFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == genEdPerAddClassToolStripButton)
            {
                GenEdPerAddClassToPanel(ref panel, classInfo);

                this.genEdPerFlowLayoutPanel.Controls.Add(panel);
                this.genEdPerFlowLayoutPanel.Controls.SetChildIndex(panel, genEdPerFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == genEdAddClassToolStripButton)
            {
                GenEdAddClassToPanel(ref panel, classInfo);

                this.genEdFlowLayoutPanel.Controls.Add(panel);
                this.genEdFlowLayoutPanel.Controls.SetChildIndex(panel, genEdFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == freeAddClassToolStripButton)
            {
                FreeAddClassToPanel(ref panel, classInfo);

                this.freeFlowLayoutPanel.Controls.Add(panel);
                this.freeFlowLayoutPanel.Controls.SetChildIndex(panel, freeFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == adElAddClassToolStripButton)
            {
                AdElAddClassToPanel(ref panel, classInfo);

                this.adElFlowLayoutPanel.Controls.Add(panel);
                this.adElFlowLayoutPanel.Controls.SetChildIndex(panel, adElFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == wellnessAddClassToolStripButton)
            {
                WellnessAddClassToPanel(ref panel, classInfo);

                this.wellnessFlowLayoutPanel.Controls.Add(panel);
                this.wellnessFlowLayoutPanel.Controls.SetChildIndex(panel, wellnessFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Tag == coopAddClassToolStripButton)
            {
                CoopAddClassToPanel(ref panel, classInfo);

                this.coopFlowLayoutPanel.Controls.Add(panel);
                this.coopFlowLayoutPanel.Controls.SetChildIndex(panel, coopFlowLayoutPanel.Controls.Count);
            }
            else //if (tsb.Tag == otherAddClassToolStripButton)
            {
                OtherAddClassToPanel(ref panel, classInfo);

                this.otherFlowLayoutPanel.Controls.Add(panel);
                this.otherFlowLayoutPanel.Controls.SetChildIndex(panel, otherFlowLayoutPanel.Controls.Count);
            }

        }



        //move to bottom after
        private void AddPanelToSemesters(ClassInfo classInfo)
        {
            Panel panel = new System.Windows.Forms.Panel();

            if (classInfo.semester == semesters.freshFall)
            {
                FreshFallAddClassToPanel(ref panel, classInfo);

                this.freshFallFlowLayoutPanel.Controls.Add(panel);
                this.freshFallFlowLayoutPanel.Controls.SetChildIndex(panel, freshFallFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.freshSpring)
            {
                FreshSpringAddClassToPanel(ref panel, classInfo);

                this.freshSpringFlowLayoutPanel.Controls.Add(panel);
                this.freshSpringFlowLayoutPanel.Controls.SetChildIndex(panel, freshSpringFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.sophFall)
            {
                SophFallAddClassToPanel(ref panel, classInfo);

                this.sophFallFlowLayoutPanel.Controls.Add(panel);
                this.sophFallFlowLayoutPanel.Controls.SetChildIndex(panel, sophFallFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.sophSpring)
            {
                SophSpringAddClassToPanel(ref panel, classInfo);

                this.sophSpringFlowLayoutPanel.Controls.Add(panel);
                this.sophSpringFlowLayoutPanel.Controls.SetChildIndex(panel, sophSpringFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.juniorFall)
            {
                JuniorFallAddClassToPanel(ref panel, classInfo);

                this.juniorFallFlowLayoutPanel.Controls.Add(panel);
                this.juniorFallFlowLayoutPanel.Controls.SetChildIndex(panel, juniorFallFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.juniorSpring)
            {
                JuniorSpringAddClassToPanel(ref panel, classInfo);

                this.juniorSpringFlowLayoutPanel.Controls.Add(panel);
                this.juniorSpringFlowLayoutPanel.Controls.SetChildIndex(panel, juniorSpringFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.seniorFall)
            {
                SeniorFallAddClassToPanel(ref panel, classInfo);

                this.seniorFallFlowLayoutPanel.Controls.Add(panel);
                this.seniorFallFlowLayoutPanel.Controls.SetChildIndex(panel, seniorFallFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.seniorSpring)
            {
                SeniorSpringAddClassToPanel(ref panel, classInfo);

                this.seniorSpringFlowLayoutPanel.Controls.Add(panel);
                this.seniorSpringFlowLayoutPanel.Controls.SetChildIndex(panel, seniorSpringFlowLayoutPanel.Controls.Count);
            }
            else if (classInfo.semester == semesters.undecided)
            {
                UndecidedRemoveClassToPanel(ref panel, classInfo);
            }

        }
        private void FreshFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            freshFallLabel = new System.Windows.Forms.Label();

            // freshFallPanel
            freshFallPanel.Controls.Add(freshFallLabel);
            freshFallPanel.Location = new System.Drawing.Point(6, 16);
            freshFallPanel.Name = "freshFallPanel";
            freshFallPanel.Size = new System.Drawing.Size(147, 23);
            freshFallPanel.TabIndex = 0;
            freshFallPanel.Tag = classInfo;

            // freshFallLabel
            freshFallLabel.AutoSize = true;
            freshFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            freshFallLabel.Location = new System.Drawing.Point(0, 0);
            freshFallLabel.Name = "freshFallLabel";
            freshFallLabel.Size = new System.Drawing.Size(82, 13);
            freshFallLabel.TabIndex = 0;
            freshFallLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            freshFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                freshFallPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                freshFallPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                freshFallPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                freshFallPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                freshFallPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                freshFallPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                freshFallPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                freshFallPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                freshFallPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                freshFallPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void FreshSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            freshSpringLabel = new System.Windows.Forms.Label();

            // Panel
            freshSpringPanel.Controls.Add(freshSpringLabel);
            freshSpringPanel.Location = new System.Drawing.Point(6, 16);
            freshSpringPanel.Name = "freshSpringPanel";
            freshSpringPanel.Size = new System.Drawing.Size(147, 23);
            freshSpringPanel.TabIndex = 0;
            freshSpringPanel.Tag = classInfo;

            // Label
            freshSpringLabel.AutoSize = true;
            freshSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            freshSpringLabel.Location = new System.Drawing.Point(0, 0);
            freshSpringLabel.Name = "freshSpringLabel";
            freshSpringLabel.Size = new System.Drawing.Size(82, 13);
            freshSpringLabel.TabIndex = 0;
            freshSpringLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            freshSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                freshSpringPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SophFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            sophFallLabel = new System.Windows.Forms.Label();

            // Panel
            sophFallPanel.Controls.Add(sophFallLabel);
            sophFallPanel.Location = new System.Drawing.Point(6, 16);
            sophFallPanel.Name = "sophFallPanel";
            sophFallPanel.Size = new System.Drawing.Size(147, 23);
            sophFallPanel.TabIndex = 0;
            sophFallPanel.Tag = classInfo;

            // Label
            sophFallLabel.AutoSize = true;
            sophFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sophFallLabel.Location = new System.Drawing.Point(0, 0);
            sophFallLabel.Name = "sophFallLabel";
            sophFallLabel.Size = new System.Drawing.Size(82, 13);
            sophFallLabel.TabIndex = 0;
            sophFallLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            sophFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                sophFallPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                sophFallPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                sophFallPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                sophFallPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                sophFallPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                sophFallPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                sophFallPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                sophFallPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                sophFallPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                sophFallPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SophSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            sophSpringLabel = new System.Windows.Forms.Label();

            // Panel
            sophSpringPanel.Controls.Add(sophSpringLabel);
            sophSpringPanel.Location = new System.Drawing.Point(6, 16);
            sophSpringPanel.Name = "sophSpringPanel";
            sophSpringPanel.Size = new System.Drawing.Size(147, 23);
            sophSpringPanel.TabIndex = 0;
            sophSpringPanel.Tag = classInfo;

            // Label
            sophSpringLabel.AutoSize = true;
            sophSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sophSpringLabel.Location = new System.Drawing.Point(0, 0);
            sophSpringLabel.Name = "sophSpringLabel";
            sophSpringLabel.Size = new System.Drawing.Size(82, 13);
            sophSpringLabel.TabIndex = 0;
            sophSpringLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            sophSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                sophSpringPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void JuniorFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            juniorFallLabel = new System.Windows.Forms.Label();

            // Panel
            juniorFallPanel.Controls.Add(juniorFallLabel);
            juniorFallPanel.Location = new System.Drawing.Point(6, 16);
            juniorFallPanel.Name = "juniorFallPanel";
            juniorFallPanel.Size = new System.Drawing.Size(147, 23);
            juniorFallPanel.TabIndex = 0;
            juniorFallPanel.Tag = classInfo;

            // Label
            juniorFallLabel.AutoSize = true;
            juniorFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            juniorFallLabel.Location = new System.Drawing.Point(0, 0);
            juniorFallLabel.Name = "juniorFallLabel";
            juniorFallLabel.Size = new System.Drawing.Size(82, 13);
            juniorFallLabel.TabIndex = 0;
            juniorFallLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            juniorFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                juniorFallPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void JuniorSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            juniorSpringLabel = new System.Windows.Forms.Label();

            // Panel
            juniorSpringPanel.Controls.Add(juniorSpringLabel);
            juniorSpringPanel.Location = new System.Drawing.Point(6, 16);
            juniorSpringPanel.Name = "juniorSpringPanel";
            juniorSpringPanel.Size = new System.Drawing.Size(147, 23);
            juniorSpringPanel.TabIndex = 0;
            juniorSpringPanel.Tag = classInfo;

            // Label
            juniorSpringLabel.AutoSize = true;
            juniorSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            juniorSpringLabel.Location = new System.Drawing.Point(0, 0);
            juniorSpringLabel.Name = "juniorSpringLabel";
            juniorSpringLabel.Size = new System.Drawing.Size(82, 13);
            juniorSpringLabel.TabIndex = 0;
            juniorSpringLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            juniorSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                juniorSpringPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SeniorFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            seniorFallLabel = new System.Windows.Forms.Label();

            // Panel
            seniorFallPanel.Controls.Add(seniorFallLabel);
            seniorFallPanel.Location = new System.Drawing.Point(6, 16);
            seniorFallPanel.Name = "seniorFallPanel";
            seniorFallPanel.Size = new System.Drawing.Size(147, 23);
            seniorFallPanel.TabIndex = 0;
            seniorFallPanel.Tag = classInfo;

            // Label
            seniorFallLabel.AutoSize = true;
            seniorFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            seniorFallLabel.Location = new System.Drawing.Point(0, 0);
            seniorFallLabel.Name = "seniorFallLabel";
            seniorFallLabel.Size = new System.Drawing.Size(82, 13);
            seniorFallLabel.TabIndex = 0;
            seniorFallLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            seniorFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                seniorFallPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SeniorSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            seniorSpringLabel = new System.Windows.Forms.Label();

            // Panel
            seniorSpringPanel.Controls.Add(seniorSpringLabel);
            seniorSpringPanel.Location = new System.Drawing.Point(6, 16);
            seniorSpringPanel.Name = "seniorSpringPanel";
            seniorSpringPanel.Size = new System.Drawing.Size(147, 23);
            seniorSpringPanel.TabIndex = 0;
            seniorSpringPanel.Tag = classInfo;

            // Label
            seniorSpringLabel.AutoSize = true;
            seniorSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            seniorSpringLabel.Location = new System.Drawing.Point(0, 0);
            seniorSpringLabel.Name = "seniorSpringLabel";
            seniorSpringLabel.Size = new System.Drawing.Size(82, 13);
            seniorSpringLabel.TabIndex = 0;
            seniorSpringLabel.Text = classInfo.department + classInfo.courseCode + classInfo.classCredit;
            seniorSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                seniorSpringPanel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void UndecidedRemoveClassToPanel(ref Panel panel, ClassInfo classInfo)
        {
            panel.Dispose(); //(null - for questions sake) is this more or less deleting the panel because that is the goal
        }




        private void MajorAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {
            
            Label majorClassTypeLabel = new System.Windows.Forms.Label();
            Label majorClassCreditLabel = new System.Windows.Forms.Label();
            Label majorClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip majorPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel majorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton majorToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            majorPanel.BackColor = System.Drawing.Color.DodgerBlue;
            majorPanel.Controls.Add(majorClassTypeLabel);
            majorPanel.Controls.Add(majorClassCreditLabel);
            majorPanel.Controls.Add(majorClassNameLabel);
            majorPanel.Controls.Add(majorPanelToolStrip);
            majorPanel.Location = new System.Drawing.Point(3, 3);
            majorPanel.Name = "majorPanel";
            majorPanel.Size = new System.Drawing.Size(330, 27);
            majorPanel.TabIndex = 0;
            majorPanel.Tag = classInfo;

            // ClassTypeLabel
            majorClassTypeLabel.AutoSize = true;
            majorClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            majorClassTypeLabel.Name = "majorClassTypeLabel";
            majorClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            majorClassTypeLabel.TabIndex = 3;
            majorClassTypeLabel.Text = "Counts towards: " + classInfo.classType;
            
            // ClassCreditLabel
            majorClassCreditLabel.AutoSize = true;
            majorClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            majorClassCreditLabel.Name = "majorClassCreditLabel";
            majorClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            majorClassCreditLabel.TabIndex = 2;
            majorClassCreditLabel.Text = classInfo.classCredit;
            
            // ClassNameLabel
            majorClassNameLabel.AutoSize = true;
            majorClassNameLabel.Location = new System.Drawing.Point(4, 29);
            majorClassNameLabel.Name = "majorClassNameLabel";
            majorClassNameLabel.Size = new System.Drawing.Size(60, 13);
            majorClassNameLabel.TabIndex = 1;
            majorClassNameLabel.Text = classInfo.className;
            
            // PanelToolStrip
            majorPanelToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            majorPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            majorToolStripButton,
            majorToolStripLabel});
            majorPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            majorPanelToolStrip.Name = "majorPanelToolStrip";
            majorPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            majorPanelToolStrip.TabIndex = 0;
            majorPanelToolStrip.Text = "toolStrip1";
            
            // ToolStripLabel
            majorToolStripLabel.IsLink = true;
            majorToolStripLabel.Name = "majorToolStripLabel";
            majorToolStripLabel.Size = new System.Drawing.Size(134, 22);
            majorToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            majorToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            majorToolStripLabel.Tag = panel;
            
            // ToolStripButton
            majorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            majorToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            majorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            majorToolStripButton.Name = "majorToolStripButton";
            majorToolStripButton.Size = new System.Drawing.Size(23, 22);
            majorToolStripButton.Text = "toolStripButton1";
            majorToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            majorToolStripButton.Tag = panel;
        }

        private void MinorAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label minorClassTypeLabel = new System.Windows.Forms.Label();
            Label minorClassCreditLabel = new System.Windows.Forms.Label();
            Label minorClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip minorPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel minorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton minorToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            minorPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            minorPanel.Controls.Add(minorClassTypeLabel);
            minorPanel.Controls.Add(minorClassCreditLabel);
            minorPanel.Controls.Add(minorClassNameLabel);
            minorPanel.Controls.Add(minorPanelToolStrip);
            minorPanel.Location = new System.Drawing.Point(3, 3);
            minorPanel.Name = "minorPanel";
            minorPanel.Size = new System.Drawing.Size(330, 27);
            minorPanel.TabIndex = 0;
            minorPanel.Tag = classInfo;

            // ClassTypeLabel
            minorClassTypeLabel.AutoSize = true;
            minorClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            minorClassTypeLabel.Name = "minorClassTypeLabel";
            minorClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            minorClassTypeLabel.TabIndex = 3;
            minorClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            minorClassCreditLabel.AutoSize = true;
            minorClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            minorClassCreditLabel.Name = "minorClassCreditLabel";
            minorClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            minorClassCreditLabel.TabIndex = 2;
            minorClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            minorClassNameLabel.AutoSize = true;
            minorClassNameLabel.Location = new System.Drawing.Point(4, 29);
            minorClassNameLabel.Name = "minorClassNameLabel";
            minorClassNameLabel.Size = new System.Drawing.Size(60, 13);
            minorClassNameLabel.TabIndex = 1;
            minorClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            minorPanelToolStrip.BackColor = System.Drawing.Color.MediumTurquoise;
            minorPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            minorToolStripButton,
            minorToolStripLabel});
            minorPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            minorPanelToolStrip.Name = "minorPanelToolStrip";
            minorPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            minorPanelToolStrip.TabIndex = 0;
            minorPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            minorToolStripLabel.IsLink = true;
            minorToolStripLabel.Name = "minorToolStripLabel";
            minorToolStripLabel.Size = new System.Drawing.Size(134, 22);
            minorToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            minorToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            minorToolStripLabel.Tag = panel;

            // ToolStripButton
            minorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            minorToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            minorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            minorToolStripButton.Name = "minorToolStripButton";
            minorToolStripButton.Size = new System.Drawing.Size(23, 22);
            minorToolStripButton.Text = "toolStripButton1";
            minorToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            minorToolStripButton.Tag = panel;
        }

        private void ImmersionAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label immersionClassTypeLabel = new System.Windows.Forms.Label();
            Label immersionClassCreditLabel = new System.Windows.Forms.Label();
            Label immersionClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip immersionPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel immersionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton immersionToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            immersionPanel.BackColor = System.Drawing.Color.LightGreen;
            immersionPanel.Controls.Add(immersionClassTypeLabel);
            immersionPanel.Controls.Add(immersionClassCreditLabel);
            immersionPanel.Controls.Add(immersionClassNameLabel);
            immersionPanel.Controls.Add(immersionPanelToolStrip);
            immersionPanel.Location = new System.Drawing.Point(3, 3);
            immersionPanel.Name = "immersionPanel";
            immersionPanel.Size = new System.Drawing.Size(330, 27);
            immersionPanel.TabIndex = 0;
            immersionPanel.Tag = classInfo;

            // ClassTypeLabel
            immersionClassTypeLabel.AutoSize = true;
            immersionClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            immersionClassTypeLabel.Name = "immersionClassTypeLabel";
            immersionClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            immersionClassTypeLabel.TabIndex = 3;
            immersionClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            immersionClassCreditLabel.AutoSize = true;
            immersionClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            immersionClassCreditLabel.Name = "immersionClassCreditLabel";
            immersionClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            immersionClassCreditLabel.TabIndex = 2;
            immersionClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            immersionClassNameLabel.AutoSize = true;
            immersionClassNameLabel.Location = new System.Drawing.Point(4, 29);
            immersionClassNameLabel.Name = "immersionClassNameLabel";
            immersionClassNameLabel.Size = new System.Drawing.Size(60, 13);
            immersionClassNameLabel.TabIndex = 1;
            immersionClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            immersionPanelToolStrip.BackColor = System.Drawing.Color.LightGreen;
            immersionPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            immersionToolStripButton,
            immersionToolStripLabel});
            immersionPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            immersionPanelToolStrip.Name = "immersionPanelToolStrip";
            immersionPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            immersionPanelToolStrip.TabIndex = 0;
            immersionPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            immersionToolStripLabel.IsLink = true;
            immersionToolStripLabel.Name = "immersionToolStripLabel";
            immersionToolStripLabel.Size = new System.Drawing.Size(134, 22);
            immersionToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            immersionToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            immersionToolStripLabel.Tag = panel;

            // ToolStripButton
            immersionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            immersionToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            immersionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            immersionToolStripButton.Name = "immersionToolStripButton";
            immersionToolStripButton.Size = new System.Drawing.Size(23, 22);
            immersionToolStripButton.Text = "toolStripButton1";
            immersionToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            immersionToolStripButton.Tag = panel;
        }

        private void GenEdPerAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label genEdPerClassTypeLabel = new System.Windows.Forms.Label();
            Label genEdPerClassCreditLabel = new System.Windows.Forms.Label();
            Label genEdPerClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip genEdPerPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel genEdPerToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton genEdPerToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            genEdPerPanel.BackColor = System.Drawing.Color.LightPink;
            genEdPerPanel.Controls.Add(genEdPerClassTypeLabel);
            genEdPerPanel.Controls.Add(genEdPerClassCreditLabel);
            genEdPerPanel.Controls.Add(genEdPerClassNameLabel);
            genEdPerPanel.Controls.Add(genEdPerPanelToolStrip);
            genEdPerPanel.Location = new System.Drawing.Point(3, 3);
            genEdPerPanel.Name = "genEdPerPanel";
            genEdPerPanel.Size = new System.Drawing.Size(330, 27);
            genEdPerPanel.TabIndex = 0;
            genEdPerPanel.Tag = classInfo;

            // ClassTypeLabel
            genEdPerClassTypeLabel.AutoSize = true;
            genEdPerClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            genEdPerClassTypeLabel.Name = "genEdPerClassTypeLabel";
            genEdPerClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            genEdPerClassTypeLabel.TabIndex = 3;
            genEdPerClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            genEdPerClassCreditLabel.AutoSize = true;
            genEdPerClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            genEdPerClassCreditLabel.Name = "genEdPerClassCreditLabel";
            genEdPerClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            genEdPerClassCreditLabel.TabIndex = 2;
            genEdPerClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            genEdPerClassNameLabel.AutoSize = true;
            genEdPerClassNameLabel.Location = new System.Drawing.Point(4, 29);
            genEdPerClassNameLabel.Name = "genEdPerClassNameLabel";
            genEdPerClassNameLabel.Size = new System.Drawing.Size(60, 13);
            genEdPerClassNameLabel.TabIndex = 1;
            genEdPerClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            genEdPerPanelToolStrip.BackColor = System.Drawing.Color.LightPink;
            genEdPerPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            genEdPerToolStripButton,
            genEdPerToolStripLabel});
            genEdPerPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            genEdPerPanelToolStrip.Name = "genEdPerPanelToolStrip";
            genEdPerPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            genEdPerPanelToolStrip.TabIndex = 0;
            genEdPerPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            genEdPerToolStripLabel.IsLink = true;
            genEdPerToolStripLabel.Name = "genEdPerToolStripLabel";
            genEdPerToolStripLabel.Size = new System.Drawing.Size(134, 22);
            genEdPerToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            genEdPerToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            genEdPerToolStripLabel.Tag = panel;

            // ToolStripButton
            genEdPerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            genEdPerToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            genEdPerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            genEdPerToolStripButton.Name = "genEdPerToolStripButton";
            genEdPerToolStripButton.Size = new System.Drawing.Size(23, 22);
            genEdPerToolStripButton.Text = "toolStripButton1";
            genEdPerToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            genEdPerToolStripButton.Tag = panel;
        }

        private void GenEdAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label genEdClassTypeLabel = new System.Windows.Forms.Label();
            Label genEdClassCreditLabel = new System.Windows.Forms.Label();
            Label genEdClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip genEdPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel genEdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton genEdToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            genEdPanel.BackColor = System.Drawing.Color.IndianRed;
            genEdPanel.Controls.Add(genEdClassTypeLabel);
            genEdPanel.Controls.Add(genEdClassCreditLabel);
            genEdPanel.Controls.Add(genEdClassNameLabel);
            genEdPanel.Controls.Add(genEdPanelToolStrip);
            genEdPanel.Location = new System.Drawing.Point(3, 3);
            genEdPanel.Name = "genEdPanel";
            genEdPanel.Size = new System.Drawing.Size(330, 27);
            genEdPanel.TabIndex = 0;
            genEdPanel.Tag = classInfo;

            // ClassTypeLabel
            genEdClassTypeLabel.AutoSize = true;
            genEdClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            genEdClassTypeLabel.Name = "genEdClassTypeLabel";
            genEdClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            genEdClassTypeLabel.TabIndex = 3;
            genEdClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            genEdClassCreditLabel.AutoSize = true;
            genEdClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            genEdClassCreditLabel.Name = "genEdClassCreditLabel";
            genEdClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            genEdClassCreditLabel.TabIndex = 2;
            genEdClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            genEdClassNameLabel.AutoSize = true;
            genEdClassNameLabel.Location = new System.Drawing.Point(4, 29);
            genEdClassNameLabel.Name = "genEdClassNameLabel";
            genEdClassNameLabel.Size = new System.Drawing.Size(60, 13);
            genEdClassNameLabel.TabIndex = 1;
            genEdClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            genEdPanelToolStrip.BackColor = System.Drawing.Color.IndianRed;
            genEdPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            genEdToolStripButton,
            genEdToolStripLabel});
            genEdPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            genEdPanelToolStrip.Name = "genEdPanelToolStrip";
            genEdPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            genEdPanelToolStrip.TabIndex = 0;
            genEdPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            genEdToolStripLabel.IsLink = true;
            genEdToolStripLabel.Name = "genEdToolStripLabel";
            genEdToolStripLabel.Size = new System.Drawing.Size(134, 22);
            genEdToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            genEdToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            genEdToolStripLabel.Tag = panel;

            // ToolStripButton
            genEdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            genEdToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            genEdToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            genEdToolStripButton.Name = "genEdToolStripButton";
            genEdToolStripButton.Size = new System.Drawing.Size(23, 22);
            genEdToolStripButton.Text = "toolStripButton1";
            genEdToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            genEdToolStripButton.Tag = panel;
        }

        private void FreeAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label freeClassTypeLabel = new System.Windows.Forms.Label();
            Label freeClassCreditLabel = new System.Windows.Forms.Label();
            Label freeClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip freePanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel freeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton freeToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            freePanel.BackColor = System.Drawing.Color.Coral;
            freePanel.Controls.Add(freeClassTypeLabel);
            freePanel.Controls.Add(freeClassCreditLabel);
            freePanel.Controls.Add(freeClassNameLabel);
            freePanel.Controls.Add(freePanelToolStrip);
            freePanel.Location = new System.Drawing.Point(3, 3);
            freePanel.Name = "freePanel";
            freePanel.Size = new System.Drawing.Size(330, 27);
            freePanel.TabIndex = 0;
            freePanel.Tag = classInfo;

            // ClassTypeLabel
            freeClassTypeLabel.AutoSize = true;
            freeClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            freeClassTypeLabel.Name = "freeClassTypeLabel";
            freeClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            freeClassTypeLabel.TabIndex = 3;
            freeClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            freeClassCreditLabel.AutoSize = true;
            freeClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            freeClassCreditLabel.Name = "freeClassCreditLabel";
            freeClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            freeClassCreditLabel.TabIndex = 2;
            freeClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            freeClassNameLabel.AutoSize = true;
            freeClassNameLabel.Location = new System.Drawing.Point(4, 29);
            freeClassNameLabel.Name = "freeClassNameLabel";
            freeClassNameLabel.Size = new System.Drawing.Size(60, 13);
            freeClassNameLabel.TabIndex = 1;
            freeClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            freePanelToolStrip.BackColor = System.Drawing.Color.Coral;
            freePanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            freeToolStripButton,
            freeToolStripLabel});
            freePanelToolStrip.Location = new System.Drawing.Point(0, 0);
            freePanelToolStrip.Name = "freePanelToolStrip";
            freePanelToolStrip.Size = new System.Drawing.Size(330, 25);
            freePanelToolStrip.TabIndex = 0;
            freePanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            freeToolStripLabel.IsLink = true;
            freeToolStripLabel.Name = "freeToolStripLabel";
            freeToolStripLabel.Size = new System.Drawing.Size(134, 22);
            freeToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            freeToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            freeToolStripLabel.Tag = panel;

            // ToolStripButton
            freeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            freeToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            freeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            freeToolStripButton.Name = "freeToolStripButton";
            freeToolStripButton.Size = new System.Drawing.Size(23, 22);
            freeToolStripButton.Text = "toolStripButton1";
            freeToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            freeToolStripButton.Tag = panel;
        }

        private void AdElAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label adElClassTypeLabel = new System.Windows.Forms.Label();
            Label adElClassCreditLabel = new System.Windows.Forms.Label();
            Label adElClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip adElPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel adElToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton adElToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            adElPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            adElPanel.Controls.Add(adElClassTypeLabel);
            adElPanel.Controls.Add(adElClassCreditLabel);
            adElPanel.Controls.Add(adElClassNameLabel);
            adElPanel.Controls.Add(adElPanelToolStrip);
            adElPanel.Location = new System.Drawing.Point(3, 3);
            adElPanel.Name = "adElPanel";
            adElPanel.Size = new System.Drawing.Size(330, 27);
            adElPanel.TabIndex = 0;
            adElPanel.Tag = classInfo;

            // ClassTypeLabel
            adElClassTypeLabel.AutoSize = true;
            adElClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            adElClassTypeLabel.Name = "adElClassTypeLabel";
            adElClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            adElClassTypeLabel.TabIndex = 3;
            adElClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            adElClassCreditLabel.AutoSize = true;
            adElClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            adElClassCreditLabel.Name = "adElClassCreditLabel";
            adElClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            adElClassCreditLabel.TabIndex = 2;
            adElClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            adElClassNameLabel.AutoSize = true;
            adElClassNameLabel.Location = new System.Drawing.Point(4, 29);
            adElClassNameLabel.Name = "adElClassNameLabel";
            adElClassNameLabel.Size = new System.Drawing.Size(60, 13);
            adElClassNameLabel.TabIndex = 1;
            adElClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            adElPanelToolStrip.BackColor = System.Drawing.Color.MediumSeaGreen;
            adElPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            adElToolStripButton,
            adElToolStripLabel});
            adElPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            adElPanelToolStrip.Name = "adElPanelToolStrip";
            adElPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            adElPanelToolStrip.TabIndex = 0;
            adElPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            adElToolStripLabel.IsLink = true;
            adElToolStripLabel.Name = "adElToolStripLabel";
            adElToolStripLabel.Size = new System.Drawing.Size(134, 22);
            adElToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            adElToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            adElToolStripLabel.Tag = panel;

            // ToolStripButton
            adElToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            adElToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            adElToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            adElToolStripButton.Name = "adElToolStripButton";
            adElToolStripButton.Size = new System.Drawing.Size(23, 22);
            adElToolStripButton.Text = "toolStripButton1";
            adElToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            adElToolStripButton.Tag = panel;
        }

        private void WellnessAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label wellnessClassTypeLabel = new System.Windows.Forms.Label();
            Label wellnessClassCreditLabel = new System.Windows.Forms.Label();
            Label wellnessClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip wellnessPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel wellnessToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton wellnessToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            wellnessPanel.BackColor = System.Drawing.Color.Khaki;
            wellnessPanel.Controls.Add(wellnessClassTypeLabel);
            wellnessPanel.Controls.Add(wellnessClassCreditLabel);
            wellnessPanel.Controls.Add(wellnessClassNameLabel);
            wellnessPanel.Controls.Add(wellnessPanelToolStrip);
            wellnessPanel.Location = new System.Drawing.Point(3, 3);
            wellnessPanel.Name = "wellnessPanel";
            wellnessPanel.Size = new System.Drawing.Size(330, 27);
            wellnessPanel.TabIndex = 0;
            wellnessPanel.Tag = classInfo;

            // ClassTypeLabel
            wellnessClassTypeLabel.AutoSize = true;
            wellnessClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            wellnessClassTypeLabel.Name = "wellnessClassTypeLabel";
            wellnessClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            wellnessClassTypeLabel.TabIndex = 3;
            wellnessClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            wellnessClassCreditLabel.AutoSize = true;
            wellnessClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            wellnessClassCreditLabel.Name = "wellnessClassCreditLabel";
            wellnessClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            wellnessClassCreditLabel.TabIndex = 2;
            wellnessClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            wellnessClassNameLabel.AutoSize = true;
            wellnessClassNameLabel.Location = new System.Drawing.Point(4, 29);
            wellnessClassNameLabel.Name = "wellnessClassNameLabel";
            wellnessClassNameLabel.Size = new System.Drawing.Size(60, 13);
            wellnessClassNameLabel.TabIndex = 1;
            wellnessClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            wellnessPanelToolStrip.BackColor = System.Drawing.Color.Khaki;
            wellnessPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            wellnessToolStripButton,
            wellnessToolStripLabel});
            wellnessPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            wellnessPanelToolStrip.Name = "wellnessPanelToolStrip";
            wellnessPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            wellnessPanelToolStrip.TabIndex = 0;
            wellnessPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            wellnessToolStripLabel.IsLink = true;
            wellnessToolStripLabel.Name = "wellnessToolStripLabel";
            wellnessToolStripLabel.Size = new System.Drawing.Size(134, 22);
            wellnessToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            wellnessToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            wellnessToolStripLabel.Tag = panel;

            // ToolStripButton
            wellnessToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            wellnessToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            wellnessToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            wellnessToolStripButton.Name = "wellnessToolStripButton";
            wellnessToolStripButton.Size = new System.Drawing.Size(23, 22);
            wellnessToolStripButton.Text = "toolStripButton1";
            wellnessToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            wellnessToolStripButton.Tag = panel;
        }

        private void CoopAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label coopClassTypeLabel = new System.Windows.Forms.Label();
            Label coopClassCreditLabel = new System.Windows.Forms.Label();
            Label coopClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip coopPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel coopToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton coopToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            coopPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            coopPanel.Controls.Add(coopClassTypeLabel);
            coopPanel.Controls.Add(coopClassCreditLabel);
            coopPanel.Controls.Add(coopClassNameLabel);
            coopPanel.Controls.Add(coopPanelToolStrip);
            coopPanel.Location = new System.Drawing.Point(3, 3);
            coopPanel.Name = "coopPanel";
            coopPanel.Size = new System.Drawing.Size(330, 27);
            coopPanel.TabIndex = 0;
            coopPanel.Tag = classInfo;

            // ClassTypeLabel
            coopClassTypeLabel.AutoSize = true;
            coopClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            coopClassTypeLabel.Name = "coopClassTypeLabel";
            coopClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            coopClassTypeLabel.TabIndex = 3;
            coopClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

            // ClassCreditLabel
            coopClassCreditLabel.AutoSize = true;
            coopClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            coopClassCreditLabel.Name = "coopClassCreditLabel";
            coopClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            coopClassCreditLabel.TabIndex = 2;
            coopClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            coopClassNameLabel.AutoSize = true;
            coopClassNameLabel.Location = new System.Drawing.Point(4, 29);
            coopClassNameLabel.Name = "coopClassNameLabel";
            coopClassNameLabel.Size = new System.Drawing.Size(60, 13);
            coopClassNameLabel.TabIndex = 1;
            coopClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            coopPanelToolStrip.BackColor = System.Drawing.Color.MediumSlateBlue;
            coopPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            coopToolStripButton,
            coopToolStripLabel});
            coopPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            coopPanelToolStrip.Name = "coopPanelToolStrip";
            coopPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            coopPanelToolStrip.TabIndex = 0;
            coopPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            coopToolStripLabel.IsLink = true;
            coopToolStripLabel.Name = "coopToolStripLabel";
            coopToolStripLabel.Size = new System.Drawing.Size(134, 22);
            coopToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            coopToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            coopToolStripLabel.Tag = panel;

            // ToolStripButton
            coopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            coopToolStripButton.Image = global::classCourse.Properties.Resources.plus;
            coopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            coopToolStripButton.Name = "coopToolStripButton";
            coopToolStripButton.Size = new System.Drawing.Size(23, 22);
            coopToolStripButton.Text = "toolStripButton1";
            coopToolStripButton.Click += new EventHandler(classToolStripButton__Click);
            coopToolStripButton.Tag = panel;
        }

        private void OtherAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {

            Label otherClassTypeLabel = new System.Windows.Forms.Label();
            Label otherClassCreditLabel = new System.Windows.Forms.Label();
            Label otherClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip otherPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel otherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton otherToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            otherPanel.BackColor = System.Drawing.Color.Violet;
            otherPanel.Controls.Add(otherClassTypeLabel);
            otherPanel.Controls.Add(otherClassCreditLabel);
            otherPanel.Controls.Add(otherClassNameLabel);
            otherPanel.Controls.Add(otherPanelToolStrip);
            otherPanel.Location = new System.Drawing.Point(3, 3);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new System.Drawing.Size(330, 27);
            otherPanel.TabIndex = 0;
            otherPanel.Tag = classInfo;

            // ClassTypeLabel
            otherClassTypeLabel.AutoSize = true;
            otherClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            otherClassTypeLabel.Name = "otherClassTypeLabel";
            otherClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            otherClassTypeLabel.TabIndex = 3;
            otherClassTypeLabel.Text = "Counts towards: " + classInfo.classType; //System.NullReferenceException: 'Object reference not set to an instance of an object.' classInfo was null

            // ClassCreditLabel
            otherClassCreditLabel.AutoSize = true;
            otherClassCreditLabel.Location = new System.Drawing.Point(7, 51);
            otherClassCreditLabel.Name = "otherClassCreditLabel";
            otherClassCreditLabel.Size = new System.Drawing.Size(48, 13);
            otherClassCreditLabel.TabIndex = 2;
            otherClassCreditLabel.Text = classInfo.classCredit;

            // ClassNameLabel
            otherClassNameLabel.AutoSize = true;
            otherClassNameLabel.Location = new System.Drawing.Point(4, 29);
            otherClassNameLabel.Name = "otherClassNameLabel";
            otherClassNameLabel.Size = new System.Drawing.Size(60, 13);
            otherClassNameLabel.TabIndex = 1;
            otherClassNameLabel.Text = classInfo.className;

            // PanelToolStrip
            otherPanelToolStrip.BackColor = System.Drawing.Color.Violet;
            otherPanelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            otherToolStripButton,
            otherToolStripLabel});
            otherPanelToolStrip.Location = new System.Drawing.Point(0, 0);
            otherPanelToolStrip.Name = "otherPanelToolStrip";
            otherPanelToolStrip.Size = new System.Drawing.Size(330, 25);
            otherPanelToolStrip.TabIndex = 0;
            otherPanelToolStrip.Text = "toolStrip1";

            // ToolStripLabel
            otherToolStripLabel.IsLink = true;
            otherToolStripLabel.Name = "otherToolStripLabel";
            otherToolStripLabel.Size = new System.Drawing.Size(134, 22);
            otherToolStripLabel.Text = classInfo.department + classInfo.courseCode;
            otherToolStripLabel.Click += new EventHandler(ToolStripLabels__Click);
            otherToolStripLabel.Tag = panel;

            // ToolStripButton
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