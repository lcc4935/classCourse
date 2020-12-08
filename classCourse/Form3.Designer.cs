namespace classCourse
{
    partial class PersonalInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.minorTextBox = new System.Windows.Forms.TextBox();
            this.minorLabel = new System.Windows.Forms.Label();
            this.minorCheckBox = new System.Windows.Forms.CheckBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.immersionTextBox = new System.Windows.Forms.TextBox();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.numberCredit = new System.Windows.Forms.Label();
            this.immersionLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(163, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 50;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 49;
            this.nameLabel.Text = "Name";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(88, 241);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 48;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // minorTextBox
            // 
            this.minorTextBox.Location = new System.Drawing.Point(163, 192);
            this.minorTextBox.Name = "minorTextBox";
            this.minorTextBox.Size = new System.Drawing.Size(100, 20);
            this.minorTextBox.TabIndex = 45;
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Location = new System.Drawing.Point(26, 192);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(33, 13);
            this.minorLabel.TabIndex = 44;
            this.minorLabel.Text = "Minor";
            // 
            // minorCheckBox
            // 
            this.minorCheckBox.AutoSize = true;
            this.minorCheckBox.Location = new System.Drawing.Point(29, 152);
            this.minorCheckBox.Name = "minorCheckBox";
            this.minorCheckBox.Size = new System.Drawing.Size(96, 17);
            this.minorCheckBox.TabIndex = 43;
            this.minorCheckBox.Text = "Have a Minor?";
            this.minorCheckBox.UseVisualStyleBackColor = true;
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(163, 112);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditTextBox.TabIndex = 42;
            // 
            // immersionTextBox
            // 
            this.immersionTextBox.Location = new System.Drawing.Point(163, 84);
            this.immersionTextBox.Name = "immersionTextBox";
            this.immersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.immersionTextBox.TabIndex = 38;
            // 
            // majorTextBox
            // 
            this.majorTextBox.Location = new System.Drawing.Point(163, 54);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(100, 20);
            this.majorTextBox.TabIndex = 37;
            // 
            // numberCredit
            // 
            this.numberCredit.AutoSize = true;
            this.numberCredit.Location = new System.Drawing.Point(26, 112);
            this.numberCredit.Name = "numberCredit";
            this.numberCredit.Size = new System.Drawing.Size(118, 13);
            this.numberCredit.TabIndex = 35;
            this.numberCredit.Text = "Number of Total Credits";
            // 
            // immersionLabel
            // 
            this.immersionLabel.AutoSize = true;
            this.immersionLabel.Location = new System.Drawing.Point(26, 84);
            this.immersionLabel.Name = "immersionLabel";
            this.immersionLabel.Size = new System.Drawing.Size(54, 13);
            this.immersionLabel.TabIndex = 33;
            this.immersionLabel.Text = "Immersion";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(26, 54);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(33, 13);
            this.majorLabel.TabIndex = 32;
            this.majorLabel.Text = "Major";
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 299);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.minorTextBox);
            this.Controls.Add(this.minorLabel);
            this.Controls.Add(this.minorCheckBox);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.immersionTextBox);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.numberCredit);
            this.Controls.Add(this.immersionLabel);
            this.Controls.Add(this.majorLabel);
            this.Name = "PersonalInfo";
            this.Text = "Personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox minorTextBox;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.CheckBox minorCheckBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox immersionTextBox;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.Label numberCredit;
        private System.Windows.Forms.Label immersionLabel;
        private System.Windows.Forms.Label majorLabel;
    }
}