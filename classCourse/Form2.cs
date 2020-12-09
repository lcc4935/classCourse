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
    public partial class AddEditClass : Form
    {
        public ClassInfo formClass;
        public AddEditClass(ClassInfo classInfo, Form parentForm)  //LC
        {
            InitializeComponent();

            this.formClass = classInfo;

            this.newDepartmentTextBox.TextChanged += new EventHandler(NewDepartmentTextBox__TextChanged);
            this.newCourseCodeTextBox.TextChanged += new EventHandler(NewCourseCodeTextBox__TextChanged);
            this.newClassNameTextBox.TextChanged += new EventHandler(NewClassNameTextBox__TextChanged);

            this.submitButton.Click += new EventHandler(SubmitButton__Click);


            if (classInfo.department == null) {
                this.undecidedRadioButton.Checked = true;
            }
            else
            {
                switch (classInfo.semester)
                {
                    case semesters.freshFall:
                        this.freshFallRadioButton.Checked = true;
                        break;
                    case semesters.freshSpring:
                        this.freshSpringRadioButton.Checked = true;
                        break;
                    case semesters.sophFall:
                        this.sophFallRadioButton.Checked = true;
                        break;
                    case semesters.sophSpring:
                        this.sophSpringRadioButton.Checked = true;
                        break;
                    case semesters.juniorFall:
                        this.juniorFallRadioButton.Checked = true;
                        break;
                    case semesters.juniorSpring:
                        this.juniorSpringRadioButton.Checked = true;
                        break;
                    case semesters.seniorFall:
                        this.seniorFallRadioButton.Checked = true;
                        break;
                    case semesters.seniorSpring:
                        this.seniorSpringRadioButton.Checked = true;
                        break;
                    case semesters.undecided:
                        this.undecidedRadioButton.Checked = true;
                        break;
                }

            }
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

        private void SubmitButton__Click(object sender, EventArgs e)  //LC and JLH
        {
            if (this.undecidedRadioButton.Checked)
            {
                this.formClass.semester = semesters.undecided;
            }
            if (this.freshFallRadioButton.Checked)
            {
                this.formClass.semester = semesters.freshFall;
            }
            if (this.freshSpringRadioButton.Checked)
            {
                this.formClass.semester = semesters.freshSpring;
            }
            if (this.sophFallRadioButton.Checked)
            {
                this.formClass.semester = semesters.sophFall;
            }
            if (this.sophSpringRadioButton.Checked)
            {
                this.formClass.semester = semesters.sophSpring;
            }
            if (this.juniorFallRadioButton.Checked)
            {
                this.formClass.semester = semesters.juniorFall;
            }
            if (this.juniorSpringRadioButton.Checked)
            {
                this.formClass.semester = semesters.juniorSpring;
            }
            if (this.seniorFallRadioButton.Checked)
            {
                this.formClass.semester = semesters.seniorFall;
            }
            if (this.seniorSpringRadioButton.Checked)
            {
                this.formClass.semester = semesters.seniorSpring;
            }

            formClass.department = this.newDepartmentTextBox.Text;
            formClass.courseCode = this.newCourseCodeTextBox.Text;
            formClass.className = this.newClassNameTextBox.Text;


            if (gradeCheckBox.Checked) {
                string letterGrade = txtGrade.Text;
                int internalIndex;

                letterGrade = letterGrade.ToUpper();
                internalIndex = Array.IndexOf(classCourse.grades, letterGrade);
                if (internalIndex != -1) {
                    classCourse.totalGradePoints += classCourse.gradePoints[internalIndex];
                    formClass.classGP = classCourse.gradePoints[internalIndex];
                    classCourse.totalClassesTaken++;
                }
            }
            this.Hide();
        }

        private void gradeCheckBox_CheckedChanged(object sender, EventArgs e)  //JLH
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
