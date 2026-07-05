namespace UI_Control_Desktop_App__Registration_Form_
{
    partial class CourseForm
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
            label3 = new Label();
            courseComboBox = new ComboBox();
            addCourseButton = new Button();
            courseListView = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(202, 72);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 6;
            label3.Text = "Course:";
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Items.AddRange(new object[] { "ASP.NET", "COA", "OS", "CVPR" });
            courseComboBox.Location = new Point(319, 69);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(158, 28);
            courseComboBox.TabIndex = 5;
            courseComboBox.Text = "---Select---";
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(346, 134);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(131, 29);
            addCourseButton.TabIndex = 7;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // courseListView
            // 
            courseListView.Location = new Point(202, 249);
            courseListView.Name = "courseListView";
            courseListView.Size = new Size(275, 140);
            courseListView.TabIndex = 8;
            courseListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 211);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 9;
            label1.Text = "Selected Course:";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(courseListView);
            Controls.Add(addCourseButton);
            Controls.Add(label3);
            Controls.Add(courseComboBox);
            Name = "CourseForm";
            Text = "CourseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox courseComboBox;
        private Button addCourseButton;
        private ListView courseListView;
        private Label label1;
    }
}