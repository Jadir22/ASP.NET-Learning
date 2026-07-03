namespace User_Input_From_TextBox_In_C_
{
    partial class Form1
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
            firstNameTextBox = new TextBox();
            BtnShowFullName = new Button();
            label2 = new Label();
            label3 = new Label();
            middleNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 19);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(328, 19);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(161, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // BtnShowFullName
            // 
            BtnShowFullName.Location = new Point(349, 205);
            BtnShowFullName.Name = "BtnShowFullName";
            BtnShowFullName.Size = new Size(140, 29);
            BtnShowFullName.TabIndex = 2;
            BtnShowFullName.Text = "Show Full Name";
            BtnShowFullName.UseVisualStyleBackColor = true;
            BtnShowFullName.Click += BtnShowFullName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 83);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 3;
            label2.Text = "Middle Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 150);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(328, 83);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(161, 27);
            middleNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(328, 147);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(161, 27);
            lastNameTextBox.TabIndex = 6;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(209, 281);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.ReadOnly = true;
            fullNameTextBox.Size = new Size(280, 27);
            fullNameTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            AcceptButton = BtnShowFullName;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(fullNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(middleNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnShowFullName);
            Controls.Add(firstNameTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstNameTextBox;
        private Button BtnShowFullName;
        private Label label2;
        private Label label3;
        private TextBox middleNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox fullNameTextBox;
    }
}
