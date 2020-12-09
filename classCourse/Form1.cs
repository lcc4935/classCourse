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
    public partial class classCourse : Form
    {
        //Used for GPA Calculations. JLH
        static public double totalGradePoints = 0.0;
        static public int totalClassesTaken = 0;
        static protected double GPA;
        static public string[] grades = new string[] { "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D", "F" };
        static public double[] gradePoints = new double[] { 4, 3.67, 3.33, 3, 2.67, 2.33, 2, 1.67, 1, 0 };
        //end of GPA calc tools

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

        }


        //Buttons

        private void InfoButton__Click(object sender, EventArgs e)  //LC and JLH
        {
            Button b = (Button)sender;

            BasicInfo basicInfo = new BasicInfo();

            PersonalInfo personalInfo = new PersonalInfo(basicInfo, this);
            personalInfo.ShowDialog(this);


            this.yourNameLabel.Text = basicInfo.name;
            this.MMILabel.Text = "Major: " + basicInfo.major + " | " + "Immersion: " + basicInfo.immersion + " | " + "Minor: " + basicInfo.minor;
            this.yourCreditLabel.Text = basicInfo.credit;

            this.yourNameLabel.Visible = true;
            this.MMILabel.Visible = true;
            this.yourCreditLabel.Visible = true;
            
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

        private void AddClassButton__Click(object sender, EventArgs e)  //LC and JLH
        {
            ToolStripButton tsb = (ToolStripButton)sender;

            ClassInfo classinfo = new ClassInfo();

            AddEditClass addEditClass = new AddEditClass(classinfo, this);
            addEditClass.Visible = false;

            addEditClass.ShowDialog(this);

            ClassInfo classInfo = addEditClass.formClass;

            GPA = totalGradePoints / totalClassesTaken;
            lblGPA.Text = (Math.Round(GPA, 2).ToString());
            if (GPA >= 2.4) {
                lblAcademicStanding.Text = "You are in good academic standing. ";
                lblAcademicStanding.ForeColor = Color.SeaGreen;
            }
            else if (GPA < 2.4) {
                lblAcademicStanding.Text = "You are at risk of suspension. ";
                lblAcademicStanding.ForeColor = Color.IndianRed;
            }

            AddPanelToClassType(sender, e, classInfo);

            AddPanelToSemesters(classInfo);
        }


        //labels


        private void ToolStripLabels__Click(object sender, EventArgs e)  //LC
        {
            ToolStripLabel tsl = (ToolStripLabel)sender;
            Panel p = (Panel)tsl.Tag;

            ClassInfo classinfo = new ClassInfo();

            AddEditClass addEditClass = new AddEditClass(classinfo, this);
            addEditClass.Visible = false;

            addEditClass.ShowDialog();

            ClassInfo classInfo = addEditClass.formClass;

            p.Controls.Clear();

            if (tsl.Name == "majorToolStripLabel")
            {
                classInfo.classType = types.major;
                MajorAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "minorToolStripLabel")
            {
                classInfo.classType = types.minor;
                MinorAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "immersionToolStripLabel")
            {
                classInfo.classType = types.immersion;
                ImmersionAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "genEdPerToolStripLabel")
            {
                classInfo.classType = types.genEdPer;
                GenEdPerAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "genEdToolStripLabel")
            {
                classInfo.classType = types.genEd;
                GenEdAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "freeToolStripLabel")
            {
                classInfo.classType = types.free;
                FreeAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "adElToolStripLabel")
            {
                classInfo.classType = types.adEl;
                AdElAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "wellnessToolStripLabel")
            {
                classInfo.classType = types.wellness;
                WellnessAddClassToPanel(ref p, classInfo);
            }
            else if (tsl.Name == "coopToolStripLabel")
            {
                classInfo.classType = types.coop;
                CoopAddClassToPanel(ref p, classInfo);
            }
            else //if (tsl.Name == "otherToolStripLabel")
            {
                classInfo.classType = types.otherClasses;
                OtherAddClassToPanel(ref p, classInfo);
            }

            p.Refresh();
        }
        
        

        //panels
        
        private void AddPanelToClassType(object sender, EventArgs e, ClassInfo classInfo)  //LC
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            Panel panel = new System.Windows.Forms.Panel();

            Panel p = (Panel)tsb.Tag;

            if (tsb.Name == "majorAddClassToolStripButton")
            {
                classInfo.classType = types.major;
                MajorAddClassToPanel(ref panel, classInfo);

                this.majorFlowLayoutPanel.Controls.Add(panel);
                this.majorFlowLayoutPanel.Controls.SetChildIndex(panel, majorFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "minorAddClassToolStripButton")
            {
                classInfo.classType = types.minor;
                MinorAddClassToPanel(ref panel, classInfo);

                this.minorFlowLayoutPanel.Controls.Add(panel);
                this.minorFlowLayoutPanel.Controls.SetChildIndex(panel, minorFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "immersionAddClassToolStripButton")
            {
                classInfo.classType = types.immersion;
                ImmersionAddClassToPanel(ref panel, classInfo);

                this.immersionFlowLayoutPanel.Controls.Add(panel);
                this.immersionFlowLayoutPanel.Controls.SetChildIndex(panel, immersionFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "genEdPerAddClassToolStripButton")
            {
                classInfo.classType = types.genEdPer;
                GenEdPerAddClassToPanel(ref panel, classInfo);

                this.genEdPerFlowLayoutPanel.Controls.Add(panel);
                this.genEdPerFlowLayoutPanel.Controls.SetChildIndex(panel, genEdPerFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "genEdAddClassToolStripButton")
            {
                classInfo.classType = types.genEd;
                GenEdAddClassToPanel(ref panel, classInfo);

                this.genEdFlowLayoutPanel.Controls.Add(panel);
                this.genEdFlowLayoutPanel.Controls.SetChildIndex(panel, genEdFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "freeAddClassToolStripButton")
            {
                classInfo.classType = types.free;
                FreeAddClassToPanel(ref panel, classInfo);

                this.freeFlowLayoutPanel.Controls.Add(panel);
                this.freeFlowLayoutPanel.Controls.SetChildIndex(panel, freeFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "adElAddClassToolStripButton")
            {
                classInfo.classType = types.adEl;
                AdElAddClassToPanel(ref panel, classInfo);

                this.adElFlowLayoutPanel.Controls.Add(panel);
                this.adElFlowLayoutPanel.Controls.SetChildIndex(panel, adElFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "wellnessAddClassToolStripButton")
            {
                classInfo.classType = types.wellness;
                WellnessAddClassToPanel(ref panel, classInfo);

                this.wellnessFlowLayoutPanel.Controls.Add(panel);
                this.wellnessFlowLayoutPanel.Controls.SetChildIndex(panel, wellnessFlowLayoutPanel.Controls.Count);
            }
            else if (tsb.Name == "coopAddClassToolStripButton")
            {
                classInfo.classType = types.coop;
                CoopAddClassToPanel(ref panel, classInfo);

                this.coopFlowLayoutPanel.Controls.Add(panel);
                this.coopFlowLayoutPanel.Controls.SetChildIndex(panel, coopFlowLayoutPanel.Controls.Count);
            }
            else //if (tsb.Name == "otherAddClassToolStripButton")
            {
                classInfo.classType = types.otherClasses;
                OtherAddClassToPanel(ref panel, classInfo);

                this.otherFlowLayoutPanel.Controls.Add(panel);
                this.otherFlowLayoutPanel.Controls.SetChildIndex(panel, otherFlowLayoutPanel.Controls.Count);
            }

            p.Refresh();
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
            else
            {
                //undecided is selected
            }

            panel.Refresh();

        }
        private void FreshFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            freshFallLabel = new System.Windows.Forms.Label();

            // freshFallPanel
            panel.Controls.Add(freshFallLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "freshFallPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // freshFallLabel
            freshFallLabel.AutoSize = true;
            freshFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            freshFallLabel.Location = new System.Drawing.Point(0, 0);
            freshFallLabel.Name = "freshFallLabel";
            freshFallLabel.Size = new System.Drawing.Size(82, 13);
            freshFallLabel.TabIndex = 0;
            freshFallLabel.Text = classInfo.department + classInfo.courseCode;
            freshFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void FreshSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            freshSpringLabel = new System.Windows.Forms.Label();

            // Panel
            panel.Controls.Add(freshSpringLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "freshSpringPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // Label
            freshSpringLabel.AutoSize = true;
            freshSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            freshSpringLabel.Location = new System.Drawing.Point(0, 0);
            freshSpringLabel.Name = "freshSpringLabel";
            freshSpringLabel.Size = new System.Drawing.Size(82, 13);
            freshSpringLabel.TabIndex = 0;
            freshSpringLabel.Text = classInfo.department + classInfo.courseCode;
            freshSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SophFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            sophFallLabel = new System.Windows.Forms.Label();

            // Panel
            panel.Controls.Add(sophFallLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "sophFallPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // Label
            sophFallLabel.AutoSize = true;
            sophFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sophFallLabel.Location = new System.Drawing.Point(0, 0);
            sophFallLabel.Name = "sophFallLabel";
            sophFallLabel.Size = new System.Drawing.Size(82, 13);
            sophFallLabel.TabIndex = 0;
            sophFallLabel.Text = classInfo.department + classInfo.courseCode;
            sophFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SophSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            sophSpringLabel = new System.Windows.Forms.Label();

            // Panel
            panel.Controls.Add(sophSpringLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "sophSpringPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // Label
            sophSpringLabel.AutoSize = true;
            sophSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sophSpringLabel.Location = new System.Drawing.Point(0, 0);
            sophSpringLabel.Name = "sophSpringLabel";
            sophSpringLabel.Size = new System.Drawing.Size(82, 13);
            sophSpringLabel.TabIndex = 0;
            sophSpringLabel.Text = classInfo.department + classInfo.courseCode;
            sophSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void JuniorFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            juniorFallLabel = new System.Windows.Forms.Label();

            // Panel
            panel.Controls.Add(juniorFallLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "juniorFallPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // Label
            juniorFallLabel.AutoSize = true;
            juniorFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            juniorFallLabel.Location = new System.Drawing.Point(0, 0);
            juniorFallLabel.Name = "juniorFallLabel";
            juniorFallLabel.Size = new System.Drawing.Size(82, 13);
            juniorFallLabel.TabIndex = 0;
            juniorFallLabel.Text = classInfo.department + classInfo.courseCode;
            juniorFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void JuniorSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            juniorSpringLabel = new System.Windows.Forms.Label();

            // Panel
            panel.Controls.Add(juniorSpringLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "juniorSpringPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // Label
            juniorSpringLabel.AutoSize = true;
            juniorSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            juniorSpringLabel.Location = new System.Drawing.Point(0, 0);
            juniorSpringLabel.Name = "juniorSpringLabel";
            juniorSpringLabel.Size = new System.Drawing.Size(82, 13);
            juniorSpringLabel.TabIndex = 0;
            juniorSpringLabel.Text = classInfo.department + classInfo.courseCode;
            juniorSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SeniorFallAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            seniorFallLabel = new System.Windows.Forms.Label();

            // Panel
            panel.Controls.Add(seniorFallLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "seniorFallPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // Label
            seniorFallLabel.AutoSize = true;
            seniorFallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            seniorFallLabel.Location = new System.Drawing.Point(0, 0);
            seniorFallLabel.Name = "seniorFallLabel";
            seniorFallLabel.Size = new System.Drawing.Size(82, 13);
            seniorFallLabel.TabIndex = 0;
            seniorFallLabel.Text = classInfo.department + classInfo.courseCode;
            seniorFallLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }
        private void SeniorSpringAddClassToPanel(ref Panel panel, ClassInfo classInfo)  // LC
        {
            seniorSpringLabel = new System.Windows.Forms.Label();

            // Panel
            panel.Controls.Add(seniorSpringLabel);
            panel.Location = new System.Drawing.Point(6, 16);
            panel.Name = "seniorSpringPanel";
            panel.Size = new System.Drawing.Size(147, 23);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // Label
            seniorSpringLabel.AutoSize = true;
            seniorSpringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            seniorSpringLabel.Location = new System.Drawing.Point(0, 0);
            seniorSpringLabel.Name = "seniorSpringLabel";
            seniorSpringLabel.Size = new System.Drawing.Size(82, 13);
            seniorSpringLabel.TabIndex = 0;
            seniorSpringLabel.Text = classInfo.department + classInfo.courseCode;
            seniorSpringLabel.Tag = panel;

            if (classInfo.classType == types.major)
            {
                panel.BackColor = System.Drawing.Color.DodgerBlue;
            }
            if (classInfo.classType == types.minor)
            {
                panel.BackColor = System.Drawing.Color.MediumTurquoise;
            }
            if (classInfo.classType == types.immersion)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }
            if (classInfo.classType == types.genEdPer)
            {
                panel.BackColor = System.Drawing.Color.LightPink;
            }
            if (classInfo.classType == types.genEd)
            {
                panel.BackColor = System.Drawing.Color.IndianRed;
            }
            if (classInfo.classType == types.free)
            {
                panel.BackColor = System.Drawing.Color.Coral;
            }
            if (classInfo.classType == types.adEl)
            {
                panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            if (classInfo.classType == types.wellness)
            {
                panel.BackColor = System.Drawing.Color.Khaki;
            }
            if (classInfo.classType == types.coop)
            {
                panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            }
            if (classInfo.classType == types.otherClasses)
            {
                panel.BackColor = System.Drawing.Color.Violet;
            }
        }


        private void MajorAddClassToPanel(ref Panel panel, ClassInfo classInfo)  //LC
        {
            
            Label majorClassTypeLabel = new System.Windows.Forms.Label();
            Label majorClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip majorPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel majorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton majorToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.DodgerBlue;
            panel.Controls.Add(majorClassTypeLabel);
            panel.Controls.Add(majorClassNameLabel);
            panel.Controls.Add(majorPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "majorPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            majorClassTypeLabel.AutoSize = true;
            majorClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            majorClassTypeLabel.Name = "majorClassTypeLabel";
            majorClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            majorClassTypeLabel.TabIndex = 3;
            majorClassTypeLabel.Text = "Counts towards: " + classInfo.classType;
            
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
            Label minorClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip minorPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel minorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton minorToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.MediumTurquoise;
            panel.Controls.Add(minorClassTypeLabel);
            panel.Controls.Add(minorClassNameLabel);
            panel.Controls.Add(minorPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "minorPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            minorClassTypeLabel.AutoSize = true;
            minorClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            minorClassTypeLabel.Name = "minorClassTypeLabel";
            minorClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            minorClassTypeLabel.TabIndex = 3;
            minorClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label immersionClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip immersionPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel immersionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton immersionToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.LightGreen;
            panel.Controls.Add(immersionClassTypeLabel);
            panel.Controls.Add(immersionClassNameLabel);
            panel.Controls.Add(immersionPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "immersionPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            immersionClassTypeLabel.AutoSize = true;
            immersionClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            immersionClassTypeLabel.Name = "immersionClassTypeLabel";
            immersionClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            immersionClassTypeLabel.TabIndex = 3;
            immersionClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label genEdPerClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip genEdPerPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel genEdPerToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton genEdPerToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.LightPink;
            panel.Controls.Add(genEdPerClassTypeLabel);
            panel.Controls.Add(genEdPerClassNameLabel);
            panel.Controls.Add(genEdPerPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "genEdPerPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            genEdPerClassTypeLabel.AutoSize = true;
            genEdPerClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            genEdPerClassTypeLabel.Name = "genEdPerClassTypeLabel";
            genEdPerClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            genEdPerClassTypeLabel.TabIndex = 3;
            genEdPerClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label genEdClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip genEdPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel genEdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton genEdToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.IndianRed;
            panel.Controls.Add(genEdClassTypeLabel);
            panel.Controls.Add(genEdClassNameLabel);
            panel.Controls.Add(genEdPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "genEdPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            genEdClassTypeLabel.AutoSize = true;
            genEdClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            genEdClassTypeLabel.Name = "genEdClassTypeLabel";
            genEdClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            genEdClassTypeLabel.TabIndex = 3;
            genEdClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label freeClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip freePanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel freeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton freeToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.Coral;
            panel.Controls.Add(freeClassTypeLabel);
            panel.Controls.Add(freeClassNameLabel);
            panel.Controls.Add(freePanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "freePanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            freeClassTypeLabel.AutoSize = true;
            freeClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            freeClassTypeLabel.Name = "freeClassTypeLabel";
            freeClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            freeClassTypeLabel.TabIndex = 3;
            freeClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label adElClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip adElPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel adElToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton adElToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            panel.Controls.Add(adElClassTypeLabel);
            panel.Controls.Add(adElClassNameLabel);
            panel.Controls.Add(adElPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "adElPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            adElClassTypeLabel.AutoSize = true;
            adElClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            adElClassTypeLabel.Name = "adElClassTypeLabel";
            adElClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            adElClassTypeLabel.TabIndex = 3;
            adElClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label wellnessClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip wellnessPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel wellnessToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton wellnessToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.Khaki;
            panel.Controls.Add(wellnessClassTypeLabel);
            panel.Controls.Add(wellnessClassNameLabel);
            panel.Controls.Add(wellnessPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "wellnessPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            wellnessClassTypeLabel.AutoSize = true;
            wellnessClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            wellnessClassTypeLabel.Name = "wellnessClassTypeLabel";
            wellnessClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            wellnessClassTypeLabel.TabIndex = 3;
            wellnessClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label coopClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip coopPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel coopToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton coopToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            panel.Controls.Add(coopClassTypeLabel);
            panel.Controls.Add(coopClassNameLabel);
            panel.Controls.Add(coopPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "coopPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            coopClassTypeLabel.AutoSize = true;
            coopClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            coopClassTypeLabel.Name = "coopClassTypeLabel";
            coopClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            coopClassTypeLabel.TabIndex = 3;
            coopClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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
            Label otherClassNameLabel = new System.Windows.Forms.Label();
            ToolStrip otherPanelToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripLabel otherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton otherToolStripButton = new System.Windows.Forms.ToolStripButton();

            // Panel
            panel.BackColor = System.Drawing.Color.Violet;
            panel.Controls.Add(otherClassTypeLabel);
            panel.Controls.Add(otherClassNameLabel);
            panel.Controls.Add(otherPanelToolStrip);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "otherPanel";
            panel.Size = new System.Drawing.Size(330, 27);
            panel.TabIndex = 0;
            panel.Tag = classInfo;

            // ClassTypeLabel
            otherClassTypeLabel.AutoSize = true;
            otherClassTypeLabel.Location = new System.Drawing.Point(7, 77);
            otherClassTypeLabel.Name = "otherClassTypeLabel";
            otherClassTypeLabel.Size = new System.Drawing.Size(112, 13);
            otherClassTypeLabel.TabIndex = 3;
            otherClassTypeLabel.Text = "Counts towards: " + classInfo.classType;

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

        private void btnMinors_Click(object sender, EventArgs e)  //JLH
        {
            MinorGenerator.MinorGenerator minorGenerator = new MinorGenerator.MinorGenerator();
            minorGenerator.ShowDialog();
        }


    }
}