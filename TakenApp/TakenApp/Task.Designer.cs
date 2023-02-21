namespace TakenApp
{
    partial class Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LblSubject = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblPriority = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDelete.Location = new System.Drawing.Point(0, 165);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(203, 38);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete task";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEdit.Location = new System.Drawing.Point(0, 127);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(203, 38);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit Task";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // LblSubject
            // 
            this.LblSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubject.Location = new System.Drawing.Point(0, 0);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(203, 37);
            this.LblSubject.TabIndex = 2;
            this.LblSubject.Text = "Onderwerp";
            this.LblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(0, 37);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(100, 90);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "Status:\r\nTO DO";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPriority
            // 
            this.LblPriority.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPriority.Location = new System.Drawing.Point(103, 37);
            this.LblPriority.Name = "LblPriority";
            this.LblPriority.Size = new System.Drawing.Size(100, 90);
            this.LblPriority.TabIndex = 4;
            this.LblPriority.Text = "Priority:\r\n1";
            this.LblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.LblPriority);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblSubject);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(203, 203);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label LblSubject;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblPriority;
    }
}
