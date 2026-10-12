namespace MyToDoApp
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
            TaskTBX = new TextBox();
            AddTaskBtn = new Button();
            TasksLbx = new ListBox();
            SuspendLayout();
            // 
            // TaskTBX
            // 
            TaskTBX.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskTBX.Location = new Point(38, 42);
            TaskTBX.Margin = new Padding(5, 6, 5, 6);
            TaskTBX.Name = "TaskTBX";
            TaskTBX.Size = new Size(328, 35);
            TaskTBX.TabIndex = 0;
            
            // 
            // AddTaskBtn
            // 
            AddTaskBtn.Location = new Point(409, 42);
            AddTaskBtn.Name = "AddTaskBtn";
            AddTaskBtn.Size = new Size(158, 36);
            AddTaskBtn.TabIndex = 1;
            AddTaskBtn.Text = "Add Task";
            AddTaskBtn.UseVisualStyleBackColor = true;
            AddTaskBtn.Click += AddTaskBtn_Click;
            // 
            // TasksLbx
            // 
            TasksLbx.FormattingEnabled = true;
            TasksLbx.Location = new Point(41, 109);
            TasksLbx.Name = "TasksLbx";
            TasksLbx.Size = new Size(514, 544);
            TasksLbx.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 683);
            Controls.Add(TasksLbx);
            Controls.Add(AddTaskBtn);
            Controls.Add(TaskTBX);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskTBX;
        private Button AddTaskBtn;
        private ListBox TasksLbx;
    }
}
