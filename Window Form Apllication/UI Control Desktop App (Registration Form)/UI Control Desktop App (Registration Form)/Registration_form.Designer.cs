namespace UI_Control_Desktop_App__Registration_Form_
{
    partial class Registration_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            departmentComboBox = new ComboBox();
            label3 = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            label4 = new Label();
            cppCheckBox = new CheckBox();
            pythonCheckBox = new CheckBox();
            csharpCheckBox = new CheckBox();
            label5 = new Label();
            submitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 25);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 104);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(356, 105);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(158, 27);
            nameTextBox.TabIndex = 2;
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(356, 164);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(158, 28);
            departmentComboBox.TabIndex = 3;
            departmentComboBox.Text = "---Select---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(239, 167);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 4;
            label3.Text = "Department:";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maleRadioButton.Location = new Point(356, 233);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(68, 27);
            maleRadioButton.TabIndex = 5;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            femaleRadioButton.Location = new Point(430, 233);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(85, 27);
            femaleRadioButton.TabIndex = 6;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(239, 231);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 7;
            label4.Text = "Gender:";
            // 
            // cppCheckBox
            // 
            cppCheckBox.AutoSize = true;
            cppCheckBox.Location = new Point(356, 283);
            cppCheckBox.Name = "cppCheckBox";
            cppCheckBox.Size = new Size(60, 24);
            cppCheckBox.TabIndex = 8;
            cppCheckBox.Text = "C++";
            cppCheckBox.UseVisualStyleBackColor = true;
            // 
            // pythonCheckBox
            // 
            pythonCheckBox.AutoSize = true;
            pythonCheckBox.Location = new Point(430, 283);
            pythonCheckBox.Name = "pythonCheckBox";
            pythonCheckBox.Size = new Size(76, 24);
            pythonCheckBox.TabIndex = 9;
            pythonCheckBox.Text = "Python";
            pythonCheckBox.UseVisualStyleBackColor = true;
            // 
            // csharpCheckBox
            // 
            csharpCheckBox.AutoSize = true;
            csharpCheckBox.Location = new Point(522, 283);
            csharpCheckBox.Name = "csharpCheckBox";
            csharpCheckBox.Size = new Size(49, 24);
            csharpCheckBox.TabIndex = 10;
            csharpCheckBox.Text = "C#";
            csharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(239, 283);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 11;
            label5.Text = "Skills:";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.LightSalmon;
            submitButton.Location = new Point(367, 357);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 12;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // Registration_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitButton);
            Controls.Add(label5);
            Controls.Add(csharpCheckBox);
            Controls.Add(pythonCheckBox);
            Controls.Add(cppCheckBox);
            Controls.Add(label4);
            Controls.Add(femaleRadioButton);
            Controls.Add(maleRadioButton);
            Controls.Add(label3);
            Controls.Add(departmentComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration_form";
            Text = "Registration Form";
            Load += Registration_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private ComboBox departmentComboBox;
        private Label label3;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Label label4;
        private CheckBox cppCheckBox;
        private CheckBox pythonCheckBox;
        private CheckBox csharpCheckBox;
        private Label label5;
        private Button submitButton;
    }
}
