namespace TakenApp
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.task1 = new TakenApp.Task();
            this.task2 = new TakenApp.Task();
            this.task3 = new TakenApp.Task();
            this.task4 = new TakenApp.Task();
            this.task5 = new TakenApp.Task();
            this.task6 = new TakenApp.Task();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.task1);
            this.flowLayoutPanel1.Controls.Add(this.task2);
            this.flowLayoutPanel1.Controls.Add(this.task3);
            this.flowLayoutPanel1.Controls.Add(this.task4);
            this.flowLayoutPanel1.Controls.Add(this.task5);
            this.flowLayoutPanel1.Controls.Add(this.task6);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(648, 400);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTask.Location = new System.Drawing.Point(598, 400);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(50, 50);
            this.BtnAddTask.TabIndex = 1;
            this.BtnAddTask.Text = "+";
            this.BtnAddTask.UseVisualStyleBackColor = true;
            // 
            // task1
            // 
            this.task1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.task1.Location = new System.Drawing.Point(3, 3);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(203, 203);
            this.task1.TabIndex = 0;
            // 
            // task2
            // 
            this.task2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.task2.Location = new System.Drawing.Point(212, 3);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(203, 203);
            this.task2.TabIndex = 1;
            // 
            // task3
            // 
            this.task3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.task3.Location = new System.Drawing.Point(421, 3);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(203, 203);
            this.task3.TabIndex = 2;
            // 
            // task4
            // 
            this.task4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.task4.Location = new System.Drawing.Point(3, 212);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(203, 203);
            this.task4.TabIndex = 3;
            // 
            // task5
            // 
            this.task5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.task5.Location = new System.Drawing.Point(212, 212);
            this.task5.Name = "task5";
            this.task5.Size = new System.Drawing.Size(203, 203);
            this.task5.TabIndex = 4;
            // 
            // task6
            // 
            this.task6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.task6.Location = new System.Drawing.Point(421, 212);
            this.task6.Name = "task6";
            this.task6.Size = new System.Drawing.Size(203, 203);
            this.task6.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(471, 414);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnAddTask;
        private Task task1;
        private Task task2;
        private Task task3;
        private Task task4;
        private Task task5;
        private Task task6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

