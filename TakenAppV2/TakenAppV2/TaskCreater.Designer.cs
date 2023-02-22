namespace TakenAppV2
{
    partial class TaskCreater
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
            this.BtnCreateTask = new System.Windows.Forms.Button();
            this.TbxSubject = new System.Windows.Forms.TextBox();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.CbxPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateTask
            // 
            this.BtnCreateTask.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateTask.Location = new System.Drawing.Point(119, 360);
            this.BtnCreateTask.Name = "BtnCreateTask";
            this.BtnCreateTask.Size = new System.Drawing.Size(144, 40);
            this.BtnCreateTask.TabIndex = 0;
            this.BtnCreateTask.Text = "Create task";
            this.BtnCreateTask.UseVisualStyleBackColor = true;
            this.BtnCreateTask.Click += new System.EventHandler(this.CreateTask);
            // 
            // TbxSubject
            // 
            this.TbxSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxSubject.Location = new System.Drawing.Point(170, 141);
            this.TbxSubject.Name = "TbxSubject";
            this.TbxSubject.Size = new System.Drawing.Size(158, 38);
            this.TbxSubject.TabIndex = 3;
            // 
            // CbxStatus
            // 
            this.CbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxStatus.FormattingEnabled = true;
            this.CbxStatus.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "DONE"});
            this.CbxStatus.Location = new System.Drawing.Point(170, 185);
            this.CbxStatus.Name = "CbxStatus";
            this.CbxStatus.Size = new System.Drawing.Size(158, 39);
            this.CbxStatus.TabIndex = 4;
            // 
            // CbxPriority
            // 
            this.CbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPriority.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxPriority.FormattingEnabled = true;
            this.CbxPriority.Items.AddRange(new object[] {
            "URGENT",
            "HIGH",
            "NORMAL",
            "LOW",
            "NONE"});
            this.CbxPriority.Location = new System.Drawing.Point(170, 230);
            this.CbxPriority.Name = "CbxPriority";
            this.CbxPriority.Size = new System.Drawing.Size(158, 39);
            this.CbxPriority.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Priority:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpDueDate
            // 
            this.DtpDueDate.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpDueDate.Location = new System.Drawing.Point(170, 283);
            this.DtpDueDate.Name = "DtpDueDate";
            this.DtpDueDate.Size = new System.Drawing.Size(158, 27);
            this.DtpDueDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Due Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskCreater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxPriority);
            this.Controls.Add(this.CbxStatus);
            this.Controls.Add(this.TbxSubject);
            this.Controls.Add(this.BtnCreateTask);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "TaskCreater";
            this.Text = "TaskCreater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateTask;
        private System.Windows.Forms.TextBox TbxSubject;
        private System.Windows.Forms.ComboBox CbxStatus;
        private System.Windows.Forms.ComboBox CbxPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDueDate;
        private System.Windows.Forms.Label label4;
    }
}