namespace HelloWorldApp
{
    partial class HelloAppUI
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
            Show_Button = new Button();
            nameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Show_Button
            // 
            Show_Button.Location = new Point(341, 165);
            Show_Button.Name = "Show_Button";
            Show_Button.Size = new Size(94, 29);
            Show_Button.TabIndex = 1;
            Show_Button.Text = "Show";
            Show_Button.UseVisualStyleBackColor = true;
            Show_Button.Click += Show_Button_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(258, 118);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(177, 27);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 114);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 2;
            label1.Text = "Enter Name:";
            label1.Click += label1_Click;
            // 
            // HelloAppUI
            // 
            AcceptButton = Show_Button;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(Show_Button);
            Name = "HelloAppUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello World Application";
            Load += HelloAppUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Show_Button;
        private TextBox nameTextBox;
        private Label label1;
    }
}
